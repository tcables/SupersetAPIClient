
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

namespace KiotaSupersetAPI.Client.Api.V1.Dataset.Item.Related_objects
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\dataset\{pk}\related_objects
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Related_objectsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KApi.Dataset.Item.Related_objects.Related_objectsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Related_objectsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/{pk}/related_objects", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Dataset.Item.Related_objects.Related_objectsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Related_objectsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/{pk}/related_objects", rawUrl)
        {
        }
        /// <summary>
        /// Get charts and dashboards count associated to a dataset
        /// </summary>
        /// <returns>A <see cref="KClient.Models.DatasetRelatedObjectsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.DatasetRelatedObjectsResponse401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.DatasetRelatedObjectsResponse404Error">When receiving a 404 status code</exception>
        /// <exception cref="KClient.Models.DatasetRelatedObjectsResponse500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KClient.Models.DatasetRelatedObjectsResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KClient.Models.DatasetRelatedObjectsResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", KClient.Models.DatasetRelatedObjectsResponse401Error.CreateFromDiscriminatorValue },
                { "404", KClient.Models.DatasetRelatedObjectsResponse404Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.DatasetRelatedObjectsResponse500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KClient.Models.DatasetRelatedObjectsResponse>(requestInfo, KClient.Models.DatasetRelatedObjectsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get charts and dashboards count associated to a dataset
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="KApi.Dataset.Item.Related_objects.Related_objectsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KApi.Dataset.Item.Related_objects.Related_objectsRequestBuilder WithUrl(string rawUrl)
        {
            return new KApi.Dataset.Item.Related_objects.Related_objectsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class Related_objectsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
