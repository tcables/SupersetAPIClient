using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using KiotaSupersetAPI.Client.Utilities;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Newtonsoft.Json;

namespace KiotaSupersetAPI.Client;

public class SuperSetAuthenticationProvider : IAuthenticationProvider
{
    private readonly Uri _instance;
    private readonly Uri _baseAddress;
    private readonly string _userName;
    private readonly string _password;

    private DateTime _lastLogin;
    private string _accessToken;
    private string _refreshToken;
    private string _csrfToken;

    public SuperSetAuthenticationProvider(
        string instance,
        string userName,
        string password)
    {
        Check.NotNullOrWhiteSpace(instance, nameof(instance));
        Check.NotNullOrWhiteSpace(userName, nameof(userName));
        Check.NotNullOrWhiteSpace(password, nameof(password));

        _userName = userName;
        _password = password;

        var serverUri = getValidUri(instance);

        _instance = serverUri;
        _baseAddress = new Uri(_instance.AbsoluteUri + EndpointConstants.API_VERSION);
    }

    public async Task AuthenticateRequestAsync(
        RequestInformation request,
        Dictionary<string, object>? additionalAuthenticationContext = null,
        CancellationToken cancellationToken = default)
    {

        if (DateTime.Now - _lastLogin < TimeSpan.FromMinutes(30))
        {
            request.Headers.Add("X-CSRFToken", _csrfToken);
            request.Headers.Add("Authorization", $"Bearer {_accessToken}");

            return;
        }

        var loginPayload = new
        {
            username = _userName,
            password = _password,
            provider = "db",
            refresh = true
        };

        using (var client = new HttpClient())
        {
            client.BaseAddress = _baseAddress;

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));


            var ret = await postAsync(
                client,
                EndpointConstants.SECURITY_LOGIN_ENDPOINT,
                loginPayload,
                new { access_token = "", refresh_token = "" },
                skipTokenRefresh: true,
                cancellationToken: cancellationToken);

            if (cancellationToken.IsCancellationRequested)
            {
                _accessToken = null;
                _refreshToken = null;
                _csrfToken = null;
                client.DefaultRequestHeaders.Authorization = null;

                return;
            }

            if (ret == null)
            {
                throw new Exception("Failed to get access token and refresh token.");
            }

            if (string.IsNullOrEmpty(ret.access_token))
            {
                throw new Exception("Failed to get access token");
            }
            if (string.IsNullOrEmpty(ret.refresh_token))
            {
                throw new Exception("Failed to get refresh token");
            }

            _accessToken = ret.access_token;
            _refreshToken = ret.refresh_token;

            client.DefaultRequestHeaders.Authorization = new
                AuthenticationHeaderValue("Bearer", _accessToken);


            _csrfToken = await getCSRFTokenAsync(client, cancellationToken);

            if (cancellationToken.IsCancellationRequested)
            {
                _accessToken = null;
                _refreshToken = null;
                _csrfToken = null;
                client.DefaultRequestHeaders.Authorization = null;

                return;
            }

            //apply the csrf token to the client
            client.DefaultRequestHeaders.Add("X-CSRFToken", _csrfToken);

            request.Headers.Add("X-CSRFToken", _csrfToken);
            request.Headers.Add("Authorization", $"Bearer {_accessToken}");

            _lastLogin = DateTime.Now;
        }
    }






    #region Private Methods

    private async Task<T> requestAsync<T>(
        HttpClient client,
        string endpoint,
        T anonymousTypeObjectToReturn,
        bool skipTokenRefresh = false,
        CancellationToken cancellationToken = default)
    {
        //remember that 
        //https://stackoverflow.com/questions/28564961/authorization-header-is-lost-on-redirect

        if (!skipTokenRefresh)
        {
            await refreshTokenAsync(client);
        }

        var uri = getValidRelativeUri(endpoint);

        var response = await client
            .GetAsync(uri, cancellationToken);

        var content = await response.Content
            .ReadAsStringAsync(cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            string toThrowMessage = getRequestFailureExceptionMessage(content);

            throw new Exception(
                $"a status code of {response.StatusCode} was thrown for the request. server provided reason: '{response.ReasonPhrase}'. See inner exception for details.",
                new Exception(toThrowMessage));
        }

        var toReturn = JsonConvert.DeserializeAnonymousType(content ?? "", anonymousTypeObjectToReturn);

        return toReturn;
    }

    private async Task<T> requestAsync<T>(
        HttpClient client,
        string endpoint,
        object requestPayload,
        T anonymousTypeObjectToReturn,
        bool skipTokenRefresh = false,
        CancellationToken cancellationToken = default)
    {
        var queryString = getQueryString(endpoint, requestPayload);

        return await requestAsync<T>(
            client,
            queryString,
            anonymousTypeObjectToReturn,
            skipTokenRefresh,
            cancellationToken);
    }

    private async Task<T> postAsync<T, T2>(
        HttpClient client,
        string endpoint,
        T2 payload,
        T anonymousTypeObjectToReturn,
        bool skipTokenRefresh = false,
        CancellationToken cancellationToken = default)
    {
        //remember that 
        //https://stackoverflow.com/questions/28564961/authorization-header-is-lost-on-redirect

        if (!skipTokenRefresh)
        {
            await refreshTokenAsync(client);
        }

        var uri = getValidRelativeUri(endpoint);

        var response = await client
            .PostAsJsonAsync(uri, payload, cancellationToken);

        var content = await response.Content
            .ReadAsStringAsync(cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            string toThrowMessage = getRequestFailureExceptionMessage(content);

            throw new Exception(
                $"a status code of {response.StatusCode} was thrown for the post. server provided reason: '{response.ReasonPhrase}'. See inner exception for details.",
                new Exception(toThrowMessage));
        }

        var toReturn = JsonConvert.DeserializeAnonymousType(content ?? "", anonymousTypeObjectToReturn);

        return toReturn;
    }


    private async Task refreshTokenAsync(
        HttpClient client,
        CancellationToken cancellationToken = default)
    {
        if (!shouldRefreshToken())
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(_refreshToken))
        {
            throw new Exception("No refresh token to refresh with.");
        }


        client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", _refreshToken);

        var ret = await postAsync(
            client,
            EndpointConstants.SECURITY_REFRESH_ENDPOINT,
            "",
            new { access_token = "" },
            skipTokenRefresh: true,
            cancellationToken: cancellationToken);

        if (cancellationToken.IsCancellationRequested)
        {
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", _accessToken);

            return;
        }

        if (ret == null)
        {
            throw new Exception("Failed to get access token and refresh token.");
        }

        if (string.IsNullOrEmpty(ret.access_token))
        {
            throw new Exception("Failed to get access token");
        }
        _accessToken = ret.access_token;

        client.DefaultRequestHeaders.Authorization = new
            AuthenticationHeaderValue("Bearer", _accessToken);

        _csrfToken = await getCSRFTokenAsync(client, cancellationToken);

        _lastLogin = DateTime.Now;
    }

    private async Task<string> getCSRFTokenAsync(
        HttpClient client,
        CancellationToken cancellationToken = default)
    {
        //const string CSRF_TOKEN_URL = "security/csrf_token";
        //this url is exactly as documented in the API, 
        //BUT forces a redirect to 'csrf_token/' which clears the Authorization header
        //https://stackoverflow.com/questions/28564961/authorization-header-is-lost-on-redirect
        //in order to fix this redirect, we must end with a slash



        var ret = await requestAsync(
            client,
            EndpointConstants.SECURITY_CSRF_TOKEN_URL,
            new { result = "" },
            skipTokenRefresh: true,
            cancellationToken: cancellationToken);

        if (ret == null || string.IsNullOrEmpty(ret.result))
        {
            throw new Exception("Failed to get CSRF token");
        }

        return ret.result;
    }


    private bool shouldRefreshToken()
    {
        //refresh tokens every 30 minutes
        return DateTime.Now.Subtract(_lastLogin).TotalMinutes > 30;
    }

    #endregion

    #region Private Helper Methods

    private static string getRequestFailureExceptionMessage(
        string responseContent)
    {
        //api says it will return a message object with a 'message' property
        //but for some reason sometimes returns a 'msg' property instead

        string toThrowMessage = "no error message returned";

        var toThrowMessageObj = JsonConvert
            .DeserializeAnonymousType(responseContent ?? "", new { msg = "" });

        if (toThrowMessageObj != null &&
            !string.IsNullOrWhiteSpace(toThrowMessageObj.msg))
        {
            toThrowMessage = toThrowMessageObj.msg;
        }
        else
        {
            var toThrowMessageObj2 = JsonConvert
                .DeserializeAnonymousType(responseContent ?? "", new { message = "" });

            if (toThrowMessageObj2 != null &&
                !string.IsNullOrWhiteSpace(toThrowMessageObj2.message))
            {
                toThrowMessage = toThrowMessageObj2.message;
            }
        }

        return toThrowMessage;
    }

    private static string getQueryString(
        string endpoint,
        object obj)
    {
        string serialized = JsonConvert.SerializeObject(obj);

        return endpoint + "?q=" + Uri.EscapeDataString(serialized);
    }

    private static Uri getValidRelativeUri(string uri)
    {
        Check.NotNullOrWhiteSpace(uri, nameof(uri));

        uri = uri.TrimStart('/');

        if (Uri.TryCreate(uri, UriKind.Relative, out Uri result))
        {
            return result;
        }
        else
        {
            throw new Exception("Invalid Relative URI");
        }
    }

    private static Uri getValidUri(string uri)
    {
        Check.NotNullOrWhiteSpace(uri, nameof(uri));

        uri = uri.TrimStart('/');

        if (Uri.TryCreate(uri, UriKind.Absolute, out Uri result))
        {
            return result;
        }
        else
        {
            throw new Exception("Invalid Absolute URI");
        }
    }

    #endregion


    private class EndpointConstants
    {
        // TODO: need to figure out why some endpoints end with a slash and some don't

        public const string API_VERSION = "api/v1/";

        public const string SECURITY_LOGIN_ENDPOINT = "security/login"; //must not end with a slash

        public const string SECURITY_CSRF_TOKEN_URL = "security/csrf_token/"; //must end with a slash

        public const string SECURITY_REFRESH_ENDPOINT = "security/refresh"; //must not end with a slash
    }
}
