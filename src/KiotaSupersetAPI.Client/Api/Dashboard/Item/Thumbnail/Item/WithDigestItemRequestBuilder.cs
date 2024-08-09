
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Thumbnail.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dashboard\{dashboard_-id}\thumbnail\{digest}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithDigestItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithDigestItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/thumbnail/{digest}{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithDigestItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/thumbnail/{digest}{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Computes async or get already computed dashboard thumbnail from cache.
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Thumbnail.Item.WithDigestGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithDigest401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithDigest404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithDigest422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithDigest500Error">When receiving a 500 status code</exception>
    public async Task<Dashboard.Item.Thumbnail.Item.WithDigestGetResponse> GetWithDigestGetResponseAsync(Action<RequestConfiguration<Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder.WithDigestItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.WithDigest401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithDigest404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithDigest422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithDigest500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Thumbnail.Item.WithDigestGetResponse>(requestInfo, Dashboard.Item.Thumbnail.Item.WithDigestGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Computes async or get already computed dashboard thumbnail from cache.
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Thumbnail.Item.WithDigestResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithDigest401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithDigest404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithDigest422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithDigest500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithDigestGetResponseAsync instead.")]
    public async Task<Dashboard.Item.Thumbnail.Item.WithDigestResponse> GetAsync(Action<RequestConfiguration<Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder.WithDigestItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.WithDigest401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithDigest404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithDigest422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithDigest500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Thumbnail.Item.WithDigestResponse>(requestInfo, Dashboard.Item.Thumbnail.Item.WithDigestResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Computes async or get already computed dashboard thumbnail from cache.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder.WithDigestItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder WithUrl(string rawUrl)
    {
        return new Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Computes async or get already computed dashboard thumbnail from cache.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithDigestItemRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithDigestItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder.WithDigestItemRequestBuilderGetQueryParameters>
    {
    }
}
