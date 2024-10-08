
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Security.Refresh;

/// <summary>
/// Builds and executes requests for operations under \api\v1\security\refresh
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class RefreshRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Security.Refresh.RefreshRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public RefreshRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/security/refresh", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Security.Refresh.RefreshRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public RefreshRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/security/refresh", rawUrl)
    {
    }
    /// <summary>
    /// Use the refresh token to get a new JWT access token
    /// </summary>
    /// <returns>A <see cref="Security.Refresh.RefreshPostResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Refresh401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Refresh500Error">When receiving a 500 status code</exception>
    public async Task<Security.Refresh.RefreshPostResponse> PostAsRefreshPostResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToPostRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Refresh401Error.CreateFromDiscriminatorValue },
            { "500", Models.Refresh500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Security.Refresh.RefreshPostResponse>(requestInfo, Security.Refresh.RefreshPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Use the refresh token to get a new JWT access token
    /// </summary>
    /// <returns>A <see cref="Security.Refresh.RefreshResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Refresh401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Refresh500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsRefreshPostResponseAsync instead.")]
    public async Task<Security.Refresh.RefreshResponse> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToPostRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Refresh401Error.CreateFromDiscriminatorValue },
            { "500", Models.Refresh500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Security.Refresh.RefreshResponse>(requestInfo, Security.Refresh.RefreshResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Use the refresh token to get a new JWT access token
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Security.Refresh.RefreshRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public RefreshRequestBuilder WithUrl(string rawUrl)
    {
        return new Refresh.RefreshRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class RefreshRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
