
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KiotaSupersetAPI.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Dataset.Warm_up_cache;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dataset\warm_up_cache
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Warm_up_cacheRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.Warm_up_cache.Warm_up_cacheRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Warm_up_cacheRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/warm_up_cache", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.Warm_up_cache.Warm_up_cacheRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Warm_up_cacheRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/warm_up_cache", rawUrl)
    {
    }
    /// <summary>
    /// Warms up the cache for the table. Note for slices a force refresh occurs. In terms of the `extra_filters` these can be obtained from records in the JSON encoded `logs.json` column associated with the `explore_json` action.
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatasetCacheWarmUpResponseSchema"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.DatasetCacheWarmUpResponseSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.DatasetCacheWarmUpResponseSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.DatasetCacheWarmUpResponseSchema500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KClient.Models.DatasetCacheWarmUpResponseSchema?> PutAsync(KClient.Models.DatasetCacheWarmUpRequestSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KClient.Models.DatasetCacheWarmUpResponseSchema> PutAsync(KClient.Models.DatasetCacheWarmUpRequestSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.DatasetCacheWarmUpResponseSchema400Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.DatasetCacheWarmUpResponseSchema404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.DatasetCacheWarmUpResponseSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KClient.Models.DatasetCacheWarmUpResponseSchema>(requestInfo, KClient.Models.DatasetCacheWarmUpResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Warms up the cache for the table. Note for slices a force refresh occurs. In terms of the `extra_filters` these can be obtained from records in the JSON encoded `logs.json` column associated with the `explore_json` action.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPutRequestInformation(KClient.Models.DatasetCacheWarmUpRequestSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToPutRequestInformation(KClient.Models.DatasetCacheWarmUpRequestSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="KApi.Dataset.Warm_up_cache.Warm_up_cacheRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Dataset.Warm_up_cache.Warm_up_cacheRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Dataset.Warm_up_cache.Warm_up_cacheRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Warm_up_cacheRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
