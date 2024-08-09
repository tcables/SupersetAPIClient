
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Chart.Item.Cache_screenshot;

/// <summary>
/// Builds and executes requests for operations under \api\v1\chart\{pk}\cache_screenshot
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Cache_screenshotRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Cache_screenshotRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/{pk}/cache_screenshot{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder"/> and sets the default values.
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
    public async Task<KClient.Models.ChartCacheScreenshotResponseSchema> GetAsync(Action<RequestConfiguration<Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder.Cache_screenshotRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

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
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder.Cache_screenshotRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder WithUrl(string rawUrl)
    {
        return new Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Compute and cache a screenshot
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Cache_screenshotRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Cache_screenshotRequestBuilderGetRequestConfiguration : RequestConfiguration<Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder.Cache_screenshotRequestBuilderGetQueryParameters>
    {
    }
}
