
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Dataset;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dataset
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class DatasetRequestBuilder : BaseRequestBuilder
{
    /// <summary>The _info property</summary>
    public KApi.Dataset._info._infoRequestBuilder _info
    {
        get => new KApi.Dataset._info._infoRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The distinct property</summary>
    public KApi.Dataset.Distinct.DistinctRequestBuilder Distinct
    {
        get => new KApi.Dataset.Distinct.DistinctRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The duplicate property</summary>
    public KApi.Dataset.Duplicate.DuplicateRequestBuilder Duplicate
    {
        get => new KApi.Dataset.Duplicate.DuplicateRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The export property</summary>
    public KApi.Dataset.Export.ExportRequestBuilder Export
    {
        get => new KApi.Dataset.Export.ExportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The get_or_create property</summary>
    public KApi.Dataset.Get_or_create.Get_or_createRequestBuilder Get_or_create
    {
        get => new KApi.Dataset.Get_or_create.Get_or_createRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The import property</summary>
    public KApi.Dataset.Import.ImportRequestBuilder Import
    {
        get => new KApi.Dataset.Import.ImportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related property</summary>
    public KApi.Dataset.Related.RelatedRequestBuilder Related
    {
        get => new KApi.Dataset.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The warm_up_cache property</summary>
    public KApi.Dataset.Warm_up_cache.Warm_up_cacheRequestBuilder Warm_up_cache
    {
        get => new KApi.Dataset.Warm_up_cache.Warm_up_cacheRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.dataset.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Dataset.Item.WithPkItemRequestBuilder"/></returns>
    public KApi.Dataset.Item.WithPkItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("pk", position);
            return new KApi.Dataset.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.dataset.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Dataset.Item.WithPkItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public KApi.Dataset.Item.WithPkItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("pk", position);
            return new KApi.Dataset.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.DatasetRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DatasetRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.DatasetRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DatasetRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Bulk delete datasets
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.DatasetDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Dataset400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Dataset401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Dataset403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Dataset404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Dataset422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Dataset500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Dataset.DatasetDeleteResponse> DeleteAsDatasetDeleteResponseAsync(Action<RequestConfiguration<KApi.Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Dataset400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Dataset401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Dataset403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Dataset404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Dataset422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Dataset500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.DatasetDeleteResponse>(requestInfo, KApi.Dataset.DatasetDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete datasets
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.DatasetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Dataset400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Dataset401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Dataset403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Dataset404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Dataset422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Dataset500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsDatasetDeleteResponseAsync instead.")]
    public async Task<KApi.Dataset.DatasetResponse> DeleteAsync(Action<RequestConfiguration<KApi.Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Dataset400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Dataset401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Dataset403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Dataset404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Dataset422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Dataset500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.DatasetResponse>(requestInfo, KApi.Dataset.DatasetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of datasets, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.DatasetGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Dataset400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Dataset401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Dataset422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Dataset500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Dataset.DatasetGetResponse> GetAsDatasetGetResponseAsync(Action<RequestConfiguration<KApi.Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Dataset400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Dataset401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Dataset422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Dataset500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.DatasetGetResponse>(requestInfo, KApi.Dataset.DatasetGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of datasets, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.DatasetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Dataset400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Dataset401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Dataset422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Dataset500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsDatasetGetResponseAsync instead.")]
    public async Task<KApi.Dataset.DatasetResponse> GetAsync(Action<RequestConfiguration<KApi.Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Dataset400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Dataset401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Dataset422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Dataset500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.DatasetResponse>(requestInfo, KApi.Dataset.DatasetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new dataset
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.DatasetPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Dataset400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Dataset401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Dataset422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Dataset500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Dataset.DatasetPostResponse> PostAsDatasetPostResponseAsync(KClient.Models.DatasetRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Dataset400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Dataset401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Dataset422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Dataset500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.DatasetPostResponse>(requestInfo, KApi.Dataset.DatasetPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new dataset
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.DatasetResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Dataset400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Dataset401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Dataset422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Dataset500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsDatasetPostResponseAsync instead.")]
    public async Task<KApi.Dataset.DatasetResponse> PostAsync(KClient.Models.DatasetRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Dataset400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Dataset401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Dataset422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Dataset500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.DatasetResponse>(requestInfo, KApi.Dataset.DatasetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete datasets
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<KApi.Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Gets a list of datasets, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Create a new dataset
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(KClient.Models.DatasetRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="KApi.Dataset.DatasetRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Dataset.DatasetRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Dataset.DatasetRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Bulk delete datasets
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DatasetRequestBuilderDeleteQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DatasetRequestBuilderDeleteRequestConfiguration : RequestConfiguration<KApi.Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>
    {
    }
    /// <summary>
    /// Gets a list of datasets, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DatasetRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DatasetRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DatasetRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
