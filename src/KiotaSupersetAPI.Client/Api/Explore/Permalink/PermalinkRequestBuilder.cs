
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Explore.Permalink;

/// <summary>
/// Builds and executes requests for operations under \api\v1\explore\permalink
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class PermalinkRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.explore.permalink.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="Explore.Permalink.Item.WithKeyItemRequestBuilder"/></returns>
    public Explore.Permalink.Item.WithKeyItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("key", position);
            return new Explore.Permalink.Item.WithKeyItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Explore.Permalink.PermalinkRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public PermalinkRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/explore/permalink", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Explore.Permalink.PermalinkRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public PermalinkRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/explore/permalink", rawUrl)
    {
    }
    /// <summary>
    /// Create a new permanent link
    /// </summary>
    /// <returns>A <see cref="Explore.Permalink.PermalinkPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Permalink400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Permalink401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Permalink422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Permalink500Error">When receiving a 500 status code</exception>
    public async Task<Explore.Permalink.PermalinkPostResponse> PostAsPermalinkPostResponseAsync(Models.ExplorePermalinkStateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Permalink400Error.CreateFromDiscriminatorValue },
            { "401", Models.Permalink401Error.CreateFromDiscriminatorValue },
            { "422", Models.Permalink422Error.CreateFromDiscriminatorValue },
            { "500", Models.Permalink500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Explore.Permalink.PermalinkPostResponse>(requestInfo, Explore.Permalink.PermalinkPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new permanent link
    /// </summary>
    /// <returns>A <see cref="Explore.Permalink.PermalinkResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Permalink400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Permalink401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Permalink422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Permalink500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsPermalinkPostResponseAsync instead.")]
    public async Task<Explore.Permalink.PermalinkResponse> PostAsync(Models.ExplorePermalinkStateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Permalink400Error.CreateFromDiscriminatorValue },
            { "401", Models.Permalink401Error.CreateFromDiscriminatorValue },
            { "422", Models.Permalink422Error.CreateFromDiscriminatorValue },
            { "500", Models.Permalink500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Explore.Permalink.PermalinkResponse>(requestInfo, Explore.Permalink.PermalinkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new permanent link
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Models.ExplorePermalinkStateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

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
    /// <returns>A <see cref="Explore.Permalink.PermalinkRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Explore.Permalink.PermalinkRequestBuilder WithUrl(string rawUrl)
    {
        return new Explore.Permalink.PermalinkRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class PermalinkRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
