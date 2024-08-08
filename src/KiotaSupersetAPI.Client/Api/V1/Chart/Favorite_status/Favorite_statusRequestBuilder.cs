
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

namespace KiotaSupersetAPI.Client.Api.V1.Chart.Favorite_status;

/// <summary>
/// Builds and executes requests for operations under \api\v1\chart\favorite_status
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Favorite_statusRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Chart.Favorite_status.Favorite_statusRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Favorite_statusRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/favorite_status{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Chart.Favorite_status.Favorite_statusRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Favorite_statusRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/favorite_status{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Check favorited charts for current user
    /// </summary>
    /// <returns>A <see cref="KClient.Models.GetFavStarIdsSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.GetFavStarIdsSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.GetFavStarIdsSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.GetFavStarIdsSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.GetFavStarIdsSchema500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KClient.Models.GetFavStarIdsSchema?> GetAsync(Action<RequestConfiguration<KApi.Chart.Favorite_status.Favorite_statusRequestBuilder.Favorite_statusRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KClient.Models.GetFavStarIdsSchema> GetAsync(Action<RequestConfiguration<KApi.Chart.Favorite_status.Favorite_statusRequestBuilder.Favorite_statusRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.GetFavStarIdsSchema400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.GetFavStarIdsSchema401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.GetFavStarIdsSchema404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.GetFavStarIdsSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KClient.Models.GetFavStarIdsSchema>(requestInfo, KClient.Models.GetFavStarIdsSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Check favorited charts for current user
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Chart.Favorite_status.Favorite_statusRequestBuilder.Favorite_statusRequestBuilderGetQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Chart.Favorite_status.Favorite_statusRequestBuilder.Favorite_statusRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="KApi.Chart.Favorite_status.Favorite_statusRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Chart.Favorite_status.Favorite_statusRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Chart.Favorite_status.Favorite_statusRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Check favorited charts for current user
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Favorite_statusRequestBuilderGetQueryParameters
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
    public partial class Favorite_statusRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Chart.Favorite_status.Favorite_statusRequestBuilder.Favorite_statusRequestBuilderGetQueryParameters>
    {
    }
}
