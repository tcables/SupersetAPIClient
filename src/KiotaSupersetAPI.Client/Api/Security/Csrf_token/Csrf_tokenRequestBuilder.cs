
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Security.Csrf_token;

/// <summary>
/// Builds and executes requests for operations under \api\v1\security\csrf_token
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Csrf_tokenRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Security.Csrf_token.Csrf_tokenRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Csrf_tokenRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/security/csrf_token", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Security.Csrf_token.Csrf_tokenRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Csrf_tokenRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/security/csrf_token", rawUrl)
    {
    }
    /// <summary>
    /// Get the CSRF token
    /// </summary>
    /// <returns>A <see cref="KApi.Security.Csrf_token.Csrf_tokenGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Csrf_token401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Csrf_token500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Security.Csrf_token.Csrf_tokenGetResponse> GetCsrf_tokenGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Csrf_token401Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Csrf_token500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Security.Csrf_token.Csrf_tokenGetResponse>(requestInfo, KApi.Security.Csrf_token.Csrf_tokenGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get the CSRF token
    /// </summary>
    /// <returns>A <see cref="KApi.Security.Csrf_token.Csrf_tokenResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Csrf_token401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Csrf_token500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsCsrf_tokenGetResponseAsync instead.")]
    public async Task<KApi.Security.Csrf_token.Csrf_tokenResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Csrf_token401Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Csrf_token500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Security.Csrf_token.Csrf_tokenResponse>(requestInfo, KApi.Security.Csrf_token.Csrf_tokenResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get the CSRF token
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Security.Csrf_token.Csrf_tokenRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Security.Csrf_token.Csrf_tokenRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Security.Csrf_token.Csrf_tokenRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Csrf_tokenRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
