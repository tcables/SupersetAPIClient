// <auto-generated/>
using KiotaSupersetAPI.Client.Api.V1.Saved_query.Distinct;
using KiotaSupersetAPI.Client.Api.V1.Saved_query.Export;
using KiotaSupersetAPI.Client.Api.V1.Saved_query.Import;
using KiotaSupersetAPI.Client.Api.V1.Saved_query.Item;
using KiotaSupersetAPI.Client.Api.V1.Saved_query.Related;
using KiotaSupersetAPI.Client.Api.V1.Saved_query._info;
using KiotaSupersetAPI.Client.Models.SavedQueryRestApi;
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

namespace KiotaSupersetAPI.Client.Api.V1.Saved_query
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\saved_query
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Saved_queryRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The _info property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Saved_query._info._infoRequestBuilder _info
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Saved_query._info._infoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The distinct property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Distinct.DistinctRequestBuilder Distinct
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Distinct.DistinctRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The export property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Export.ExportRequestBuilder Export
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Export.ExportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The import property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Import.ImportRequestBuilder Import
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Import.ImportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The related property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Related.RelatedRequestBuilder Related
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.saved_query.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Item.WithPkItemRequestBuilder"/></returns>
        public global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Item.WithPkItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("pk", position);
                return new global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.saved_query.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Item.WithPkItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Item.WithPkItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("pk", position);
                return new global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Saved_queryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/saved_query{?q*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Saved_queryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/saved_query{?q*}", rawUrl)
        {
        }
        /// <summary>
        /// Bulk delete saved queries
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryDeleteResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query404Error">When receiving a 404 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryDeleteResponse?> DeleteAsSaved_queryDeleteResponseAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryDeleteResponse> DeleteAsSaved_queryDeleteResponseAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::KiotaSupersetAPI.Client.Models.Saved_query401Error.CreateFromDiscriminatorValue },
                { "404", global::KiotaSupersetAPI.Client.Models.Saved_query404Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Saved_query422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Saved_query500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryDeleteResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Bulk delete saved queries
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query404Error">When receiving a 404 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use DeleteAsSaved_queryDeleteResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse?> DeleteAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse> DeleteAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::KiotaSupersetAPI.Client.Models.Saved_query401Error.CreateFromDiscriminatorValue },
                { "404", global::KiotaSupersetAPI.Client.Models.Saved_query404Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Saved_query422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Saved_query500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a list of saved queries, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryGetResponse?> GetAsSaved_queryGetResponseAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryGetResponse> GetAsSaved_queryGetResponseAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Saved_query400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Saved_query401Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Saved_query422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Saved_query500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryGetResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a list of saved queries, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsSaved_queryGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse?> GetAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse> GetAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Saved_query400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Saved_query401Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Saved_query422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Saved_query500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a saved query
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryPostResponse?> PostAsSaved_queryPostResponseAsync(global::KiotaSupersetAPI.Client.Models.SavedQueryRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryPostResponse> PostAsSaved_queryPostResponseAsync(global::KiotaSupersetAPI.Client.Models.SavedQueryRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Saved_query400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Saved_query401Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Saved_query422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Saved_query500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryPostResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a saved query
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Saved_query500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsSaved_queryPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse?> PostAsync(global::KiotaSupersetAPI.Client.Models.SavedQueryRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse> PostAsync(global::KiotaSupersetAPI.Client.Models.SavedQueryRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Saved_query400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Saved_query401Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Saved_query422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Saved_query500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Bulk delete saved queries
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Gets a list of saved queries, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a saved query
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::KiotaSupersetAPI.Client.Models.SavedQueryRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::KiotaSupersetAPI.Client.Models.SavedQueryRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder WithUrl(string rawUrl)
        {
            return new global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Bulk delete saved queries
        /// </summary>
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class Saved_queryRequestBuilderDeleteQueryParameters 
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
        public partial class Saved_queryRequestBuilderDeleteRequestConfiguration : RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderDeleteQueryParameters>
        {
        }
        /// <summary>
        /// Gets a list of saved queries, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
        /// </summary>
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class Saved_queryRequestBuilderGetQueryParameters 
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
        public partial class Saved_queryRequestBuilderGetRequestConfiguration : RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class Saved_queryRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
