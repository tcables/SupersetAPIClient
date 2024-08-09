
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Sqllab;

/// <summary>
/// Builds and executes requests for operations under \api\v1\sqllab
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class SqllabRequestBuilder : BaseRequestBuilder
{
    /// <summary>The estimate property</summary>
    public Sqllab.Estimate.EstimateRequestBuilder Estimate
    {
        get => new Sqllab.Estimate.EstimateRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The execute property</summary>
    public Sqllab.Execute.ExecuteRequestBuilder Execute
    {
        get => new Sqllab.Execute.ExecuteRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The export property</summary>
    public Sqllab.Export.ExportRequestBuilder Export
    {
        get => new Sqllab.Export.ExportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The format_sql property</summary>
    public Sqllab.Format_sql.Format_sqlRequestBuilder Format_sql
    {
        get => new Sqllab.Format_sql.Format_sqlRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The results property</summary>
    public Sqllab.Results.ResultsRequestBuilder Results
    {
        get => new Sqllab.Results.ResultsRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="Sqllab.SqllabRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public SqllabRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/sqllab", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Sqllab.SqllabRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public SqllabRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/sqllab", rawUrl)
    {
    }
    /// <summary>
    /// Assembles SQLLab bootstrap data (active_tab, databases, queries, tab_state_ids) in a single endpoint. The data can be assembled from the current user&apos;s id.
    /// </summary>
    /// <returns>A <see cref="Models.SQLLabBootstrapSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.SQLLabBootstrapSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.SQLLabBootstrapSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.SQLLabBootstrapSchema403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.SQLLabBootstrapSchema500Error">When receiving a 500 status code</exception>
    public async Task<Models.SQLLabBootstrapSchema> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.SQLLabBootstrapSchema400Error.CreateFromDiscriminatorValue },
            { "401", Models.SQLLabBootstrapSchema401Error.CreateFromDiscriminatorValue },
            { "403", Models.SQLLabBootstrapSchema403Error.CreateFromDiscriminatorValue },
            { "500", Models.SQLLabBootstrapSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Models.SQLLabBootstrapSchema>(requestInfo, Models.SQLLabBootstrapSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Assembles SQLLab bootstrap data (active_tab, databases, queries, tab_state_ids) in a single endpoint. The data can be assembled from the current user&apos;s id.
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
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Sqllab.SqllabRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Sqllab.SqllabRequestBuilder WithUrl(string rawUrl)
    {
        return new Sqllab.SqllabRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class SqllabRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
