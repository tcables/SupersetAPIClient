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

namespace KiotaSupersetAPI.Client.Api.V1.Database.Related.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\database\related\{column_name}
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithColumn_nameItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KApi.Database.Related.Item.WithColumn_nameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithColumn_nameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/related/{column_name}{?q*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Database.Related.Item.WithColumn_nameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithColumn_nameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/related/{column_name}{?q*}", rawUrl)
        {
        }
        /// <summary>
        /// Get related fields data
        /// </summary>
        /// <returns>A <see cref="KClient.Models.RelatedResponseSchema"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.RelatedResponseSchema400Error">When receiving a 400 status code</exception>
        /// <exception cref="KClient.Models.RelatedResponseSchema401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.RelatedResponseSchema404Error">When receiving a 404 status code</exception>
        /// <exception cref="KClient.Models.RelatedResponseSchema500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KClient.Models.RelatedResponseSchema?> GetAsync(Action<RequestConfiguration<KApi.Database.Related.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KClient.Models.RelatedResponseSchema> GetAsync(Action<RequestConfiguration<KApi.Database.Related.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KClient.Models.RelatedResponseSchema400Error.CreateFromDiscriminatorValue },
                { "401", KClient.Models.RelatedResponseSchema401Error.CreateFromDiscriminatorValue },
                { "404", KClient.Models.RelatedResponseSchema404Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.RelatedResponseSchema500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KClient.Models.RelatedResponseSchema>(requestInfo, KClient.Models.RelatedResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get related fields data
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Database.Related.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Database.Related.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="KApi.Database.Related.Item.WithColumn_nameItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KApi.Database.Related.Item.WithColumn_nameItemRequestBuilder WithUrl(string rawUrl)
        {
            return new KApi.Database.Related.Item.WithColumn_nameItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get related fields data
        /// </summary>
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class WithColumn_nameItemRequestBuilderGetQueryParameters 
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
        public partial class WithColumn_nameItemRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Database.Related.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
