
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Dashboard;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dashboard
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class DashboardRequestBuilder : BaseRequestBuilder
{
    /// <summary>The _info property</summary>
    public KApi.Dashboard._info._infoRequestBuilder _info
    {
        get => new KApi.Dashboard._info._infoRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The export property</summary>
    public KApi.Dashboard.Export.ExportRequestBuilder Export
    {
        get => new KApi.Dashboard.Export.ExportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The favorite_status property</summary>
    public KApi.Dashboard.Favorite_status.Favorite_statusRequestBuilder Favorite_status
    {
        get => new KApi.Dashboard.Favorite_status.Favorite_statusRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The import property</summary>
    public KApi.Dashboard.Import.ImportRequestBuilder Import
    {
        get => new KApi.Dashboard.Import.ImportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The permalink property</summary>
    public KApi.Dashboard.Permalink.PermalinkRequestBuilder Permalink
    {
        get => new KApi.Dashboard.Permalink.PermalinkRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related property</summary>
    public KApi.Dashboard.Related.RelatedRequestBuilder Related
    {
        get => new KApi.Dashboard.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.dashboard.item collection</summary>
    /// <param name="position">Either the id of the dashboard, or its slug</param>
    /// <returns>A <see cref="KApi.Dashboard.Item.Dashboard_ItemRequestBuilder"/></returns>
    public KApi.Dashboard.Item.Dashboard_ItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("dashboard_%2Did", position);
            return new KApi.Dashboard.Item.Dashboard_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dashboard.DashboardRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DashboardRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dashboard.DashboardRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DashboardRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Bulk delete dashboards
    /// </summary>
    /// <returns>A <see cref="KApi.Dashboard.DashboardDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Dashboard401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Dashboard403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Dashboard404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Dashboard422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Dashboard500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Dashboard.DashboardDeleteResponse> DeleteAsDashboardDeleteResponseAsync(Action<RequestConfiguration<KApi.Dashboard.DashboardRequestBuilder.DashboardRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Dashboard401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Dashboard403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Dashboard404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Dashboard422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Dashboard500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dashboard.DashboardDeleteResponse>(requestInfo, KApi.Dashboard.DashboardDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete dashboards
    /// </summary>
    /// <returns>A <see cref="KApi.Dashboard.DashboardResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Dashboard401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Dashboard403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Dashboard404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Dashboard422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Dashboard500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsDashboardDeleteResponseAsync instead.")]
    public async Task<KApi.Dashboard.DashboardResponse> DeleteAsync(Action<RequestConfiguration<KApi.Dashboard.DashboardRequestBuilder.DashboardRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Dashboard401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Dashboard403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Dashboard404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Dashboard422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Dashboard500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dashboard.DashboardResponse>(requestInfo, KApi.Dashboard.DashboardResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of dashboards, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Dashboard.DashboardGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Dashboard400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Dashboard401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Dashboard422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Dashboard500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Dashboard.DashboardGetResponse> GetAsDashboardGetResponseAsync(Action<RequestConfiguration<KApi.Dashboard.DashboardRequestBuilder.DashboardRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Dashboard400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Dashboard401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Dashboard422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Dashboard500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dashboard.DashboardGetResponse>(requestInfo, KApi.Dashboard.DashboardGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of dashboards, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Dashboard.DashboardResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Dashboard400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Dashboard401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Dashboard422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Dashboard500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsDashboardGetResponseAsync instead.")]
    public async Task<KApi.Dashboard.DashboardResponse> GetAsync(Action<RequestConfiguration<KApi.Dashboard.DashboardRequestBuilder.DashboardRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Dashboard400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Dashboard401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Dashboard422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Dashboard500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dashboard.DashboardResponse>(requestInfo, KApi.Dashboard.DashboardResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new dashboard
    /// </summary>
    /// <returns>A <see cref="KApi.Dashboard.DashboardPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Dashboard400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Dashboard401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Dashboard404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Dashboard500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Dashboard.DashboardPostResponse> PostAsDashboardPostResponseAsync(KClient.Models.DashboardRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Dashboard400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Dashboard401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Dashboard404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Dashboard500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dashboard.DashboardPostResponse>(requestInfo, KApi.Dashboard.DashboardPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new dashboard
    /// </summary>
    /// <returns>A <see cref="KApi.Dashboard.DashboardResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Dashboard400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Dashboard401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Dashboard404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Dashboard500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsDashboardPostResponseAsync instead.")]
    public async Task<KApi.Dashboard.DashboardResponse> PostAsync(KClient.Models.DashboardRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Dashboard400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Dashboard401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Dashboard404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Dashboard500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dashboard.DashboardResponse>(requestInfo, KApi.Dashboard.DashboardResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete dashboards
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<KApi.Dashboard.DashboardRequestBuilder.DashboardRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Gets a list of dashboards, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Dashboard.DashboardRequestBuilder.DashboardRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Create a new dashboard
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(KClient.Models.DashboardRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="KApi.Dashboard.DashboardRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Dashboard.DashboardRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Dashboard.DashboardRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Bulk delete dashboards
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DashboardRequestBuilderDeleteQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DashboardRequestBuilderDeleteRequestConfiguration : RequestConfiguration<KApi.Dashboard.DashboardRequestBuilder.DashboardRequestBuilderDeleteQueryParameters>
    {
    }
    /// <summary>
    /// Gets a list of dashboards, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DashboardRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DashboardRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Dashboard.DashboardRequestBuilder.DashboardRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DashboardRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
