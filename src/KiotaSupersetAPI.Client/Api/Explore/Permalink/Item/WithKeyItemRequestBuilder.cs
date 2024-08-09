
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Explore.Permalink.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\explore\permalink\{key}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithKeyItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Explore.Permalink.Item.WithKeyItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithKeyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/explore/permalink/{key}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Explore.Permalink.Item.WithKeyItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithKeyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/explore/permalink/{key}", rawUrl)
    {
    }
    /// <summary>
    /// Get chart&apos;s permanent link state
    /// </summary>
    /// <returns>A <see cref="KApi.Explore.Permalink.Item.WithKeyGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithKey500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Explore.Permalink.Item.WithKeyGetResponse> GetWithKeyGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Explore.Permalink.Item.WithKeyGetResponse>(requestInfo, KApi.Explore.Permalink.Item.WithKeyGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get chart&apos;s permanent link state
    /// </summary>
    /// <returns>A <see cref="KApi.Explore.Permalink.Item.WithKeyResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithKey500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithKeyGetResponseAsync instead.")]
    public async Task<KApi.Explore.Permalink.Item.WithKeyResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Explore.Permalink.Item.WithKeyResponse>(requestInfo, KApi.Explore.Permalink.Item.WithKeyResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get chart&apos;s permanent link state
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Explore.Permalink.Item.WithKeyItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Explore.Permalink.Item.WithKeyItemRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Explore.Permalink.Item.WithKeyItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithKeyItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
