
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Query.Updated_since;

/// <summary>
/// Builds and executes requests for operations under \api\v1\query\updated_since
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Updated_sinceRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Query.Updated_since.Updated_sinceRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Updated_sinceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/query/updated_since{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Query.Updated_since.Updated_sinceRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Updated_sinceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/query/updated_since{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Get a list of queries that changed after last_updated_ms
    /// </summary>
    /// <returns>A <see cref="Query.Updated_since.Updated_sinceGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Updated_since400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Updated_since401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Updated_since404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Updated_since500Error">When receiving a 500 status code</exception>
    public async Task<Query.Updated_since.Updated_sinceGetResponse> GetUpdated_sinceGetResponseAsync(Action<RequestConfiguration<Query.Updated_since.Updated_sinceRequestBuilder.Updated_sinceRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Updated_since400Error.CreateFromDiscriminatorValue },
            { "401", Models.Updated_since401Error.CreateFromDiscriminatorValue },
            { "404", Models.Updated_since404Error.CreateFromDiscriminatorValue },
            { "500", Models.Updated_since500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Query.Updated_since.Updated_sinceGetResponse>(requestInfo, Query.Updated_since.Updated_sinceGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a list of queries that changed after last_updated_ms
    /// </summary>
    /// <returns>A <see cref="Query.Updated_since.Updated_sinceResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Updated_since400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Updated_since401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Updated_since404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Updated_since500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsUpdated_sinceGetResponseAsync instead.")]
    public async Task<Query.Updated_since.Updated_sinceResponse> GetAsync(Action<RequestConfiguration<Query.Updated_since.Updated_sinceRequestBuilder.Updated_sinceRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Updated_since400Error.CreateFromDiscriminatorValue },
            { "401", Models.Updated_since401Error.CreateFromDiscriminatorValue },
            { "404", Models.Updated_since404Error.CreateFromDiscriminatorValue },
            { "500", Models.Updated_since500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Query.Updated_since.Updated_sinceResponse>(requestInfo, Query.Updated_since.Updated_sinceResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a list of queries that changed after last_updated_ms
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Query.Updated_since.Updated_sinceRequestBuilder.Updated_sinceRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Query.Updated_since.Updated_sinceRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Updated_since.Updated_sinceRequestBuilder WithUrl(string rawUrl)
    {
        return new Query.Updated_since.Updated_sinceRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Get a list of queries that changed after last_updated_ms
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Updated_sinceRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Updated_sinceRequestBuilderGetRequestConfiguration : RequestConfiguration<Query.Updated_since.Updated_sinceRequestBuilder.Updated_sinceRequestBuilderGetQueryParameters>
    {
    }
}
