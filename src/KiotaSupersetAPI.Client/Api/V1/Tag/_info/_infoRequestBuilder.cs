
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Tag._info;

/// <summary>
/// Builds and executes requests for operations under \api\v1\tag\_info
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class _infoRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Tag._info._infoRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public _infoRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag/_info{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Tag._info._infoRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public _infoRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag/_info{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Get metadata information about this API resource
    /// </summary>
    /// <returns>A <see cref="KApi.Tag._info._infoGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models._info400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models._info401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models._info422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models._info500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Tag._info._infoGetResponse?> GetAs_infoGetResponseAsync(Action<RequestConfiguration<KApi.Tag._info._infoRequestBuilder._infoRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Tag._info._infoGetResponse> GetAs_infoGetResponseAsync(Action<RequestConfiguration<KApi.Tag._info._infoRequestBuilder._infoRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models._info400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models._info401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models._info422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models._info500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Tag._info._infoGetResponse>(requestInfo, KApi.Tag._info._infoGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get metadata information about this API resource
    /// </summary>
    /// <returns>A <see cref="KApi.Tag._info._infoResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models._info400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models._info401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models._info422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models._info500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAs_infoGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Tag._info._infoResponse?> GetAsync(Action<RequestConfiguration<KApi.Tag._info._infoRequestBuilder._infoRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Tag._info._infoResponse> GetAsync(Action<RequestConfiguration<KApi.Tag._info._infoRequestBuilder._infoRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models._info400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models._info401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models._info422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models._info500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Tag._info._infoResponse>(requestInfo, KApi.Tag._info._infoResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get metadata information about this API resource
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Tag._info._infoRequestBuilder._infoRequestBuilderGetQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Tag._info._infoRequestBuilder._infoRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {
#endif
        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Tag._info._infoRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Tag._info._infoRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Tag._info._infoRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Get metadata information about this API resource
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class _infoRequestBuilderGetQueryParameters
    {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        [QueryParameter("q")]
        public string? Q { get; set; }
#nullable restore
#else
        [QueryParameter("q")]
        public string Q { get; set; }
#endif
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class _infoRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Tag._info._infoRequestBuilder._infoRequestBuilderGetQueryParameters>
    {
    }
}
