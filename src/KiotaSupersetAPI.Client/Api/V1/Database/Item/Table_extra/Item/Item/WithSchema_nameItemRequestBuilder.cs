
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

namespace KiotaSupersetAPI.Client.Api.V1.Database.Item.Table_extra.Item.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\database\{pk}\table_extra\{table_name}\{schema_name}
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithSchema_nameItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KApi.Database.Item.Table_extra.Item.Item.WithSchema_nameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSchema_nameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/table_extra/{table_name}/{schema_name}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Database.Item.Table_extra.Item.Item.WithSchema_nameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSchema_nameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/table_extra/{table_name}/{schema_name}", rawUrl)
        {
        }
        /// <summary>
        /// Response depends on each DB engine spec normally focused on partitions.
        /// </summary>
        /// <returns>A <see cref="KClient.Models.TableExtraMetadataResponseSchema"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.TableExtraMetadataResponseSchema400Error">When receiving a 400 status code</exception>
        /// <exception cref="KClient.Models.TableExtraMetadataResponseSchema401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.TableExtraMetadataResponseSchema404Error">When receiving a 404 status code</exception>
        /// <exception cref="KClient.Models.TableExtraMetadataResponseSchema422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.TableExtraMetadataResponseSchema500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KClient.Models.TableExtraMetadataResponseSchema?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KClient.Models.TableExtraMetadataResponseSchema> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KClient.Models.TableExtraMetadataResponseSchema400Error.CreateFromDiscriminatorValue },
                { "401", KClient.Models.TableExtraMetadataResponseSchema401Error.CreateFromDiscriminatorValue },
                { "404", KClient.Models.TableExtraMetadataResponseSchema404Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.TableExtraMetadataResponseSchema422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.TableExtraMetadataResponseSchema500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KClient.Models.TableExtraMetadataResponseSchema>(requestInfo, KClient.Models.TableExtraMetadataResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Response depends on each DB engine spec normally focused on partitions.
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
        /// <returns>A <see cref="KApi.Database.Item.Table_extra.Item.Item.WithSchema_nameItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KApi.Database.Item.Table_extra.Item.Item.WithSchema_nameItemRequestBuilder WithUrl(string rawUrl)
        {
            return new KApi.Database.Item.Table_extra.Item.Item.WithSchema_nameItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class WithSchema_nameItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
