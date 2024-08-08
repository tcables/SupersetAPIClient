
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

namespace KiotaSupersetAPI.Client.Api.V1.Database.Test_connection
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\database\test_connection
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Test_connectionRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KApi.Database.Test_connection.Test_connectionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Test_connectionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/test_connection", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Database.Test_connection.Test_connectionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Test_connectionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/test_connection", rawUrl)
        {
        }
        /// <summary>
        /// Test a database connection
        /// </summary>
        /// <returns>A <see cref="KApi.Database.Test_connection.Test_connectionPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Test_connection400Error">When receiving a 400 status code</exception>
        /// <exception cref="KClient.Models.Test_connection422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.Test_connection500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Database.Test_connection.Test_connectionPostResponse?> PostAsTest_connectionPostResponseAsync(KClient.Models.DatabaseTestConnectionSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Database.Test_connection.Test_connectionPostResponse> PostAsTest_connectionPostResponseAsync(KClient.Models.DatabaseTestConnectionSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KClient.Models.Test_connection400Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.Test_connection422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Test_connection500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Database.Test_connection.Test_connectionPostResponse>(requestInfo, KApi.Database.Test_connection.Test_connectionPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Test a database connection
        /// </summary>
        /// <returns>A <see cref="KApi.Database.Test_connection.Test_connectionResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Test_connection400Error">When receiving a 400 status code</exception>
        /// <exception cref="KClient.Models.Test_connection422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.Test_connection500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsTest_connectionPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Database.Test_connection.Test_connectionResponse?> PostAsync(KClient.Models.DatabaseTestConnectionSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Database.Test_connection.Test_connectionResponse> PostAsync(KClient.Models.DatabaseTestConnectionSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KClient.Models.Test_connection400Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.Test_connection422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Test_connection500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Database.Test_connection.Test_connectionResponse>(requestInfo, KApi.Database.Test_connection.Test_connectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Test a database connection
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(KClient.Models.DatabaseTestConnectionSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(KClient.Models.DatabaseTestConnectionSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="KApi.Database.Test_connection.Test_connectionRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KApi.Database.Test_connection.Test_connectionRequestBuilder WithUrl(string rawUrl)
        {
            return new KApi.Database.Test_connection.Test_connectionRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class Test_connectionRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
