// <auto-generated/>
using KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Item;
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

namespace KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\dashboard\{dashboard_-id}\filter_state
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Filter_stateRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.dashboard.item.filter_state.item collection</summary>
        /// <param name="position">The value key.</param>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Item.WithKeyItemRequestBuilder"/></returns>
        public global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Item.WithKeyItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("key", position);
                return new global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Item.WithKeyItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Filter_stateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/filter_state{?tab_id*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Filter_stateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/filter_state{?tab_id*}", rawUrl)
        {
        }
        /// <summary>
        /// Create a dashboard&apos;s filter state
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_statePostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Filter_state400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Filter_state401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Filter_state422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Filter_state500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_statePostResponse?> PostAsFilter_statePostResponseAsync(global::KiotaSupersetAPI.Client.Models.TemporaryCachePostSchema body, Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateRequestBuilder.Filter_stateRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_statePostResponse> PostAsFilter_statePostResponseAsync(global::KiotaSupersetAPI.Client.Models.TemporaryCachePostSchema body, Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateRequestBuilder.Filter_stateRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Filter_state400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Filter_state401Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Filter_state422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Filter_state500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_statePostResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_statePostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a dashboard&apos;s filter state
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Filter_state400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Filter_state401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Filter_state422Error">When receiving a 422 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Filter_state500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsFilter_statePostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateResponse?> PostAsync(global::KiotaSupersetAPI.Client.Models.TemporaryCachePostSchema body, Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateRequestBuilder.Filter_stateRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateResponse> PostAsync(global::KiotaSupersetAPI.Client.Models.TemporaryCachePostSchema body, Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateRequestBuilder.Filter_stateRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KiotaSupersetAPI.Client.Models.Filter_state400Error.CreateFromDiscriminatorValue },
                { "401", global::KiotaSupersetAPI.Client.Models.Filter_state401Error.CreateFromDiscriminatorValue },
                { "422", global::KiotaSupersetAPI.Client.Models.Filter_state422Error.CreateFromDiscriminatorValue },
                { "500", global::KiotaSupersetAPI.Client.Models.Filter_state500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a dashboard&apos;s filter state
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::KiotaSupersetAPI.Client.Models.TemporaryCachePostSchema body, Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateRequestBuilder.Filter_stateRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::KiotaSupersetAPI.Client.Models.TemporaryCachePostSchema body, Action<RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateRequestBuilder.Filter_stateRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateRequestBuilder WithUrl(string rawUrl)
        {
            return new global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Create a dashboard&apos;s filter state
        /// </summary>
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class Filter_stateRequestBuilderPostQueryParameters 
        {
            [QueryParameter("tab_id")]
            public int? TabId { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class Filter_stateRequestBuilderPostRequestConfiguration : RequestConfiguration<global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filter_state.Filter_stateRequestBuilder.Filter_stateRequestBuilderPostQueryParameters>
        {
        }
    }
}
