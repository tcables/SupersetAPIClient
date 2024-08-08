
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KiotaSupersetAPI.Client.Api.V1.Dataset.Item.Column;
using KiotaSupersetAPI.Client.Api.V1.Dataset.Item.Metric;
using KiotaSupersetAPI.Client.Api.V1.Dataset.Item.Refresh;
using KiotaSupersetAPI.Client.Api.V1.Dataset.Item.Related_objects;
using KiotaSupersetAPI.Client.Models;
using KiotaSupersetAPI.Client.Models.DatasetRestApi;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Dataset.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dataset\{pk}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithPkItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>The column property</summary>
    public KApi.Dataset.Item.Column.ColumnRequestBuilder Column
    {
        get => new KApi.Dataset.Item.Column.ColumnRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The metric property</summary>
    public KApi.Dataset.Item.Metric.MetricRequestBuilder Metric
    {
        get => new KApi.Dataset.Item.Metric.MetricRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The refresh property</summary>
    public KApi.Dataset.Item.Refresh.RefreshRequestBuilder Refresh
    {
        get => new KApi.Dataset.Item.Refresh.RefreshRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related_objects property</summary>
    public KApi.Dataset.Item.Related_objects.Related_objectsRequestBuilder Related_objects
    {
        get => new KApi.Dataset.Item.Related_objects.Related_objectsRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.Item.WithPkItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithPkItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/{pk}{?override_columns*,q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.Item.WithPkItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithPkItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/{pk}{?override_columns*,q*}", rawUrl)
    {
    }
    /// <summary>
    /// Delete a dataset
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Item.WithPkDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Dataset.Item.WithPkDeleteResponse?> DeleteAsWithPkDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Dataset.Item.WithPkDeleteResponse> DeleteAsWithPkDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.Item.WithPkDeleteResponse>(requestInfo, KApi.Dataset.Item.WithPkDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a dataset
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Item.WithPkResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsWithPkDeleteResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Dataset.Item.WithPkResponse?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Dataset.Item.WithPkResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.Item.WithPkResponse>(requestInfo, KApi.Dataset.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Item.WithPkGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Dataset.Item.WithPkGetResponse?> GetAsWithPkGetResponseAsync(Action<RequestConfiguration<KApi.Dataset.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Dataset.Item.WithPkGetResponse> GetAsWithPkGetResponseAsync(Action<RequestConfiguration<KApi.Dataset.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.Item.WithPkGetResponse>(requestInfo, KApi.Dataset.Item.WithPkGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Item.WithPkResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithPkGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Dataset.Item.WithPkResponse?> GetAsync(Action<RequestConfiguration<KApi.Dataset.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Dataset.Item.WithPkResponse> GetAsync(Action<RequestConfiguration<KApi.Dataset.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.Item.WithPkResponse>(requestInfo, KApi.Dataset.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update a dataset
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Item.WithPkPutResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Dataset.Item.WithPkPutResponse?> PutAsWithPkPutResponseAsync(KClient.Models.DatasetRestApi.Put body, Action<RequestConfiguration<KApi.Dataset.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderPutQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Dataset.Item.WithPkPutResponse> PutAsWithPkPutResponseAsync(KClient.Models.DatasetRestApi.Put body, Action<RequestConfiguration<KApi.Dataset.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.Item.WithPkPutResponse>(requestInfo, KApi.Dataset.Item.WithPkPutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update a dataset
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Item.WithPkResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PutAsWithPkPutResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Dataset.Item.WithPkResponse?> PutAsync(KClient.Models.DatasetRestApi.Put body, Action<RequestConfiguration<KApi.Dataset.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderPutQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Dataset.Item.WithPkResponse> PutAsync(KClient.Models.DatasetRestApi.Put body, Action<RequestConfiguration<KApi.Dataset.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.Item.WithPkResponse>(requestInfo, KApi.Dataset.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a dataset
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
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Dataset.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Dataset.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {
#endif
        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Update a dataset
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPutRequestInformation(KClient.Models.DatasetRestApi.Put body, Action<RequestConfiguration<KApi.Dataset.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderPutQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToPutRequestInformation(KClient.Models.DatasetRestApi.Put body, Action<RequestConfiguration<KApi.Dataset.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderPutQueryParameters>> requestConfiguration = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Item.WithPkItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Dataset.Item.WithPkItemRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Dataset.Item.WithPkItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderGetQueryParameters
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
    public partial class WithPkItemRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Dataset.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Update a dataset
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderPutQueryParameters
    {
        [QueryParameter("override_columns")]
        public bool? OverrideColumns { get; set; }
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderPutRequestConfiguration : RequestConfiguration<KApi.Dataset.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderPutQueryParameters>
    {
    }
}
