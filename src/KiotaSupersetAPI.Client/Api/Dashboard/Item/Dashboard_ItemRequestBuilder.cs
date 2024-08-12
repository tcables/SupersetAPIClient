
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dashboard\{dashboard_-id}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Dashboard_ItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>The charts property</summary>
    public Charts.ChartsRequestBuilder Charts
    {
        get => new Dashboard.Item.Charts.ChartsRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The copy property</summary>
    public Copy.CopyRequestBuilder Copy
    {
        get => new Dashboard.Item.Copy.CopyRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The datasets property</summary>
    public Datasets.DatasetsRequestBuilder Datasets
    {
        get => new Dashboard.Item.Datasets.DatasetsRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The embedded property</summary>
    public Embedded.EmbeddedRequestBuilder Embedded
    {
        get => new Dashboard.Item.Embedded.EmbeddedRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The favorites property</summary>
    public Favorites.FavoritesRequestBuilder Favorites
    {
        get => new Dashboard.Item.Favorites.FavoritesRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The filter_state property</summary>
    public Filter_state.Filter_stateRequestBuilder Filter_state
    {
        get => new Dashboard.Item.Filter_state.Filter_stateRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The filtersets property</summary>
    public Filtersets.FiltersetsRequestBuilder Filtersets
    {
        get => new Dashboard.Item.Filtersets.FiltersetsRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The permalink property</summary>
    public Permalink.PermalinkRequestBuilder Permalink
    {
        get => new Dashboard.Item.Permalink.PermalinkRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The thumbnail property</summary>
    public Thumbnail.ThumbnailRequestBuilder Thumbnail
    {
        get => new Dashboard.Item.Thumbnail.ThumbnailRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Dashboard_ItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Dashboard_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Dashboard_ItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Dashboard_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}", rawUrl)
    {
    }
    /// <summary>
    /// Delete a dashboard
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Dashboard_DeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Dashboard_401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Dashboard_403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Dashboard_404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Dashboard_422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Dashboard_500Error">When receiving a 500 status code</exception>
    public async Task<Dashboard.Item.Dashboard_DeleteResponse> DeleteAsDashboard_DeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Dashboard_401Error.CreateFromDiscriminatorValue },
            { "403", Models.Dashboard_403Error.CreateFromDiscriminatorValue },
            { "404", Models.Dashboard_404Error.CreateFromDiscriminatorValue },
            { "422", Models.Dashboard_422Error.CreateFromDiscriminatorValue },
            { "500", Models.Dashboard_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Dashboard_DeleteResponse>(requestInfo, Dashboard.Item.Dashboard_DeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a dashboard
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Dashboard_Response"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Dashboard_401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Dashboard_403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Dashboard_404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Dashboard_422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Dashboard_500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsDashboard_DeleteResponseAsync instead.")]
    public async Task<Dashboard.Item.Dashboard_Response> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Dashboard_401Error.CreateFromDiscriminatorValue },
            { "403", Models.Dashboard_403Error.CreateFromDiscriminatorValue },
            { "404", Models.Dashboard_404Error.CreateFromDiscriminatorValue },
            { "422", Models.Dashboard_422Error.CreateFromDiscriminatorValue },
            { "500", Models.Dashboard_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Dashboard_Response>(requestInfo, Dashboard.Item.Dashboard_Response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a dashboard detail information
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Dashboard_GetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Dashboard_400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Dashboard_401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Dashboard_403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Dashboard_404Error">When receiving a 404 status code</exception>
    public async Task<Dashboard.Item.Dashboard_GetResponse> GetDashboard_GetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Dashboard_400Error.CreateFromDiscriminatorValue },
            { "401", Models.Dashboard_401Error.CreateFromDiscriminatorValue },
            { "403", Models.Dashboard_403Error.CreateFromDiscriminatorValue },
            { "404", Models.Dashboard_404Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Dashboard_GetResponse>(requestInfo, Dashboard.Item.Dashboard_GetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a dashboard detail information
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Dashboard_Response"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Dashboard_400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Dashboard_401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Dashboard_403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Dashboard_404Error">When receiving a 404 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsDashboard_GetResponseAsync instead.")]
    public async Task<Dashboard.Item.Dashboard_Response> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Dashboard_400Error.CreateFromDiscriminatorValue },
            { "401", Models.Dashboard_401Error.CreateFromDiscriminatorValue },
            { "403", Models.Dashboard_403Error.CreateFromDiscriminatorValue },
            { "404", Models.Dashboard_404Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Dashboard_Response>(requestInfo, Dashboard.Item.Dashboard_Response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update a dashboard
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Dashboard_PutResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Dashboard_400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Dashboard_401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Dashboard_403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Dashboard_404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Dashboard_422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Dashboard_500Error">When receiving a 500 status code</exception>
    public async Task<Dashboard.Item.Dashboard_PutResponse> PutAsDashboard_PutResponseAsync(Models.DashboardRestAPI.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Dashboard_400Error.CreateFromDiscriminatorValue },
            { "401", Models.Dashboard_401Error.CreateFromDiscriminatorValue },
            { "403", Models.Dashboard_403Error.CreateFromDiscriminatorValue },
            { "404", Models.Dashboard_404Error.CreateFromDiscriminatorValue },
            { "422", Models.Dashboard_422Error.CreateFromDiscriminatorValue },
            { "500", Models.Dashboard_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Dashboard_PutResponse>(requestInfo, Dashboard.Item.Dashboard_PutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update a dashboard
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Dashboard_Response"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Dashboard_400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Dashboard_401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Dashboard_403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Dashboard_404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Dashboard_422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Dashboard_500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PutAsDashboard_PutResponseAsync instead.")]
    public async Task<Dashboard.Item.Dashboard_Response> PutAsync(Models.DashboardRestAPI.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Dashboard_400Error.CreateFromDiscriminatorValue },
            { "401", Models.Dashboard_401Error.CreateFromDiscriminatorValue },
            { "403", Models.Dashboard_403Error.CreateFromDiscriminatorValue },
            { "404", Models.Dashboard_404Error.CreateFromDiscriminatorValue },
            { "422", Models.Dashboard_422Error.CreateFromDiscriminatorValue },
            { "500", Models.Dashboard_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Dashboard_Response>(requestInfo, Dashboard.Item.Dashboard_Response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a dashboard
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
    /// Get a dashboard detail information
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
    /// Update a dashboard
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPutRequestInformation(Models.DashboardRestAPI.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Dashboard.Item.Dashboard_ItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Dashboard_ItemRequestBuilder WithUrl(string rawUrl)
    {
        return new Dashboard.Item.Dashboard_ItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Dashboard_ItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Dashboard_ItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Dashboard_ItemRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
