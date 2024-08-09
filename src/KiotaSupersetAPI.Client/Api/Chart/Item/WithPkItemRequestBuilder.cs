
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Chart.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\chart\{pk}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithPkItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>The cache_screenshot property</summary>
    public Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder Cache_screenshot
    {
        get => new Chart.Item.Cache_screenshot.Cache_screenshotRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The data property</summary>
    public Chart.Item.Data.DataRequestBuilder Data
    {
        get => new Chart.Item.Data.DataRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The favorites property</summary>
    public Chart.Item.Favorites.FavoritesRequestBuilder Favorites
    {
        get => new Chart.Item.Favorites.FavoritesRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The screenshot property</summary>
    public Chart.Item.Screenshot.ScreenshotRequestBuilder Screenshot
    {
        get => new Chart.Item.Screenshot.ScreenshotRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The thumbnail property</summary>
    public Chart.Item.Thumbnail.ThumbnailRequestBuilder Thumbnail
    {
        get => new Chart.Item.Thumbnail.ThumbnailRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="Chart.Item.WithPkItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithPkItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/{pk}{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Chart.Item.WithPkItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithPkItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/{pk}{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Delete a chart
    /// </summary>
    /// <returns>A <see cref="Chart.Item.WithPkDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    public async Task<Chart.Item.WithPkDeleteResponse> DeleteAsWithPkDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Chart.Item.WithPkDeleteResponse>(requestInfo, Chart.Item.WithPkDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a chart
    /// </summary>
    /// <returns>A <see cref="Chart.Item.WithPkResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsWithPkDeleteResponseAsync instead.")]
    public async Task<Chart.Item.WithPkResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Chart.Item.WithPkResponse>(requestInfo, Chart.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="Chart.Item.WithPkGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    public async Task<Chart.Item.WithPkGetResponse> GetWithPkGetResponseAsync(Action<RequestConfiguration<Chart.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Chart.Item.WithPkGetResponse>(requestInfo, Chart.Item.WithPkGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="Chart.Item.WithPkResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithPkGetResponseAsync instead.")]
    public async Task<Chart.Item.WithPkResponse> GetAsync(Action<RequestConfiguration<Chart.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Chart.Item.WithPkResponse>(requestInfo, Chart.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update a chart
    /// </summary>
    /// <returns>A <see cref="Chart.Item.WithPkPutResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    public async Task<Chart.Item.WithPkPutResponse> PutAsWithPkPutResponseAsync(KClient.Models.ChartRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Chart.Item.WithPkPutResponse>(requestInfo, Chart.Item.WithPkPutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update a chart
    /// </summary>
    /// <returns>A <see cref="Chart.Item.WithPkResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PutAsWithPkPutResponseAsync instead.")]
    public async Task<Chart.Item.WithPkResponse> PutAsync(KClient.Models.ChartRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Chart.Item.WithPkResponse>(requestInfo, Chart.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a chart
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Chart.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Update a chart
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPutRequestInformation(KClient.Models.ChartRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Chart.Item.WithPkItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Chart.Item.WithPkItemRequestBuilder WithUrl(string rawUrl)
    {
        return new Chart.Item.WithPkItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Chart.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
