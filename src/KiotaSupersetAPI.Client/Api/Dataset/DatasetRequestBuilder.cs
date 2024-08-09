
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dataset;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dataset
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class DatasetRequestBuilder : BaseRequestBuilder
{
    /// <summary>The _info property</summary>
    public Dataset._info._infoRequestBuilder _info
    {
        get => new Dataset._info._infoRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The distinct property</summary>
    public Dataset.Distinct.DistinctRequestBuilder Distinct
    {
        get => new Dataset.Distinct.DistinctRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The duplicate property</summary>
    public Dataset.Duplicate.DuplicateRequestBuilder Duplicate
    {
        get => new Dataset.Duplicate.DuplicateRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The export property</summary>
    public Dataset.Export.ExportRequestBuilder Export
    {
        get => new Dataset.Export.ExportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The get_or_create property</summary>
    public Dataset.Get_or_create.Get_or_createRequestBuilder Get_or_create
    {
        get => new Dataset.Get_or_create.Get_or_createRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The import property</summary>
    public Dataset.Import.ImportRequestBuilder Import
    {
        get => new Dataset.Import.ImportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related property</summary>
    public Dataset.Related.RelatedRequestBuilder Related
    {
        get => new Dataset.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The warm_up_cache property</summary>
    public Dataset.Warm_up_cache.Warm_up_cacheRequestBuilder Warm_up_cache
    {
        get => new Dataset.Warm_up_cache.Warm_up_cacheRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.dataset.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="Dataset.Item.WithPkItemRequestBuilder"/></returns>
    public Dataset.Item.WithPkItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("pk", position);
            return new Dataset.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.dataset.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="Dataset.Item.WithPkItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public Dataset.Item.WithPkItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("pk", position);
            return new Dataset.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Dataset.DatasetRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DatasetRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dataset.DatasetRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DatasetRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Bulk delete datasets
    /// </summary>
    /// <returns>A <see cref="Dataset.DatasetDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Dataset400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Dataset401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Dataset403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Dataset404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Dataset422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Dataset500Error">When receiving a 500 status code</exception>
    public async Task<Dataset.DatasetDeleteResponse> DeleteAsDatasetDeleteResponseAsync(Action<RequestConfiguration<Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Dataset400Error.CreateFromDiscriminatorValue },
            { "401", Models.Dataset401Error.CreateFromDiscriminatorValue },
            { "403", Models.Dataset403Error.CreateFromDiscriminatorValue },
            { "404", Models.Dataset404Error.CreateFromDiscriminatorValue },
            { "422", Models.Dataset422Error.CreateFromDiscriminatorValue },
            { "500", Models.Dataset500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dataset.DatasetDeleteResponse>(requestInfo, Dataset.DatasetDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete datasets
    /// </summary>
    /// <returns>A <see cref="Dataset.DatasetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Dataset400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Dataset401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Dataset403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Dataset404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Dataset422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Dataset500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsDatasetDeleteResponseAsync instead.")]
    public async Task<Dataset.DatasetResponse> DeleteAsync(Action<RequestConfiguration<Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Dataset400Error.CreateFromDiscriminatorValue },
            { "401", Models.Dataset401Error.CreateFromDiscriminatorValue },
            { "403", Models.Dataset403Error.CreateFromDiscriminatorValue },
            { "404", Models.Dataset404Error.CreateFromDiscriminatorValue },
            { "422", Models.Dataset422Error.CreateFromDiscriminatorValue },
            { "500", Models.Dataset500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dataset.DatasetResponse>(requestInfo, Dataset.DatasetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of datasets, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="Dataset.DatasetGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Dataset400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Dataset401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Dataset422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Dataset500Error">When receiving a 500 status code</exception>
    public async Task<Dataset.DatasetGetResponse> GetDatasetGetResponseAsync(Action<RequestConfiguration<Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Dataset400Error.CreateFromDiscriminatorValue },
            { "401", Models.Dataset401Error.CreateFromDiscriminatorValue },
            { "422", Models.Dataset422Error.CreateFromDiscriminatorValue },
            { "500", Models.Dataset500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dataset.DatasetGetResponse>(requestInfo, Dataset.DatasetGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of datasets, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="Dataset.DatasetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Dataset400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Dataset401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Dataset422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Dataset500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsDatasetGetResponseAsync instead.")]
    public async Task<Dataset.DatasetResponse> GetAsync(Action<RequestConfiguration<Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Dataset400Error.CreateFromDiscriminatorValue },
            { "401", Models.Dataset401Error.CreateFromDiscriminatorValue },
            { "422", Models.Dataset422Error.CreateFromDiscriminatorValue },
            { "500", Models.Dataset500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dataset.DatasetResponse>(requestInfo, Dataset.DatasetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new dataset
    /// </summary>
    /// <returns>A <see cref="Dataset.DatasetPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Dataset400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Dataset401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Dataset422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Dataset500Error">When receiving a 500 status code</exception>
    public async Task<Dataset.DatasetPostResponse> PostAsDatasetPostResponseAsync(Models.DatasetRestAPI.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Dataset400Error.CreateFromDiscriminatorValue },
            { "401", Models.Dataset401Error.CreateFromDiscriminatorValue },
            { "422", Models.Dataset422Error.CreateFromDiscriminatorValue },
            { "500", Models.Dataset500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dataset.DatasetPostResponse>(requestInfo, Dataset.DatasetPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new dataset
    /// </summary>
    /// <returns>A <see cref="Dataset.DatasetResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Dataset400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Dataset401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Dataset422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Dataset500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsDatasetPostResponseAsync instead.")]
    public async Task<Dataset.DatasetResponse> PostAsync(Models.DatasetRestAPI.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Dataset400Error.CreateFromDiscriminatorValue },
            { "401", Models.Dataset401Error.CreateFromDiscriminatorValue },
            { "422", Models.Dataset422Error.CreateFromDiscriminatorValue },
            { "500", Models.Dataset500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dataset.DatasetResponse>(requestInfo, Dataset.DatasetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete datasets
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
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
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
    public RequestInformation ToPostRequestInformation(Models.DatasetRestAPI.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Dataset.DatasetRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Dataset.DatasetRequestBuilder WithUrl(string rawUrl)
    {
        return new Dataset.DatasetRequestBuilder(rawUrl, RequestAdapter);
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
    public partial class DatasetRequestBuilderDeleteRequestConfiguration : RequestConfiguration<Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>
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
    public partial class DatasetRequestBuilderGetRequestConfiguration : RequestConfiguration<Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>
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
