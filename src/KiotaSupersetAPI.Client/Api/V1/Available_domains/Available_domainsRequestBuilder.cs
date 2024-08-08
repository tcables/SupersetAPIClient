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

using Api = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Available_domains
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\available_domains
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Available_domainsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Available_domainsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/available_domains", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Available_domainsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/available_domains", rawUrl)
        {
        }
        /// <summary>
        /// Get all available domains
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Available_domains401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Available_domains403Error">When receiving a 403 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsGetResponse?> GetAsAvailable_domainsGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsGetResponse> GetAsAvailable_domainsGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::KiotaSupersetAPI.Client.Models.Available_domains401Error.CreateFromDiscriminatorValue },
                { "403", global::KiotaSupersetAPI.Client.Models.Available_domains403Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsGetResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all available domains
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Available_domains401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KiotaSupersetAPI.Client.Models.Available_domains403Error">When receiving a 403 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsAvailable_domainsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::KiotaSupersetAPI.Client.Models.Available_domains401Error.CreateFromDiscriminatorValue },
                { "403", global::KiotaSupersetAPI.Client.Models.Available_domains403Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsResponse>(requestInfo, global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all available domains
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
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::KiotaSupersetAPI.Client.Api.V1.Available_domains.Available_domainsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class Available_domainsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
