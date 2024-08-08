
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Chart.Item.Favorites;

/// <summary>
/// Builds and executes requests for operations under \api\v1\chart\{pk}\favorites
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class FavoritesRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Chart.Item.Favorites.FavoritesRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public FavoritesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/{pk}/favorites", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Chart.Item.Favorites.FavoritesRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public FavoritesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/{pk}/favorites", rawUrl)
    {
    }
    /// <summary>
    /// Remove the chart from the user favorite list
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.Item.Favorites.FavoritesDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Favorites401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Favorites404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Favorites500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Chart.Item.Favorites.FavoritesDeleteResponse> DeleteAsFavoritesDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Favorites401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Favorites404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Favorites500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Chart.Item.Favorites.FavoritesDeleteResponse>(requestInfo, KApi.Chart.Item.Favorites.FavoritesDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Remove the chart from the user favorite list
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.Item.Favorites.FavoritesResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Favorites401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Favorites404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Favorites500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsFavoritesDeleteResponseAsync instead.")]
    public async Task<KApi.Chart.Item.Favorites.FavoritesResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Favorites401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Favorites404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Favorites500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Chart.Item.Favorites.FavoritesResponse>(requestInfo, KApi.Chart.Item.Favorites.FavoritesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Mark the chart as favorite for the current user
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.Item.Favorites.FavoritesPostResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Favorites401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Favorites404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Favorites500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Chart.Item.Favorites.FavoritesPostResponse> PostAsFavoritesPostResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToPostRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Favorites401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Favorites404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Favorites500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Chart.Item.Favorites.FavoritesPostResponse>(requestInfo, KApi.Chart.Item.Favorites.FavoritesPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Mark the chart as favorite for the current user
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.Item.Favorites.FavoritesResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Favorites401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Favorites404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Favorites500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsFavoritesPostResponseAsync instead.")]
    public async Task<KApi.Chart.Item.Favorites.FavoritesResponse> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToPostRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Favorites401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Favorites404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Favorites500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Chart.Item.Favorites.FavoritesResponse>(requestInfo, KApi.Chart.Item.Favorites.FavoritesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Remove the chart from the user favorite list
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Mark the chart as favorite for the current user
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.Item.Favorites.FavoritesRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Chart.Item.Favorites.FavoritesRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Chart.Item.Favorites.FavoritesRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class FavoritesRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class FavoritesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
