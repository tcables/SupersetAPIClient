
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Chart;

/// <summary>
/// Builds and executes requests for operations under \api\v1\chart
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ChartRequestBuilder : BaseRequestBuilder
{
    /// <summary>The _info property</summary>
    public KApi.Chart._info._infoRequestBuilder _info
    {
        get => new KApi.Chart._info._infoRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The data property</summary>
    public KApi.Chart.Data.DataRequestBuilder Data
    {
        get => new KApi.Chart.Data.DataRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The export property</summary>
    public KApi.Chart.Export.ExportRequestBuilder Export
    {
        get => new KApi.Chart.Export.ExportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The favorite_status property</summary>
    public KApi.Chart.Favorite_status.Favorite_statusRequestBuilder Favorite_status
    {
        get => new KApi.Chart.Favorite_status.Favorite_statusRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The import property</summary>
    public KApi.Chart.Import.ImportRequestBuilder Import
    {
        get => new KApi.Chart.Import.ImportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related property</summary>
    public KApi.Chart.Related.RelatedRequestBuilder Related
    {
        get => new KApi.Chart.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The warm_up_cache property</summary>
    public KApi.Chart.Warm_up_cache.Warm_up_cacheRequestBuilder Warm_up_cache
    {
        get => new KApi.Chart.Warm_up_cache.Warm_up_cacheRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.chart.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Chart.Item.WithPkItemRequestBuilder"/></returns>
    public KApi.Chart.Item.WithPkItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("pk", position);
            return new KApi.Chart.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.chart.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Chart.Item.WithPkItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public KApi.Chart.Item.WithPkItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("pk", position);
            return new KApi.Chart.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Chart.ChartRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ChartRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Chart.ChartRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ChartRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Bulk delete charts
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.ChartDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Chart401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Chart403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Chart404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Chart422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Chart500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Chart.ChartDeleteResponse> DeleteAsChartDeleteResponseAsync(Action<RequestConfiguration<KApi.Chart.ChartRequestBuilder.ChartRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Chart401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Chart403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Chart404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Chart422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Chart500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Chart.ChartDeleteResponse>(requestInfo, KApi.Chart.ChartDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete charts
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.ChartResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Chart401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Chart403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Chart404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Chart422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Chart500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsChartDeleteResponseAsync instead.")]
    public async Task<KApi.Chart.ChartResponse> DeleteAsync(Action<RequestConfiguration<KApi.Chart.ChartRequestBuilder.ChartRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Chart401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Chart403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Chart404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Chart422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Chart500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Chart.ChartResponse>(requestInfo, KApi.Chart.ChartResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of charts, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.ChartGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Chart400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Chart401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Chart422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Chart500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Chart.ChartGetResponse> GetChartGetResponseAsync(Action<RequestConfiguration<KApi.Chart.ChartRequestBuilder.ChartRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Chart400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Chart401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Chart422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Chart500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Chart.ChartGetResponse>(requestInfo, KApi.Chart.ChartGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of charts, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.ChartResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Chart400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Chart401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Chart422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Chart500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsChartGetResponseAsync instead.")]
    public async Task<KApi.Chart.ChartResponse> GetAsync(Action<RequestConfiguration<KApi.Chart.ChartRequestBuilder.ChartRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Chart400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Chart401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Chart422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Chart500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Chart.ChartResponse>(requestInfo, KApi.Chart.ChartResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new chart
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.ChartPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Chart400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Chart401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Chart403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Chart422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Chart500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Chart.ChartPostResponse> PostAsChartPostResponseAsync(KClient.Models.ChartRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Chart400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Chart401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Chart403Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Chart422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Chart500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Chart.ChartPostResponse>(requestInfo, KApi.Chart.ChartPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new chart
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.ChartResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Chart400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Chart401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Chart403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Chart422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Chart500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsChartPostResponseAsync instead.")]
    public async Task<KApi.Chart.ChartResponse> PostAsync(KClient.Models.ChartRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Chart400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Chart401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Chart403Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Chart422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Chart500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Chart.ChartResponse>(requestInfo, KApi.Chart.ChartResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete charts
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<KApi.Chart.ChartRequestBuilder.ChartRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Gets a list of charts, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Chart.ChartRequestBuilder.ChartRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Create a new chart
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(KClient.Models.ChartRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="KApi.Chart.ChartRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Chart.ChartRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Chart.ChartRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Bulk delete charts
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ChartRequestBuilderDeleteQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ChartRequestBuilderDeleteRequestConfiguration : RequestConfiguration<KApi.Chart.ChartRequestBuilder.ChartRequestBuilderDeleteQueryParameters>
    {
    }
    /// <summary>
    /// Gets a list of charts, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ChartRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ChartRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Chart.ChartRequestBuilder.ChartRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ChartRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
