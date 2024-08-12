
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Query.Stop;

/// <summary>
/// Builds and executes requests for operations under \api\v1\query\stop
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class StopRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Query.Stop.StopRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public StopRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/query/stop", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Query.Stop.StopRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public StopRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/query/stop", rawUrl)
    {
    }
    /// <summary>
    /// Manually stop a query with client_id
    /// </summary>
    /// <returns>A <see cref="Query.Stop.StopPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Stop400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Stop401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Stop404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Stop500Error">When receiving a 500 status code</exception>
    public async Task<Query.Stop.StopPostResponse> PostAsStopPostResponseAsync(Models.StopQuerySchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Stop400Error.CreateFromDiscriminatorValue },
            { "401", Models.Stop401Error.CreateFromDiscriminatorValue },
            { "404", Models.Stop404Error.CreateFromDiscriminatorValue },
            { "500", Models.Stop500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Query.Stop.StopPostResponse>(requestInfo, Query.Stop.StopPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Manually stop a query with client_id
    /// </summary>
    /// <returns>A <see cref="Query.Stop.StopResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Stop400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Stop401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Stop404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Stop500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsStopPostResponseAsync instead.")]
    public async Task<Query.Stop.StopResponse> PostAsync(Models.StopQuerySchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Stop400Error.CreateFromDiscriminatorValue },
            { "401", Models.Stop401Error.CreateFromDiscriminatorValue },
            { "404", Models.Stop404Error.CreateFromDiscriminatorValue },
            { "500", Models.Stop500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Query.Stop.StopResponse>(requestInfo, Query.Stop.StopResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Manually stop a query with client_id
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Models.StopQuerySchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Query.Stop.StopRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public StopRequestBuilder WithUrl(string rawUrl)
    {
        return new Stop.StopRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class StopRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
