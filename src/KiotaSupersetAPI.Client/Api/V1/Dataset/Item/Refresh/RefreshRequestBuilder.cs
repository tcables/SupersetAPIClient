
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

namespace KiotaSupersetAPI.Client.Api.V1.Dataset.Item.Refresh
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\dataset\{pk}\refresh
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class RefreshRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KApi.Dataset.Item.Refresh.RefreshRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RefreshRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/{pk}/refresh", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Dataset.Item.Refresh.RefreshRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RefreshRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/{pk}/refresh", rawUrl)
        {
        }
        /// <summary>
        /// Refresh and update columns of a dataset
        /// </summary>
        /// <returns>A <see cref="KApi.Dataset.Item.Refresh.RefreshPutResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Refresh401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.Refresh403Error">When receiving a 403 status code</exception>
        /// <exception cref="KClient.Models.Refresh404Error">When receiving a 404 status code</exception>
        /// <exception cref="KClient.Models.Refresh422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.Refresh500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Dataset.Item.Refresh.RefreshPutResponse?> PutAsRefreshPutResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Dataset.Item.Refresh.RefreshPutResponse> PutAsRefreshPutResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPutRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", KClient.Models.Refresh401Error.CreateFromDiscriminatorValue },
                { "403", KClient.Models.Refresh403Error.CreateFromDiscriminatorValue },
                { "404", KClient.Models.Refresh404Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.Refresh422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Refresh500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Dataset.Item.Refresh.RefreshPutResponse>(requestInfo, KApi.Dataset.Item.Refresh.RefreshPutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Refresh and update columns of a dataset
        /// </summary>
        /// <returns>A <see cref="KApi.Dataset.Item.Refresh.RefreshResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Refresh401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.Refresh403Error">When receiving a 403 status code</exception>
        /// <exception cref="KClient.Models.Refresh404Error">When receiving a 404 status code</exception>
        /// <exception cref="KClient.Models.Refresh422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.Refresh500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use PutAsRefreshPutResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Dataset.Item.Refresh.RefreshResponse?> PutAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Dataset.Item.Refresh.RefreshResponse> PutAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPutRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", KClient.Models.Refresh401Error.CreateFromDiscriminatorValue },
                { "403", KClient.Models.Refresh403Error.CreateFromDiscriminatorValue },
                { "404", KClient.Models.Refresh404Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.Refresh422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Refresh500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Dataset.Item.Refresh.RefreshResponse>(requestInfo, KApi.Dataset.Item.Refresh.RefreshResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Refresh and update columns of a dataset
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="KApi.Dataset.Item.Refresh.RefreshRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KApi.Dataset.Item.Refresh.RefreshRequestBuilder WithUrl(string rawUrl)
        {
            return new KApi.Dataset.Item.Refresh.RefreshRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class RefreshRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
