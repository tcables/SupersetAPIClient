
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Query.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\query\{pk}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithPkItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Query.Item.WithPkItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithPkItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/query/{pk}{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Query.Item.WithPkItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithPkItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/query/{pk}{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="KApi.Query.Item.WithPkGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Query.Item.WithPkGetResponse> GetAsWithPkGetResponseAsync(Action<RequestConfiguration<KApi.Query.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Query.Item.WithPkGetResponse>(requestInfo, KApi.Query.Item.WithPkGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="KApi.Query.Item.WithPkResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithPkGetResponseAsync instead.")]
    public async Task<KApi.Query.Item.WithPkResponse> GetAsync(Action<RequestConfiguration<KApi.Query.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Query.Item.WithPkResponse>(requestInfo, KApi.Query.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Query.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Query.Item.WithPkItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Query.Item.WithPkItemRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Query.Item.WithPkItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Query.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>
    {
    }
}
