
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

namespace KiotaSupersetAPI.Client.Api.V1.Database.Validate_parameters
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\database\validate_parameters
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Validate_parametersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KApi.Database.Validate_parameters.Validate_parametersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Validate_parametersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/validate_parameters", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Database.Validate_parameters.Validate_parametersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Validate_parametersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/validate_parameters", rawUrl)
        {
        }
        /// <summary>
        /// Validate database connection parameters
        /// </summary>
        /// <returns>A <see cref="KApi.Database.Validate_parameters.Validate_parametersPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Validate_parameters400Error">When receiving a 400 status code</exception>
        /// <exception cref="KClient.Models.Validate_parameters422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.Validate_parameters500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Database.Validate_parameters.Validate_parametersPostResponse?> PostAsValidate_parametersPostResponseAsync(KClient.Models.DatabaseValidateParametersSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Database.Validate_parameters.Validate_parametersPostResponse> PostAsValidate_parametersPostResponseAsync(KClient.Models.DatabaseValidateParametersSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KClient.Models.Validate_parameters400Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.Validate_parameters422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Validate_parameters500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Database.Validate_parameters.Validate_parametersPostResponse>(requestInfo, KApi.Database.Validate_parameters.Validate_parametersPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Validate database connection parameters
        /// </summary>
        /// <returns>A <see cref="KApi.Database.Validate_parameters.Validate_parametersResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Validate_parameters400Error">When receiving a 400 status code</exception>
        /// <exception cref="KClient.Models.Validate_parameters422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.Validate_parameters500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsValidate_parametersPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Database.Validate_parameters.Validate_parametersResponse?> PostAsync(KClient.Models.DatabaseValidateParametersSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Database.Validate_parameters.Validate_parametersResponse> PostAsync(KClient.Models.DatabaseValidateParametersSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KClient.Models.Validate_parameters400Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.Validate_parameters422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Validate_parameters500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Database.Validate_parameters.Validate_parametersResponse>(requestInfo, KApi.Database.Validate_parameters.Validate_parametersResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Validate database connection parameters
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(KClient.Models.DatabaseValidateParametersSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(KClient.Models.DatabaseValidateParametersSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="KApi.Database.Validate_parameters.Validate_parametersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KApi.Database.Validate_parameters.Validate_parametersRequestBuilder WithUrl(string rawUrl)
        {
            return new KApi.Database.Validate_parameters.Validate_parametersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class Validate_parametersRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
