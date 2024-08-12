
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Filter_state;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dashboard\{dashboard_-id}\filter_state
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Filter_stateRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.dashboard.item.filter_state.item collection</summary>
    /// <param name="position">The value key.</param>
    /// <returns>A <see cref="Dashboard.Item.Filter_state.Item.WithKeyItemRequestBuilder"/></returns>
    public Item.WithKeyItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("key", position);
            return new Item.WithKeyItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Filter_state.Filter_stateRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Filter_stateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/filter_state{?tab_id*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Filter_state.Filter_stateRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Filter_stateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/filter_state{?tab_id*}", rawUrl)
    {
    }
    /// <summary>
    /// Create a dashboard&apos;s filter state
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Filter_state.Filter_statePostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Filter_state400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Filter_state401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Filter_state422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Filter_state500Error">When receiving a 500 status code</exception>
    public async Task<Dashboard.Item.Filter_state.Filter_statePostResponse> PostAsFilter_statePostResponseAsync(Models.TemporaryCachePostSchema body, Action<RequestConfiguration<Dashboard.Item.Filter_state.Filter_stateRequestBuilder.Filter_stateRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Filter_state400Error.CreateFromDiscriminatorValue },
            { "401", Models.Filter_state401Error.CreateFromDiscriminatorValue },
            { "422", Models.Filter_state422Error.CreateFromDiscriminatorValue },
            { "500", Models.Filter_state500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Filter_state.Filter_statePostResponse>(requestInfo, Dashboard.Item.Filter_state.Filter_statePostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a dashboard&apos;s filter state
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Filter_state.Filter_stateResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Filter_state400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Filter_state401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Filter_state422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Filter_state500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsFilter_statePostResponseAsync instead.")]
    public async Task<Dashboard.Item.Filter_state.Filter_stateResponse> PostAsync(Models.TemporaryCachePostSchema body, Action<RequestConfiguration<Dashboard.Item.Filter_state.Filter_stateRequestBuilder.Filter_stateRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Filter_state400Error.CreateFromDiscriminatorValue },
            { "401", Models.Filter_state401Error.CreateFromDiscriminatorValue },
            { "422", Models.Filter_state422Error.CreateFromDiscriminatorValue },
            { "500", Models.Filter_state500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Filter_state.Filter_stateResponse>(requestInfo, Dashboard.Item.Filter_state.Filter_stateResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a dashboard&apos;s filter state
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Models.TemporaryCachePostSchema body, Action<RequestConfiguration<Dashboard.Item.Filter_state.Filter_stateRequestBuilder.Filter_stateRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Dashboard.Item.Filter_state.Filter_stateRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Filter_stateRequestBuilder WithUrl(string rawUrl)
    {
        return new Filter_stateRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Create a dashboard&apos;s filter state
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Filter_stateRequestBuilderPostQueryParameters
    {
        [QueryParameter("tab_id")]
        public int? TabId { get; set; }
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Filter_stateRequestBuilderPostRequestConfiguration : RequestConfiguration<Dashboard.Item.Filter_state.Filter_stateRequestBuilder.Filter_stateRequestBuilderPostQueryParameters>
    {
    }
}
