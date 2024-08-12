
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Chart.Data.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\chart\data\{cache_key}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithCache_keyItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Chart.Data.Item.WithCache_keyItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithCache_keyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/data/{cache_key}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Chart.Data.Item.WithCache_keyItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithCache_keyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/data/{cache_key}", rawUrl)
    {
    }
    /// <summary>
    /// Takes a query context cache key and returns payload data response for the given query.
    /// </summary>
    /// <returns>A <see cref="Models.ChartDataResponseSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.ChartDataResponseSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.ChartDataResponseSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.ChartDataResponseSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.ChartDataResponseSchema422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.ChartDataResponseSchema500Error">When receiving a 500 status code</exception>
    public async Task<Models.ChartDataResponseSchema> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.ChartDataResponseSchema400Error.CreateFromDiscriminatorValue },
            { "401", Models.ChartDataResponseSchema401Error.CreateFromDiscriminatorValue },
            { "404", Models.ChartDataResponseSchema404Error.CreateFromDiscriminatorValue },
            { "422", Models.ChartDataResponseSchema422Error.CreateFromDiscriminatorValue },
            { "500", Models.ChartDataResponseSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Models.ChartDataResponseSchema>(requestInfo, Models.ChartDataResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Takes a query context cache key and returns payload data response for the given query.
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
    /// <returns>A <see cref="Chart.Data.Item.WithCache_keyItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Item.WithCache_keyItemRequestBuilder WithUrl(string rawUrl)
    {
        return new Chart.Data.Item.WithCache_keyItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithCache_keyItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
