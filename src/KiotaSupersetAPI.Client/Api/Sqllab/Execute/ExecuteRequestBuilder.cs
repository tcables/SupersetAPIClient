
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Sqllab.Execute;

/// <summary>
/// Builds and executes requests for operations under \api\v1\sqllab\execute
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ExecuteRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Sqllab.Execute.ExecuteRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ExecuteRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/sqllab/execute", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Sqllab.Execute.ExecuteRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ExecuteRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/sqllab/execute", rawUrl)
    {
    }
    /// <summary>
    /// Execute a SQL query
    /// </summary>
    /// <returns>A <see cref="Models.QueryExecutionResponseSchema"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.QueryExecutionResponseSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.QueryExecutionResponseSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.QueryExecutionResponseSchema403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.QueryExecutionResponseSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.QueryExecutionResponseSchema500Error">When receiving a 500 status code</exception>
    public async Task<Models.QueryExecutionResponseSchema> PostAsync(Models.ExecutePayloadSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.QueryExecutionResponseSchema400Error.CreateFromDiscriminatorValue },
            { "401", Models.QueryExecutionResponseSchema401Error.CreateFromDiscriminatorValue },
            { "403", Models.QueryExecutionResponseSchema403Error.CreateFromDiscriminatorValue },
            { "404", Models.QueryExecutionResponseSchema404Error.CreateFromDiscriminatorValue },
            { "500", Models.QueryExecutionResponseSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Models.QueryExecutionResponseSchema>(requestInfo, Models.QueryExecutionResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Execute a SQL query
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Models.ExecutePayloadSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Sqllab.Execute.ExecuteRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public ExecuteRequestBuilder WithUrl(string rawUrl)
    {
        return new Execute.ExecuteRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ExecuteRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
