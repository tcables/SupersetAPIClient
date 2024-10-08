
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Chart.Favorite_status;

/// <summary>
/// Builds and executes requests for operations under \api\v1\chart\favorite_status
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Favorite_statusRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Chart.Favorite_status.Favorite_statusRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Favorite_statusRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/favorite_status{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Chart.Favorite_status.Favorite_statusRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Favorite_statusRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/favorite_status{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Check favorited charts for current user
    /// </summary>
    /// <returns>A <see cref="Models.GetFavStarIdsSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.GetFavStarIdsSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.GetFavStarIdsSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.GetFavStarIdsSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.GetFavStarIdsSchema500Error">When receiving a 500 status code</exception>
    public async Task<Models.GetFavStarIdsSchema> GetAsync(Action<RequestConfiguration<Chart.Favorite_status.Favorite_statusRequestBuilder.Favorite_statusRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.GetFavStarIdsSchema400Error.CreateFromDiscriminatorValue },
            { "401", Models.GetFavStarIdsSchema401Error.CreateFromDiscriminatorValue },
            { "404", Models.GetFavStarIdsSchema404Error.CreateFromDiscriminatorValue },
            { "500", Models.GetFavStarIdsSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Models.GetFavStarIdsSchema>(requestInfo, Models.GetFavStarIdsSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Check favorited charts for current user
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Chart.Favorite_status.Favorite_statusRequestBuilder.Favorite_statusRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Chart.Favorite_status.Favorite_statusRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Favorite_status.Favorite_statusRequestBuilder WithUrl(string rawUrl)
    {
        return new Favorite_status.Favorite_statusRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Check favorited charts for current user
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Favorite_statusRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Favorite_statusRequestBuilderGetRequestConfiguration : RequestConfiguration<Chart.Favorite_status.Favorite_statusRequestBuilder.Favorite_statusRequestBuilderGetQueryParameters>
    {
    }
}
