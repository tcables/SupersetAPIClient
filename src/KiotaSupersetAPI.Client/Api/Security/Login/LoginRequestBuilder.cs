
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Security.Login;

/// <summary>
/// Builds and executes requests for operations under \api\v1\security\login
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class LoginRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Security.Login.LoginRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public LoginRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/security/login", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Security.Login.LoginRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public LoginRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/security/login", rawUrl)
    {
    }
    /// <summary>
    /// Authenticate and get a JWT access and refresh token
    /// </summary>
    /// <returns>A <see cref="Security.Login.LoginPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Login400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Login401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Login500Error">When receiving a 500 status code</exception>
    public async Task<Security.Login.LoginPostResponse> PostAsLoginPostResponseAsync(Security.Login.LoginPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Login400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Login401Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Login500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Security.Login.LoginPostResponse>(requestInfo, Security.Login.LoginPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Authenticate and get a JWT access and refresh token
    /// </summary>
    /// <returns>A <see cref="Security.Login.LoginResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Login400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Login401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Login500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsLoginPostResponseAsync instead.")]
    public async Task<Security.Login.LoginResponse> PostAsync(Security.Login.LoginPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Login400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Login401Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Login500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Security.Login.LoginResponse>(requestInfo, Security.Login.LoginResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Authenticate and get a JWT access and refresh token
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Security.Login.LoginPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Security.Login.LoginRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Security.Login.LoginRequestBuilder WithUrl(string rawUrl)
    {
        return new Security.Login.LoginRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class LoginRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
