// <auto-generated/>
using KiotaSupersetAPI.Client.Api.V1.Dataset.Distinct;
using KiotaSupersetAPI.Client.Api.V1.Dataset.Duplicate;
using KiotaSupersetAPI.Client.Api.V1.Dataset.Export;
using KiotaSupersetAPI.Client.Api.V1.Dataset.Get_or_create;
using KiotaSupersetAPI.Client.Api.V1.Dataset.Import;
using KiotaSupersetAPI.Client.Api.V1.Dataset.Item;
using KiotaSupersetAPI.Client.Api.V1.Dataset.Related;
using KiotaSupersetAPI.Client.Api.V1.Dataset.Warm_up_cache;
using KiotaSupersetAPI.Client.Api.V1.Dataset._info;
using KiotaSupersetAPI.Client.Models.DatasetRestApi;
using KiotaSupersetAPI.Client.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using Api = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Dataset
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\dataset
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DatasetRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The _info property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Dataset._info._infoRequestBuilder _info
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Dataset._info._infoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The distinct property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Dataset.Distinct.DistinctRequestBuilder Distinct
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Dataset.Distinct.DistinctRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The duplicate property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Dataset.Duplicate.DuplicateRequestBuilder Duplicate
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Dataset.Duplicate.DuplicateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The export property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Dataset.Export.ExportRequestBuilder Export
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Dataset.Export.ExportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The get_or_create property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Dataset.Get_or_create.Get_or_createRequestBuilder Get_or_create
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Dataset.Get_or_create.Get_or_createRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The import property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Dataset.Import.ImportRequestBuilder Import
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Dataset.Import.ImportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The related property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Dataset.Related.RelatedRequestBuilder Related
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Dataset.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The warm_up_cache property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Dataset.Warm_up_cache.Warm_up_cacheRequestBuilder Warm_up_cache
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Dataset.Warm_up_cache.Warm_up_cacheRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.dataset.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dataset.Item.WithPkItemRequestBuilder"/></returns>
        public global::KiotaSupersetAPI.Client.Api.V1.Dataset.Item.WithPkItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("pk", position);
                return new global::KiotaSupersetAPI.Client.Api.V1.Dataset.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.dataset.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dataset.Item.WithPkItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::KiotaSupersetAPI.Client.Api.V1.Dataset.Item.WithPkItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("pk", position);
                return new global::KiotaSupersetAPI.Client.Api.V1.Dataset.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DatasetRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset{?q*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DatasetRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset{?q*}", rawUrl)
        {
        }
        /// <summary>
        /// Bulk delete datasets
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetDeleteResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset403Error">When receiving a 403 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset404Error">When receiving a 404 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetDeleteResponse?> DeleteAsDatasetDeleteResponseAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetDeleteResponse> DeleteAsDatasetDeleteResponseAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Dataset400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Dataset401Error.CreateFromDiscriminatorValue },
                { "403", global::KiotaSupersetAPI.Client.Models.Dataset403Error.CreateFromDiscriminatorValue },
                { "404", global::KiotaSupersetAPI.Client.Models.Dataset404Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Dataset422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Dataset500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetDeleteResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Bulk delete datasets
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset403Error">When receiving a 403 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset404Error">When receiving a 404 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use DeleteAsDatasetDeleteResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse?> DeleteAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse> DeleteAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Dataset400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Dataset401Error.CreateFromDiscriminatorValue },
                { "403", global::KiotaSupersetAPI.Client.Models.Dataset403Error.CreateFromDiscriminatorValue },
                { "404", global::KiotaSupersetAPI.Client.Models.Dataset404Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Dataset422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Dataset500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a list of datasets, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetGetResponse?> GetAsDatasetGetResponseAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetGetResponse> GetAsDatasetGetResponseAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Dataset400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Dataset401Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Dataset422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Dataset500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetGetResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a list of datasets, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsDatasetGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse?> GetAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse> GetAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Dataset400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Dataset401Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Dataset422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Dataset500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new dataset
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetPostResponse?> PostAsDatasetPostResponseAsync(global::KiotaSupersetAPI.Client.Models.DatasetRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetPostResponse> PostAsDatasetPostResponseAsync(global::KiotaSupersetAPI.Client.Models.DatasetRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Dataset400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Dataset401Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Dataset422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Dataset500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetPostResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new dataset
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Dataset500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsDatasetPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse?> PostAsync(global::KiotaSupersetAPI.Client.Models.DatasetRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse> PostAsync(global::KiotaSupersetAPI.Client.Models.DatasetRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Dataset400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Dataset401Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Dataset422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Dataset500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Bulk delete datasets
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::KiotaSupersetAPI.Client.Models.DatasetRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::KiotaSupersetAPI.Client.Models.DatasetRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
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
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder WithUrl(string rawUrl)
        {
            return new global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Bulk delete datasets
        /// </summary>
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class DatasetRequestBuilderDeleteQueryParameters 
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
        public partial class DatasetRequestBuilderDeleteRequestConfiguration : RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder.DatasetRequestBuilderDeleteQueryParameters>
        {
        }
        /// <summary>
        /// Gets a list of datasets, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
        /// </summary>
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class DatasetRequestBuilderGetQueryParameters 
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
        public partial class DatasetRequestBuilderGetRequestConfiguration : RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dataset.DatasetRequestBuilder.DatasetRequestBuilderGetQueryParameters>
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
}
