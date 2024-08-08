// <auto-generated/>
using KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create;
using KiotaSupersetAPI.Client.Api.V1.Tag.Favorite_status;
using KiotaSupersetAPI.Client.Api.V1.Tag.Get_objects;
using KiotaSupersetAPI.Client.Api.V1.Tag.Item;
using KiotaSupersetAPI.Client.Api.V1.Tag.Related;
using KiotaSupersetAPI.Client.Api.V1.Tag._info;
using KiotaSupersetAPI.Client.Models.TagRestApi;
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

using KApi = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Tag
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\tag
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class TagRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The _info property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Tag._info._infoRequestBuilder _info
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Tag._info._infoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The bulk_create property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createRequestBuilder Bulk_create
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The favorite_status property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Tag.Favorite_status.Favorite_statusRequestBuilder Favorite_status
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Tag.Favorite_status.Favorite_statusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The get_objects property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Tag.Get_objects.Get_objectsRequestBuilder Get_objects
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Tag.Get_objects.Get_objectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The related property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Tag.Related.RelatedRequestBuilder Related
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Tag.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.tag.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.Item.Object_typeItemRequestBuilder"/></returns>
        public global::KiotaSupersetAPI.Client.Api.V1.Tag.Item.Object_typeItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("object_type%2Did", position);
                return new global::KiotaSupersetAPI.Client.Api.V1.Tag.Item.Object_typeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.tag.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.Item.Object_typeItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::KiotaSupersetAPI.Client.Api.V1.Tag.Item.Object_typeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("object_type%2Did", position);
                return new global::KiotaSupersetAPI.Client.Api.V1.Tag.Item.Object_typeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TagRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag{?q*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TagRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag{?q*}", rawUrl)
        {
        }
        /// <summary>
        /// Bulk deletes tags. This will remove all tagged objects with this tag.
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.TagDeleteResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag403Error">When receiving a 403 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag404Error">When receiving a 404 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagDeleteResponse?> DeleteAsTagDeleteResponseAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagDeleteResponse> DeleteAsTagDeleteResponseAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::KiotaSupersetAPI.Client.Models.Tag401Error.CreateFromDiscriminatorValue },
                { "403", global::KiotaSupersetAPI.Client.Models.Tag403Error.CreateFromDiscriminatorValue },
                { "404", global::KiotaSupersetAPI.Client.Models.Tag404Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Tag422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Tag500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagDeleteResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Tag.TagDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Bulk deletes tags. This will remove all tagged objects with this tag.
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag403Error">When receiving a 403 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag404Error">When receiving a 404 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use DeleteAsTagDeleteResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse?> DeleteAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse> DeleteAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::KiotaSupersetAPI.Client.Models.Tag401Error.CreateFromDiscriminatorValue },
                { "403", global::KiotaSupersetAPI.Client.Models.Tag403Error.CreateFromDiscriminatorValue },
                { "404", global::KiotaSupersetAPI.Client.Models.Tag404Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Tag422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Tag500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a list of tags, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.TagGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagGetResponse?> GetAsTagGetResponseAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagGetResponse> GetAsTagGetResponseAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Tag400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Tag401Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Tag422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Tag500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagGetResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Tag.TagGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a list of tags, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsTagGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse?> GetAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse> GetAsync(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Tag400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Tag401Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Tag422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Tag500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new Tag
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.TagPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagPostResponse?> PostAsTagPostResponseAsync(global::KiotaSupersetAPI.Client.Models.TagRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagPostResponse> PostAsTagPostResponseAsync(global::KiotaSupersetAPI.Client.Models.TagRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Tag400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Tag401Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Tag422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Tag500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagPostResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Tag.TagPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new Tag
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Tag500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsTagPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse?> PostAsync(global::KiotaSupersetAPI.Client.Models.TagRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse> PostAsync(global::KiotaSupersetAPI.Client.Models.TagRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Tag400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Tag401Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Tag422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Tag500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Tag.TagResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Bulk deletes tags. This will remove all tagged objects with this tag.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get a list of tags, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new Tag
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::KiotaSupersetAPI.Client.Models.TagRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::KiotaSupersetAPI.Client.Models.TagRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder WithUrl(string rawUrl)
        {
            return new global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Bulk deletes tags. This will remove all tagged objects with this tag.
        /// </summary>
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class TagRequestBuilderDeleteQueryParameters 
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
        public partial class TagRequestBuilderDeleteRequestConfiguration : RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>
        {
        }
        /// <summary>
        /// Get a list of tags, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
        /// </summary>
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class TagRequestBuilderGetQueryParameters 
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
        public partial class TagRequestBuilderGetRequestConfiguration : RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class TagRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
