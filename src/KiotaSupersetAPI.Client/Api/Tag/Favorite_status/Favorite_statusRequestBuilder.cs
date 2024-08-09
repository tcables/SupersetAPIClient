
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Tag.Favorite_status;

/// <summary>
/// Builds and executes requests for operations under \api\v1\tag\favorite_status
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Favorite_statusRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Tag.Favorite_status.Favorite_statusRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Favorite_statusRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag/favorite_status{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Tag.Favorite_status.Favorite_statusRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Favorite_statusRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag/favorite_status{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Get favorited tags for current user
    /// </summary>
    /// <returns>A <see cref="KClient.Models.GetFavStarIdsSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.GetFavStarIdsSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.GetFavStarIdsSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.GetFavStarIdsSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.GetFavStarIdsSchema500Error">When receiving a 500 status code</exception>
    public async Task<KClient.Models.GetFavStarIdsSchema> GetAsync(Action<RequestConfiguration<Tag.Favorite_status.Favorite_statusRequestBuilder.Favorite_statusRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

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
    /// Get favorited tags for current user
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Tag.Favorite_status.Favorite_statusRequestBuilder.Favorite_statusRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Tag.Favorite_status.Favorite_statusRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Tag.Favorite_status.Favorite_statusRequestBuilder WithUrl(string rawUrl)
    {
        return new Tag.Favorite_status.Favorite_statusRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Get favorited tags for current user
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
    public partial class Favorite_statusRequestBuilderGetRequestConfiguration : RequestConfiguration<Tag.Favorite_status.Favorite_statusRequestBuilder.Favorite_statusRequestBuilderGetQueryParameters>
    {
    }
}
