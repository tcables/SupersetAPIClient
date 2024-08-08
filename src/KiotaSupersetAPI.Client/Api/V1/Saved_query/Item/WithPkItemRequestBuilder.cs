
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Saved_query.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\saved_query\{pk}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithPkItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Saved_query.Item.WithPkItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithPkItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/saved_query/{pk}{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Saved_query.Item.WithPkItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithPkItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/saved_query/{pk}{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Delete a saved query
    /// </summary>
    /// <returns>A <see cref="KApi.Saved_query.Item.WithPkDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Saved_query.Item.WithPkDeleteResponse> DeleteAsWithPkDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Saved_query.Item.WithPkDeleteResponse>(requestInfo, KApi.Saved_query.Item.WithPkDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a saved query
    /// </summary>
    /// <returns>A <see cref="KApi.Saved_query.Item.WithPkResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsWithPkDeleteResponseAsync instead.")]
    public async Task<KApi.Saved_query.Item.WithPkResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Saved_query.Item.WithPkResponse>(requestInfo, KApi.Saved_query.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="KApi.Saved_query.Item.WithPkGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Saved_query.Item.WithPkGetResponse> GetAsWithPkGetResponseAsync(Action<RequestConfiguration<KApi.Saved_query.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
        return await RequestAdapter.SendAsync<KApi.Saved_query.Item.WithPkGetResponse>(requestInfo, KApi.Saved_query.Item.WithPkGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="KApi.Saved_query.Item.WithPkResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithPkGetResponseAsync instead.")]
    public async Task<KApi.Saved_query.Item.WithPkResponse> GetAsync(Action<RequestConfiguration<KApi.Saved_query.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
        return await RequestAdapter.SendAsync<KApi.Saved_query.Item.WithPkResponse>(requestInfo, KApi.Saved_query.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update a saved query
    /// </summary>
    /// <returns>A <see cref="KApi.Saved_query.Item.WithPkPutResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Saved_query.Item.WithPkPutResponse> PutAsWithPkPutResponseAsync(KClient.Models.SavedQueryRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Saved_query.Item.WithPkPutResponse>(requestInfo, KApi.Saved_query.Item.WithPkPutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update a saved query
    /// </summary>
    /// <returns>A <see cref="KApi.Saved_query.Item.WithPkResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PutAsWithPkPutResponseAsync instead.")]
    public async Task<KApi.Saved_query.Item.WithPkResponse> PutAsync(KClient.Models.SavedQueryRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Saved_query.Item.WithPkResponse>(requestInfo, KApi.Saved_query.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a saved query
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
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Saved_query.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Update a saved query
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPutRequestInformation(KClient.Models.SavedQueryRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Saved_query.Item.WithPkItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Saved_query.Item.WithPkItemRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Saved_query.Item.WithPkItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
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
    public partial class WithPkItemRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Saved_query.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
