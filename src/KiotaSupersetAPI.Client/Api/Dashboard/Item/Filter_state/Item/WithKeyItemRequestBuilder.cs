
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Filter_state.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dashboard\{dashboard_-id}\filter_state\{key}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithKeyItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Filter_state.Item.WithKeyItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithKeyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/filter_state/{key}{?tab_id*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Filter_state.Item.WithKeyItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithKeyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/filter_state/{key}{?tab_id*}", rawUrl)
    {
    }
    /// <summary>
    /// Delete a dashboard&apos;s filter state value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Filter_state.Item.WithKeyDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithKey500Error">When receiving a 500 status code</exception>
    public async Task<Dashboard.Item.Filter_state.Item.WithKeyDeleteResponse> DeleteAsWithKeyDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Filter_state.Item.WithKeyDeleteResponse>(requestInfo, Dashboard.Item.Filter_state.Item.WithKeyDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a dashboard&apos;s filter state value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Filter_state.Item.WithKeyResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithKey500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsWithKeyDeleteResponseAsync instead.")]
    public async Task<Dashboard.Item.Filter_state.Item.WithKeyResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Filter_state.Item.WithKeyResponse>(requestInfo, Dashboard.Item.Filter_state.Item.WithKeyResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a dashboard&apos;s filter state value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Filter_state.Item.WithKeyGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithKey500Error">When receiving a 500 status code</exception>
    public async Task<Dashboard.Item.Filter_state.Item.WithKeyGetResponse> GetWithKeyGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Filter_state.Item.WithKeyGetResponse>(requestInfo, Dashboard.Item.Filter_state.Item.WithKeyGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a dashboard&apos;s filter state value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Filter_state.Item.WithKeyResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithKey500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithKeyGetResponseAsync instead.")]
    public async Task<Dashboard.Item.Filter_state.Item.WithKeyResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Filter_state.Item.WithKeyResponse>(requestInfo, Dashboard.Item.Filter_state.Item.WithKeyResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update a dashboard&apos;s filter state value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Filter_state.Item.WithKeyPutResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithKey500Error">When receiving a 500 status code</exception>
    public async Task<Dashboard.Item.Filter_state.Item.WithKeyPutResponse> PutAsWithKeyPutResponseAsync(Models.TemporaryCachePutSchema body, Action<RequestConfiguration<Dashboard.Item.Filter_state.Item.WithKeyItemRequestBuilder.WithKeyItemRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Filter_state.Item.WithKeyPutResponse>(requestInfo, Dashboard.Item.Filter_state.Item.WithKeyPutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update a dashboard&apos;s filter state value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Filter_state.Item.WithKeyResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithKey500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PutAsWithKeyPutResponseAsync instead.")]
    public async Task<Dashboard.Item.Filter_state.Item.WithKeyResponse> PutAsync(Models.TemporaryCachePutSchema body, Action<RequestConfiguration<Dashboard.Item.Filter_state.Item.WithKeyItemRequestBuilder.WithKeyItemRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Filter_state.Item.WithKeyResponse>(requestInfo, Dashboard.Item.Filter_state.Item.WithKeyResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a dashboard&apos;s filter state value
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
    /// Get a dashboard&apos;s filter state value
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
    /// Update a dashboard&apos;s filter state value
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPutRequestInformation(Models.TemporaryCachePutSchema body, Action<RequestConfiguration<Dashboard.Item.Filter_state.Item.WithKeyItemRequestBuilder.WithKeyItemRequestBuilderPutQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Dashboard.Item.Filter_state.Item.WithKeyItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Filter_state.Item.WithKeyItemRequestBuilder WithUrl(string rawUrl)
    {
        return new Dashboard.Item.Filter_state.Item.WithKeyItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithKeyItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithKeyItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Update a dashboard&apos;s filter state value
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithKeyItemRequestBuilderPutQueryParameters
    {
        [QueryParameter("tab_id")]
        public int? TabId { get; set; }
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithKeyItemRequestBuilderPutRequestConfiguration : RequestConfiguration<Dashboard.Item.Filter_state.Item.WithKeyItemRequestBuilder.WithKeyItemRequestBuilderPutQueryParameters>
    {
    }
}
