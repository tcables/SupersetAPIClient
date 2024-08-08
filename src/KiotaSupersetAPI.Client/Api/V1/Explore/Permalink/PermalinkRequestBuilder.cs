
using KiotaSupersetAPI.Client.Api.V1.Explore.Permalink.Item;
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

namespace KiotaSupersetAPI.Client.Api.V1.Explore.Permalink
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\explore\permalink
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class PermalinkRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.explore.permalink.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="KApi.Explore.Permalink.Item.WithKeyItemRequestBuilder"/></returns>
        public KApi.Explore.Permalink.Item.WithKeyItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("key", position);
                return new KApi.Explore.Permalink.Item.WithKeyItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Explore.Permalink.PermalinkRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PermalinkRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/explore/permalink", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Explore.Permalink.PermalinkRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PermalinkRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/explore/permalink", rawUrl)
        {
        }
        /// <summary>
        /// Create a new permanent link
        /// </summary>
        /// <returns>A <see cref="KApi.Explore.Permalink.PermalinkPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Permalink400Error">When receiving a 400 status code</exception>
        /// <exception cref="KClient.Models.Permalink401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.Permalink422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.Permalink500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Explore.Permalink.PermalinkPostResponse?> PostAsPermalinkPostResponseAsync(KClient.Models.ExplorePermalinkStateSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Explore.Permalink.PermalinkPostResponse> PostAsPermalinkPostResponseAsync(KClient.Models.ExplorePermalinkStateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KClient.Models.Permalink400Error.CreateFromDiscriminatorValue },
                { "401", KClient.Models.Permalink401Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.Permalink422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Permalink500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Explore.Permalink.PermalinkPostResponse>(requestInfo, KApi.Explore.Permalink.PermalinkPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new permanent link
        /// </summary>
        /// <returns>A <see cref="KApi.Explore.Permalink.PermalinkResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Permalink400Error">When receiving a 400 status code</exception>
        /// <exception cref="KClient.Models.Permalink401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.Permalink422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.Permalink500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsPermalinkPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Explore.Permalink.PermalinkResponse?> PostAsync(KClient.Models.ExplorePermalinkStateSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Explore.Permalink.PermalinkResponse> PostAsync(KClient.Models.ExplorePermalinkStateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KClient.Models.Permalink400Error.CreateFromDiscriminatorValue },
                { "401", KClient.Models.Permalink401Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.Permalink422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Permalink500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Explore.Permalink.PermalinkResponse>(requestInfo, KApi.Explore.Permalink.PermalinkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new permanent link
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(KClient.Models.ExplorePermalinkStateSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(KClient.Models.ExplorePermalinkStateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="KApi.Explore.Permalink.PermalinkRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KApi.Explore.Permalink.PermalinkRequestBuilder WithUrl(string rawUrl)
        {
            return new KApi.Explore.Permalink.PermalinkRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class PermalinkRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
