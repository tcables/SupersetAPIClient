
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Sqllab.Results;

/// <summary>
/// Builds and executes requests for operations under \api\v1\sqllab\results
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ResultsRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Sqllab.Results.ResultsRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ResultsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/sqllab/results{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Sqllab.Results.ResultsRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ResultsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/sqllab/results{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Get the result of a SQL query execution
    /// </summary>
    /// <returns>A <see cref="Models.QueryExecutionResponseSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.QueryExecutionResponseSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.QueryExecutionResponseSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.QueryExecutionResponseSchema403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.QueryExecutionResponseSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.QueryExecutionResponseSchema410Error">When receiving a 410 status code</exception>
    /// <exception cref="Models.QueryExecutionResponseSchema500Error">When receiving a 500 status code</exception>
    public async Task<Models.QueryExecutionResponseSchema> GetAsync(Action<RequestConfiguration<Sqllab.Results.ResultsRequestBuilder.ResultsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.QueryExecutionResponseSchema400Error.CreateFromDiscriminatorValue },
            { "401", Models.QueryExecutionResponseSchema401Error.CreateFromDiscriminatorValue },
            { "403", Models.QueryExecutionResponseSchema403Error.CreateFromDiscriminatorValue },
            { "404", Models.QueryExecutionResponseSchema404Error.CreateFromDiscriminatorValue },
            { "410", Models.QueryExecutionResponseSchema410Error.CreateFromDiscriminatorValue },
            { "500", Models.QueryExecutionResponseSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Models.QueryExecutionResponseSchema>(requestInfo, Models.QueryExecutionResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get the result of a SQL query execution
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Sqllab.Results.ResultsRequestBuilder.ResultsRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Sqllab.Results.ResultsRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public ResultsRequestBuilder WithUrl(string rawUrl)
    {
        return new Results.ResultsRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Get the result of a SQL query execution
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ResultsRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ResultsRequestBuilderGetRequestConfiguration : RequestConfiguration<Sqllab.Results.ResultsRequestBuilder.ResultsRequestBuilderGetQueryParameters>
    {
    }
}
