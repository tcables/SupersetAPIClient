
using KiotaSupersetAPI.Client.Api.V1.Database.Available;
using KiotaSupersetAPI.Client.Api.V1.Database.Export;
using KiotaSupersetAPI.Client.Api.V1.Database.Import;
using KiotaSupersetAPI.Client.Api.V1.Database.Item;
using KiotaSupersetAPI.Client.Api.V1.Database.Related;
using KiotaSupersetAPI.Client.Api.V1.Database.Test_connection;
using KiotaSupersetAPI.Client.Api.V1.Database.Validate_parameters;
using KiotaSupersetAPI.Client.Api.V1.Database._info;
using KiotaSupersetAPI.Client.Models.DatabaseRestApi;
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

namespace KiotaSupersetAPI.Client.Api.V1.Database
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\database
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DatabaseRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The _info property</summary>
        public KApi.Database._info._infoRequestBuilder _info
        {
            get => new KApi.Database._info._infoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The available property</summary>
        public KApi.Database.Available.AvailableRequestBuilder Available
        {
            get => new KApi.Database.Available.AvailableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The export property</summary>
        public KApi.Database.Export.ExportRequestBuilder Export
        {
            get => new KApi.Database.Export.ExportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The import property</summary>
        public KApi.Database.Import.ImportRequestBuilder Import
        {
            get => new KApi.Database.Import.ImportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The related property</summary>
        public KApi.Database.Related.RelatedRequestBuilder Related
        {
            get => new KApi.Database.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The test_connection property</summary>
        public KApi.Database.Test_connection.Test_connectionRequestBuilder Test_connection
        {
            get => new KApi.Database.Test_connection.Test_connectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The validate_parameters property</summary>
        public KApi.Database.Validate_parameters.Validate_parametersRequestBuilder Validate_parameters
        {
            get => new KApi.Database.Validate_parameters.Validate_parametersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.database.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="KApi.Database.Item.WithPkItemRequestBuilder"/></returns>
        public KApi.Database.Item.WithPkItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("pk", position);
                return new KApi.Database.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.database.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="KApi.Database.Item.WithPkItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public KApi.Database.Item.WithPkItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("pk", position);
                return new KApi.Database.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Database.DatabaseRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DatabaseRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database{?q*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Database.DatabaseRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DatabaseRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database{?q*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets a list of databases, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
        /// </summary>
        /// <returns>A <see cref="KApi.Database.DatabaseGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Database400Error">When receiving a 400 status code</exception>
        /// <exception cref="KClient.Models.Database401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.Database422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.Database500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Database.DatabaseGetResponse?> GetAsDatabaseGetResponseAsync(Action<RequestConfiguration<KApi.Database.DatabaseRequestBuilder.DatabaseRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Database.DatabaseGetResponse> GetAsDatabaseGetResponseAsync(Action<RequestConfiguration<KApi.Database.DatabaseRequestBuilder.DatabaseRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KClient.Models.Database400Error.CreateFromDiscriminatorValue },
                { "401", KClient.Models.Database401Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.Database422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Database500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Database.DatabaseGetResponse>(requestInfo, KApi.Database.DatabaseGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a list of databases, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
        /// </summary>
        /// <returns>A <see cref="KApi.Database.DatabaseResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Database400Error">When receiving a 400 status code</exception>
        /// <exception cref="KClient.Models.Database401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.Database422Error">When receiving a 422 status code</exception>
        /// <exception cref="KClient.Models.Database500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsDatabaseGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Database.DatabaseResponse?> GetAsync(Action<RequestConfiguration<KApi.Database.DatabaseRequestBuilder.DatabaseRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Database.DatabaseResponse> GetAsync(Action<RequestConfiguration<KApi.Database.DatabaseRequestBuilder.DatabaseRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KClient.Models.Database400Error.CreateFromDiscriminatorValue },
                { "401", KClient.Models.Database401Error.CreateFromDiscriminatorValue },
                { "422", KClient.Models.Database422Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Database500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Database.DatabaseResponse>(requestInfo, KApi.Database.DatabaseResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new database
        /// </summary>
        /// <returns>A <see cref="KApi.Database.DatabasePostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Database400Error">When receiving a 400 status code</exception>
        /// <exception cref="KClient.Models.Database401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.Database404Error">When receiving a 404 status code</exception>
        /// <exception cref="KClient.Models.Database500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Database.DatabasePostResponse?> PostAsDatabasePostResponseAsync(KClient.Models.DatabaseRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Database.DatabasePostResponse> PostAsDatabasePostResponseAsync(KClient.Models.DatabaseRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KClient.Models.Database400Error.CreateFromDiscriminatorValue },
                { "401", KClient.Models.Database401Error.CreateFromDiscriminatorValue },
                { "404", KClient.Models.Database404Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Database500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Database.DatabasePostResponse>(requestInfo, KApi.Database.DatabasePostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new database
        /// </summary>
        /// <returns>A <see cref="KApi.Database.DatabaseResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KClient.Models.Database400Error">When receiving a 400 status code</exception>
        /// <exception cref="KClient.Models.Database401Error">When receiving a 401 status code</exception>
        /// <exception cref="KClient.Models.Database404Error">When receiving a 404 status code</exception>
        /// <exception cref="KClient.Models.Database500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsDatabasePostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KApi.Database.DatabaseResponse?> PostAsync(KClient.Models.DatabaseRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KApi.Database.DatabaseResponse> PostAsync(KClient.Models.DatabaseRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KClient.Models.Database400Error.CreateFromDiscriminatorValue },
                { "401", KClient.Models.Database401Error.CreateFromDiscriminatorValue },
                { "404", KClient.Models.Database404Error.CreateFromDiscriminatorValue },
                { "500", KClient.Models.Database500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KApi.Database.DatabaseResponse>(requestInfo, KApi.Database.DatabaseResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a list of databases, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Database.DatabaseRequestBuilder.DatabaseRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Database.DatabaseRequestBuilder.DatabaseRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new database
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(KClient.Models.DatabaseRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(KClient.Models.DatabaseRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="KApi.Database.DatabaseRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KApi.Database.DatabaseRequestBuilder WithUrl(string rawUrl)
        {
            return new KApi.Database.DatabaseRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets a list of databases, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
        /// </summary>
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class DatabaseRequestBuilderGetQueryParameters 
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
        public partial class DatabaseRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Database.DatabaseRequestBuilder.DatabaseRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [GeneratedCode("Kiota", "1.16.0")]
        public partial class DatabaseRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
