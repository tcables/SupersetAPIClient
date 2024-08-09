
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Filtersets;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dashboard\{dashboard_-id}\filtersets
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class FiltersetsRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.dashboard.item.filtersets.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="Dashboard.Item.Filtersets.Item.WithPkItemRequestBuilder"/></returns>
    public Dashboard.Item.Filtersets.Item.WithPkItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("pk", position);
            return new Dashboard.Item.Filtersets.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.dashboard.item.filtersets.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="Dashboard.Item.Filtersets.Item.WithPkItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public Dashboard.Item.Filtersets.Item.WithPkItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("pk", position);
            return new Dashboard.Item.Filtersets.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Filtersets.FiltersetsRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public FiltersetsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/filtersets", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Filtersets.FiltersetsRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public FiltersetsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/filtersets", rawUrl)
    {
    }
    /// <summary>
    /// Get a dashboard&apos;s list of filter sets
    /// </summary>
    /// <returns>A List&lt;Dashboard.Item.Filtersets.Filtersets&gt;</returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Filtersets400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Filtersets401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Filtersets404Error">When receiving a 404 status code</exception>
    public async Task<List<Dashboard.Item.Filtersets.Filtersets>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Filtersets400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Filtersets401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Filtersets404Error.CreateFromDiscriminatorValue },
        };
        var collectionResult = await RequestAdapter.SendCollectionAsync<Dashboard.Item.Filtersets.Filtersets>(requestInfo, Dashboard.Item.Filtersets.Filtersets.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        return collectionResult?.ToList();
    }
    /// <summary>
    /// Create a new dashboard&apos;s filter set
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Filtersets.FiltersetsPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Filtersets400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Filtersets401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Filtersets404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Filtersets500Error">When receiving a 500 status code</exception>
    public async Task<Dashboard.Item.Filtersets.FiltersetsPostResponse> PostAsFiltersetsPostResponseAsync(KClient.Models.FilterSetRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Filtersets400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Filtersets401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Filtersets404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Filtersets500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Filtersets.FiltersetsPostResponse>(requestInfo, Dashboard.Item.Filtersets.FiltersetsPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new dashboard&apos;s filter set
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Filtersets.FiltersetsResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Filtersets400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Filtersets401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Filtersets404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Filtersets500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsFiltersetsPostResponseAsync instead.")]
    public async Task<Dashboard.Item.Filtersets.FiltersetsResponse> PostAsync(KClient.Models.FilterSetRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Filtersets400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Filtersets401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Filtersets404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Filtersets500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Filtersets.FiltersetsResponse>(requestInfo, Dashboard.Item.Filtersets.FiltersetsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a dashboard&apos;s list of filter sets
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
    /// Create a new dashboard&apos;s filter set
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(KClient.Models.FilterSetRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Dashboard.Item.Filtersets.FiltersetsRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Dashboard.Item.Filtersets.FiltersetsRequestBuilder WithUrl(string rawUrl)
    {
        return new Dashboard.Item.Filtersets.FiltersetsRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class FiltersetsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class FiltersetsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
