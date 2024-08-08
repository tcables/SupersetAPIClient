
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Chart.Item.Cache_screenshot;

/// <summary>
/// Builds and executes requests for operations under \api\v1\chart\{pk}\cache_screenshot
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Cache_screenshotRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Cache_screenshotRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/{pk}/cache_screenshot{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Cache_screenshotRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/{pk}/cache_screenshot{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Compute and cache a screenshot
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ChartCacheScreenshotResponseSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.ChartCacheScreenshotResponseSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.ChartCacheScreenshotResponseSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.ChartCacheScreenshotResponseSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.ChartCacheScreenshotResponseSchema500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KClient.Models.ChartCacheScreenshotResponseSchema?> GetAsync(Action<RequestConfiguration<KApi.Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder.Cache_screenshotRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KClient.Models.ChartCacheScreenshotResponseSchema> GetAsync(Action<RequestConfiguration<KApi.Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder.Cache_screenshotRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.ChartCacheScreenshotResponseSchema400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.ChartCacheScreenshotResponseSchema401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.ChartCacheScreenshotResponseSchema404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.ChartCacheScreenshotResponseSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KClient.Models.ChartCacheScreenshotResponseSchema>(requestInfo, KClient.Models.ChartCacheScreenshotResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Compute and cache a screenshot
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder.Cache_screenshotRequestBuilderGetQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder.Cache_screenshotRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="KApi.Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Compute and cache a screenshot
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Cache_screenshotRequestBuilderGetQueryParameters
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
    public partial class Cache_screenshotRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder.Cache_screenshotRequestBuilderGetQueryParameters>
    {
    }
}
