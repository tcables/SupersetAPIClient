
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

namespace KiotaSupersetAPI.Client.Api.V1.Database.Item.Ssh_tunnel
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\database\{pk}\ssh_tunnel
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Ssh_tunnelRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KApi.Database.Item.Ssh_tunnel.Ssh_tunnelRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Ssh_tunnelRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/ssh_tunnel", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Database.Item.Ssh_tunnel.Ssh_tunnelRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Ssh_tunnelRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/ssh_tunnel", rawUrl)
        {
        }
        /// <summary>
        /// Delete a SSH tunnel
        /// </summary>
        /// <returns>A <see cref="KApi.Database.Item.Ssh_tunnel.Ssh_tunnelDeleteResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Ssh_tunnel401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.Ssh_tunnel403Error">When receiving a 403 status code</exception>
        /// <exception cref="KClient.Models.Ssh_tunnel404Error">When receiving a 404 status code</exception>
        /// <exception cref="KClient.Models.Ssh_tunnel422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.Ssh_tunnel500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Database.Item.Ssh_tunnel.Ssh_tunnelDeleteResponse?> DeleteAsSsh_tunnelDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Database.Item.Ssh_tunnel.Ssh_tunnelDeleteResponse> DeleteAsSsh_tunnelDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", KClient.Models.Ssh_tunnel401Error.CreateFromDiscriminatorValue },
                { "403", KClient.Models.Ssh_tunnel403Error.CreateFromDiscriminatorValue },
                { "404", KClient.Models.Ssh_tunnel404Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.Ssh_tunnel422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Ssh_tunnel500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Database.Item.Ssh_tunnel.Ssh_tunnelDeleteResponse>(requestInfo, KApi.Database.Item.Ssh_tunnel.Ssh_tunnelDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a SSH tunnel
        /// </summary>
        /// <returns>A <see cref="KApi.Database.Item.Ssh_tunnel.Ssh_tunnelResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Ssh_tunnel401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.Ssh_tunnel403Error">When receiving a 403 status code</exception>
        /// <exception cref="KClient.Models.Ssh_tunnel404Error">When receiving a 404 status code</exception>
        /// <exception cref="KClient.Models.Ssh_tunnel422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.Ssh_tunnel500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use DeleteAsSsh_tunnelDeleteResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Database.Item.Ssh_tunnel.Ssh_tunnelResponse?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Database.Item.Ssh_tunnel.Ssh_tunnelResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", KClient.Models.Ssh_tunnel401Error.CreateFromDiscriminatorValue },
                { "403", KClient.Models.Ssh_tunnel403Error.CreateFromDiscriminatorValue },
                { "404", KClient.Models.Ssh_tunnel404Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.Ssh_tunnel422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Ssh_tunnel500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Database.Item.Ssh_tunnel.Ssh_tunnelResponse>(requestInfo, KApi.Database.Item.Ssh_tunnel.Ssh_tunnelResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a SSH tunnel
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="KApi.Database.Item.Ssh_tunnel.Ssh_tunnelRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KApi.Database.Item.Ssh_tunnel.Ssh_tunnelRequestBuilder WithUrl(string rawUrl)
        {
            return new KApi.Database.Item.Ssh_tunnel.Ssh_tunnelRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class Ssh_tunnelRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
