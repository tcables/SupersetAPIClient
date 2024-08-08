// <auto-generated/>
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
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\tag\bulk_create
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Bulk_createRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Bulk_createRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag/bulk_create", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Bulk_createRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag/bulk_create", rawUrl)
        {
        }
        /// <summary>
        /// Get all objects associated with a tag
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Bulk_create400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Bulk_create401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Bulk_create404Error">When receiving a 404 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Bulk_create500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createPostResponse?> PostAsBulk_createPostResponseAsync(global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createPostResponse> PostAsBulk_createPostResponseAsync(global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Bulk_create400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Bulk_create401Error.CreateFromDiscriminatorValue },
                { "404", global::KiotaSupersetAPI.Client.Models.Bulk_create404Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Bulk_create500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createPostResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all objects associated with a tag
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Bulk_create400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Bulk_create401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Bulk_create404Error">When receiving a 404 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Bulk_create500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsBulk_createPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createResponse?> PostAsync(global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createResponse> PostAsync(global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Bulk_create400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Bulk_create401Error.CreateFromDiscriminatorValue },
                { "404", global::KiotaSupersetAPI.Client.Models.Bulk_create404Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Bulk_create500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all objects associated with a tag
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createRequestBuilder WithUrl(string rawUrl)
        {
            return new global::KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create.Bulk_createRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class Bulk_createRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
