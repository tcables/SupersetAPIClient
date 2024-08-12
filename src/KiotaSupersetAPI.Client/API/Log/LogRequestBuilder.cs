
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Log;

/// <summary>
/// Builds and executes requests for operations under \api\v1\log
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class LogRequestBuilder : BaseRequestBuilder
{
    /// <summary>The recent_activity property</summary>
    public Log.Recent_activity.Recent_activityRequestBuilder Recent_activity
    {
        get => new Log.Recent_activity.Recent_activityRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.log.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="API.Log.Item.WithPkItemRequestBuilder"/></returns>
    public Log.Item.WithPkItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("pk", position);
            return new Log.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.log.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="API.Log.Item.WithPkItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public Log.Item.WithPkItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("pk", position);
            return new Log.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="API.Log.LogRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public LogRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/log{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="API.Log.LogRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public LogRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/log{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Gets a list of logs, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="API.Log.LogGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Log400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Log401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Log422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Log500Error">When receiving a 500 status code</exception>

    public async Task<Log.LogGetResponse> GetLogGetResponseAsync(Action<RequestConfiguration<Log.LogRequestBuilder.LogRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Log400Error.CreateFromDiscriminatorValue },
            { "401", Models.Log401Error.CreateFromDiscriminatorValue },
            { "422", Models.Log422Error.CreateFromDiscriminatorValue },
            { "500", Models.Log500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Log.LogGetResponse>(requestInfo, Log.LogGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of logs, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="API.Log.LogResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Log400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Log401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Log422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Log500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsLogGetResponseAsync instead.")]

    public async Task<Log.LogResponse> GetAsync(Action<RequestConfiguration<Log.LogRequestBuilder.LogRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Log400Error.CreateFromDiscriminatorValue },
            { "401", Models.Log401Error.CreateFromDiscriminatorValue },
            { "422", Models.Log422Error.CreateFromDiscriminatorValue },
            { "500", Models.Log500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Log.LogResponse>(requestInfo, Log.LogResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <returns>A <see cref="API.Log.LogPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Log400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Log401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Log422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Log500Error">When receiving a 500 status code</exception>

    public async Task<Log.LogPostResponse> PostAsLogPostResponseAsync(Models.LogRestAPI.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Log400Error.CreateFromDiscriminatorValue },
            { "401", Models.Log401Error.CreateFromDiscriminatorValue },
            { "422", Models.Log422Error.CreateFromDiscriminatorValue },
            { "500", Models.Log500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Log.LogPostResponse>(requestInfo, Log.LogPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <returns>A <see cref="API.Log.LogResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Log400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Log401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Log422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Log500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsLogPostResponseAsync instead.")]

    public async Task<Log.LogResponse> PostAsync(Models.LogRestAPI.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Log400Error.CreateFromDiscriminatorValue },
            { "401", Models.Log401Error.CreateFromDiscriminatorValue },
            { "422", Models.Log422Error.CreateFromDiscriminatorValue },
            { "500", Models.Log500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Log.LogResponse>(requestInfo, Log.LogResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of logs, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>

    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Log.LogRequestBuilder.LogRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>

    public RequestInformation ToPostRequestInformation(Models.LogRestAPI.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="API.Log.LogRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Log.LogRequestBuilder WithUrl(string rawUrl)
    {
        return new Log.LogRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Gets a list of logs, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class LogRequestBuilderGetQueryParameters
    {

        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class LogRequestBuilderGetRequestConfiguration : RequestConfiguration<Log.LogRequestBuilder.LogRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class LogRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
