
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Rowlevelsecurity;

/// <summary>
/// Builds and executes requests for operations under \api\v1\rowlevelsecurity
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class RowlevelsecurityRequestBuilder : BaseRequestBuilder
{
    /// <summary>The _info property</summary>
    public KApi.Rowlevelsecurity._info._infoRequestBuilder _info
    {
        get => new KApi.Rowlevelsecurity._info._infoRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related property</summary>
    public KApi.Rowlevelsecurity.Related.RelatedRequestBuilder Related
    {
        get => new KApi.Rowlevelsecurity.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.rowlevelsecurity.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Rowlevelsecurity.Item.WithPkItemRequestBuilder"/></returns>
    public KApi.Rowlevelsecurity.Item.WithPkItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("pk", position);
            return new KApi.Rowlevelsecurity.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.rowlevelsecurity.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Rowlevelsecurity.Item.WithPkItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public KApi.Rowlevelsecurity.Item.WithPkItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("pk", position);
            return new KApi.Rowlevelsecurity.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public RowlevelsecurityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/rowlevelsecurity{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public RowlevelsecurityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/rowlevelsecurity{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Bulk delete RLS rules
    /// </summary>
    /// <returns>A <see cref="KApi.Rowlevelsecurity.RowlevelsecurityDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Rowlevelsecurity401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Rowlevelsecurity.RowlevelsecurityDeleteResponse> DeleteAsRowlevelsecurityDeleteResponseAsync(Action<RequestConfiguration<KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder.RowlevelsecurityRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Rowlevelsecurity401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Rowlevelsecurity403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Rowlevelsecurity404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Rowlevelsecurity422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Rowlevelsecurity500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Rowlevelsecurity.RowlevelsecurityDeleteResponse>(requestInfo, KApi.Rowlevelsecurity.RowlevelsecurityDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete RLS rules
    /// </summary>
    /// <returns>A <see cref="KApi.Rowlevelsecurity.RowlevelsecurityResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Rowlevelsecurity401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsRowlevelsecurityDeleteResponseAsync instead.")]
    public async Task<KApi.Rowlevelsecurity.RowlevelsecurityResponse> DeleteAsync(Action<RequestConfiguration<KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder.RowlevelsecurityRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Rowlevelsecurity401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Rowlevelsecurity403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Rowlevelsecurity404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Rowlevelsecurity422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Rowlevelsecurity500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Rowlevelsecurity.RowlevelsecurityResponse>(requestInfo, KApi.Rowlevelsecurity.RowlevelsecurityResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of RLS, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Rowlevelsecurity.RowlevelsecurityGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Rowlevelsecurity400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Rowlevelsecurity.RowlevelsecurityGetResponse> GetAsRowlevelsecurityGetResponseAsync(Action<RequestConfiguration<KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder.RowlevelsecurityRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Rowlevelsecurity400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Rowlevelsecurity401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Rowlevelsecurity422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Rowlevelsecurity500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Rowlevelsecurity.RowlevelsecurityGetResponse>(requestInfo, KApi.Rowlevelsecurity.RowlevelsecurityGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of RLS, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Rowlevelsecurity.RowlevelsecurityResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Rowlevelsecurity400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsRowlevelsecurityGetResponseAsync instead.")]
    public async Task<KApi.Rowlevelsecurity.RowlevelsecurityResponse> GetAsync(Action<RequestConfiguration<KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder.RowlevelsecurityRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Rowlevelsecurity400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Rowlevelsecurity401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Rowlevelsecurity422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Rowlevelsecurity500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Rowlevelsecurity.RowlevelsecurityResponse>(requestInfo, KApi.Rowlevelsecurity.RowlevelsecurityResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new RLS rule
    /// </summary>
    /// <returns>A <see cref="KApi.Rowlevelsecurity.RowlevelsecurityPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Rowlevelsecurity400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Rowlevelsecurity.RowlevelsecurityPostResponse> PostAsRowlevelsecurityPostResponseAsync(KClient.Models.RLSRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Rowlevelsecurity400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Rowlevelsecurity401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Rowlevelsecurity404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Rowlevelsecurity422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Rowlevelsecurity500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Rowlevelsecurity.RowlevelsecurityPostResponse>(requestInfo, KApi.Rowlevelsecurity.RowlevelsecurityPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new RLS rule
    /// </summary>
    /// <returns>A <see cref="KApi.Rowlevelsecurity.RowlevelsecurityResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Rowlevelsecurity400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Rowlevelsecurity500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsRowlevelsecurityPostResponseAsync instead.")]
    public async Task<KApi.Rowlevelsecurity.RowlevelsecurityResponse> PostAsync(KClient.Models.RLSRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Rowlevelsecurity400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Rowlevelsecurity401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Rowlevelsecurity404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Rowlevelsecurity422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Rowlevelsecurity500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Rowlevelsecurity.RowlevelsecurityResponse>(requestInfo, KApi.Rowlevelsecurity.RowlevelsecurityResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete RLS rules
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder.RowlevelsecurityRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Gets a list of RLS, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder.RowlevelsecurityRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Create a new RLS rule
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(KClient.Models.RLSRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Bulk delete RLS rules
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class RowlevelsecurityRequestBuilderDeleteQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class RowlevelsecurityRequestBuilderDeleteRequestConfiguration : RequestConfiguration<KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder.RowlevelsecurityRequestBuilderDeleteQueryParameters>
    {
    }
    /// <summary>
    /// Gets a list of RLS, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class RowlevelsecurityRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class RowlevelsecurityRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder.RowlevelsecurityRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class RowlevelsecurityRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
