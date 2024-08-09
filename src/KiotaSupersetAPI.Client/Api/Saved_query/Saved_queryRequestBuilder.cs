
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Saved_query;

/// <summary>
/// Builds and executes requests for operations under \api\v1\saved_query
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Saved_queryRequestBuilder : BaseRequestBuilder
{
    /// <summary>The _info property</summary>
    public KApi.Saved_query._info._infoRequestBuilder _info
    {
        get => new KApi.Saved_query._info._infoRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The distinct property</summary>
    public KApi.Saved_query.Distinct.DistinctRequestBuilder Distinct
    {
        get => new KApi.Saved_query.Distinct.DistinctRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The export property</summary>
    public KApi.Saved_query.Export.ExportRequestBuilder Export
    {
        get => new KApi.Saved_query.Export.ExportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The import property</summary>
    public KApi.Saved_query.Import.ImportRequestBuilder Import
    {
        get => new KApi.Saved_query.Import.ImportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related property</summary>
    public KApi.Saved_query.Related.RelatedRequestBuilder Related
    {
        get => new KApi.Saved_query.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.saved_query.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Saved_query.Item.WithPkItemRequestBuilder"/></returns>
    public KApi.Saved_query.Item.WithPkItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("pk", position);
            return new KApi.Saved_query.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.saved_query.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Saved_query.Item.WithPkItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public KApi.Saved_query.Item.WithPkItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("pk", position);
            return new KApi.Saved_query.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Saved_query.Saved_queryRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Saved_queryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/saved_query{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Saved_query.Saved_queryRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Saved_queryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/saved_query{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Bulk delete saved queries
    /// </summary>
    /// <returns>A <see cref="KApi.Saved_query.Saved_queryDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Saved_query401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Saved_query404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Saved_query422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Saved_query500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Saved_query.Saved_queryDeleteResponse> DeleteAsSaved_queryDeleteResponseAsync(Action<RequestConfiguration<KApi.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Saved_query401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Saved_query404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Saved_query422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Saved_query500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Saved_query.Saved_queryDeleteResponse>(requestInfo, KApi.Saved_query.Saved_queryDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete saved queries
    /// </summary>
    /// <returns>A <see cref="KApi.Saved_query.Saved_queryResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Saved_query401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Saved_query404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Saved_query422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Saved_query500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsSaved_queryDeleteResponseAsync instead.")]
    public async Task<KApi.Saved_query.Saved_queryResponse> DeleteAsync(Action<RequestConfiguration<KApi.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Saved_query401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Saved_query404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Saved_query422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Saved_query500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Saved_query.Saved_queryResponse>(requestInfo, KApi.Saved_query.Saved_queryResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of saved queries, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Saved_query.Saved_queryGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Saved_query400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Saved_query401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Saved_query422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Saved_query500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Saved_query.Saved_queryGetResponse> GetAsSaved_queryGetResponseAsync(Action<RequestConfiguration<KApi.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Saved_query400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Saved_query401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Saved_query422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Saved_query500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Saved_query.Saved_queryGetResponse>(requestInfo, KApi.Saved_query.Saved_queryGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of saved queries, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Saved_query.Saved_queryResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Saved_query400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Saved_query401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Saved_query422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Saved_query500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsSaved_queryGetResponseAsync instead.")]
    public async Task<KApi.Saved_query.Saved_queryResponse> GetAsync(Action<RequestConfiguration<KApi.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Saved_query400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Saved_query401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Saved_query422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Saved_query500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Saved_query.Saved_queryResponse>(requestInfo, KApi.Saved_query.Saved_queryResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a saved query
    /// </summary>
    /// <returns>A <see cref="KApi.Saved_query.Saved_queryPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Saved_query400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Saved_query401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Saved_query422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Saved_query500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Saved_query.Saved_queryPostResponse> PostAsSaved_queryPostResponseAsync(KClient.Models.SavedQueryRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Saved_query400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Saved_query401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Saved_query422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Saved_query500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Saved_query.Saved_queryPostResponse>(requestInfo, KApi.Saved_query.Saved_queryPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a saved query
    /// </summary>
    /// <returns>A <see cref="KApi.Saved_query.Saved_queryResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Saved_query400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Saved_query401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Saved_query422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Saved_query500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsSaved_queryPostResponseAsync instead.")]
    public async Task<KApi.Saved_query.Saved_queryResponse> PostAsync(KClient.Models.SavedQueryRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Saved_query400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Saved_query401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Saved_query422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Saved_query500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Saved_query.Saved_queryResponse>(requestInfo, KApi.Saved_query.Saved_queryResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete saved queries
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<KApi.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Gets a list of saved queries, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Create a saved query
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(KClient.Models.SavedQueryRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="KApi.Saved_query.Saved_queryRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Saved_query.Saved_queryRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Saved_query.Saved_queryRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Bulk delete saved queries
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Saved_queryRequestBuilderDeleteQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Saved_queryRequestBuilderDeleteRequestConfiguration : RequestConfiguration<KApi.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderDeleteQueryParameters>
    {
    }
    /// <summary>
    /// Gets a list of saved queries, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Saved_queryRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Saved_queryRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Saved_query.Saved_queryRequestBuilder.Saved_queryRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Saved_queryRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
