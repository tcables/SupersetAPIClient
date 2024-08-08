
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

namespace KiotaSupersetAPI.Client.Api.V1.Dashboard.Import
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\dashboard\import
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ImportRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KApi.Dashboard.Import.ImportRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ImportRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/import", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Dashboard.Import.ImportRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ImportRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/import", rawUrl)
        {
        }
        /// <summary>
        /// Import dashboard(s) with associated charts/datasets/databases
        /// </summary>
        /// <returns>A <see cref="KApi.Dashboard.Import.ImportPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Import400Error">When receiving a 400 status code</exception>
        /// <exception cref="KClient.Models.Import401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.Import422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.Import500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Dashboard.Import.ImportPostResponse?> PostAsImportPostResponseAsync(KApi.Dashboard.Import.ImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Dashboard.Import.ImportPostResponse> PostAsImportPostResponseAsync(KApi.Dashboard.Import.ImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KClient.Models.Import400Error.CreateFromDiscriminatorValue },
                { "401", KClient.Models.Import401Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.Import422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Import500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Dashboard.Import.ImportPostResponse>(requestInfo, KApi.Dashboard.Import.ImportPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Import dashboard(s) with associated charts/datasets/databases
        /// </summary>
        /// <returns>A <see cref="KApi.Dashboard.Import.ImportResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Import400Error">When receiving a 400 status code</exception>
        /// <exception cref="KClient.Models.Import401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.Import422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.Import500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsImportPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Dashboard.Import.ImportResponse?> PostAsync(KApi.Dashboard.Import.ImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Dashboard.Import.ImportResponse> PostAsync(KApi.Dashboard.Import.ImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KClient.Models.Import400Error.CreateFromDiscriminatorValue },
                { "401", KClient.Models.Import401Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.Import422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Import500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Dashboard.Import.ImportResponse>(requestInfo, KApi.Dashboard.Import.ImportResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Import dashboard(s) with associated charts/datasets/databases
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(KApi.Dashboard.Import.ImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(KApi.Dashboard.Import.ImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "multipart/form-data", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="KApi.Dashboard.Import.ImportRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KApi.Dashboard.Import.ImportRequestBuilder WithUrl(string rawUrl)
        {
            return new KApi.Dashboard.Import.ImportRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class ImportRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
