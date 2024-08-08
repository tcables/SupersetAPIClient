
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

namespace KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Thumbnail.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\dashboard\{dashboard_-id}\thumbnail\{digest}
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithDigestItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithDigestItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/thumbnail/{digest}{?q*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithDigestItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/thumbnail/{digest}{?q*}", rawUrl)
        {
        }
        /// <summary>
        /// Computes async or get already computed dashboard thumbnail from cache.
        /// </summary>
        /// <returns>A <see cref="KApi.Dashboard.Item.Thumbnail.Item.WithDigestGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.WithDigest401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.WithDigest404Error">When receiving a 404 status code</exception>
        /// <exception cref="KClient.Models.WithDigest422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.WithDigest500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Dashboard.Item.Thumbnail.Item.WithDigestGetResponse?> GetAsWithDigestGetResponseAsync(Action<RequestConfiguration<KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder.WithDigestItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Dashboard.Item.Thumbnail.Item.WithDigestGetResponse> GetAsWithDigestGetResponseAsync(Action<RequestConfiguration<KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder.WithDigestItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", KClient.Models.WithDigest401Error.CreateFromDiscriminatorValue },
                { "404", KClient.Models.WithDigest404Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.WithDigest422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.WithDigest500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Dashboard.Item.Thumbnail.Item.WithDigestGetResponse>(requestInfo, KApi.Dashboard.Item.Thumbnail.Item.WithDigestGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Computes async or get already computed dashboard thumbnail from cache.
        /// </summary>
        /// <returns>A <see cref="KApi.Dashboard.Item.Thumbnail.Item.WithDigestResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.WithDigest401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.WithDigest404Error">When receiving a 404 status code</exception>
        /// <exception cref="KClient.Models.WithDigest422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.WithDigest500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsWithDigestGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Dashboard.Item.Thumbnail.Item.WithDigestResponse?> GetAsync(Action<RequestConfiguration<KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder.WithDigestItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Dashboard.Item.Thumbnail.Item.WithDigestResponse> GetAsync(Action<RequestConfiguration<KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder.WithDigestItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", KClient.Models.WithDigest401Error.CreateFromDiscriminatorValue },
                { "404", KClient.Models.WithDigest404Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.WithDigest422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.WithDigest500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Dashboard.Item.Thumbnail.Item.WithDigestResponse>(requestInfo, KApi.Dashboard.Item.Thumbnail.Item.WithDigestResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Computes async or get already computed dashboard thumbnail from cache.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder.WithDigestItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder.WithDigestItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder WithUrl(string rawUrl)
        {
            return new KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Computes async or get already computed dashboard thumbnail from cache.
        /// </summary>
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class WithDigestItemRequestBuilderGetQueryParameters 
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
        public partial class WithDigestItemRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder.WithDigestItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
