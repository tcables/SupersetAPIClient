
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Query;

/// <summary>
/// Builds and executes requests for operations under \api\v1\query
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class QueryRequestBuilder : BaseRequestBuilder
{
    /// <summary>The distinct property</summary>
    public KApi.Query.Distinct.DistinctRequestBuilder Distinct
    {
        get => new KApi.Query.Distinct.DistinctRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related property</summary>
    public KApi.Query.Related.RelatedRequestBuilder Related
    {
        get => new KApi.Query.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The stop property</summary>
    public KApi.Query.Stop.StopRequestBuilder Stop
    {
        get => new KApi.Query.Stop.StopRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The updated_since property</summary>
    public KApi.Query.Updated_since.Updated_sinceRequestBuilder Updated_since
    {
        get => new KApi.Query.Updated_since.Updated_sinceRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.query.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Query.Item.WithPkItemRequestBuilder"/></returns>
    public KApi.Query.Item.WithPkItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("pk", position);
            return new KApi.Query.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.query.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Query.Item.WithPkItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public KApi.Query.Item.WithPkItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("pk", position);
            return new KApi.Query.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Query.QueryRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public QueryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/query{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Query.QueryRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public QueryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/query{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Gets a list of queries, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Query.QueryGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Query400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Query401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Query422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Query500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Query.QueryGetResponse> GetAsQueryGetResponseAsync(Action<RequestConfiguration<KApi.Query.QueryRequestBuilder.QueryRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Query400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Query401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Query422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Query500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Query.QueryGetResponse>(requestInfo, KApi.Query.QueryGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of queries, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Query.QueryResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Query400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Query401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Query422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Query500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsQueryGetResponseAsync instead.")]
    public async Task<KApi.Query.QueryResponse> GetAsync(Action<RequestConfiguration<KApi.Query.QueryRequestBuilder.QueryRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Query400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Query401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Query422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Query500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Query.QueryResponse>(requestInfo, KApi.Query.QueryResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of queries, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Query.QueryRequestBuilder.QueryRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Query.QueryRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Query.QueryRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Query.QueryRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Gets a list of queries, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class QueryRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class QueryRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Query.QueryRequestBuilder.QueryRequestBuilderGetQueryParameters>
    {
    }
}
