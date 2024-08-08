
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KiotaSupersetAPI.Client.Api.V1.Sqllab.Estimate;
using KiotaSupersetAPI.Client.Api.V1.Sqllab.Execute;
using KiotaSupersetAPI.Client.Api.V1.Sqllab.Export;
using KiotaSupersetAPI.Client.Api.V1.Sqllab.Format_sql;
using KiotaSupersetAPI.Client.Api.V1.Sqllab.Results;
using KiotaSupersetAPI.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Sqllab;

/// <summary>
/// Builds and executes requests for operations under \api\v1\sqllab
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class SqllabRequestBuilder : BaseRequestBuilder
{
    /// <summary>The estimate property</summary>
    public KApi.Sqllab.Estimate.EstimateRequestBuilder Estimate
    {
        get => new KApi.Sqllab.Estimate.EstimateRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The execute property</summary>
    public KApi.Sqllab.Execute.ExecuteRequestBuilder Execute
    {
        get => new KApi.Sqllab.Execute.ExecuteRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The export property</summary>
    public KApi.Sqllab.Export.ExportRequestBuilder Export
    {
        get => new KApi.Sqllab.Export.ExportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The format_sql property</summary>
    public KApi.Sqllab.Format_sql.Format_sqlRequestBuilder Format_sql
    {
        get => new KApi.Sqllab.Format_sql.Format_sqlRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The results property</summary>
    public KApi.Sqllab.Results.ResultsRequestBuilder Results
    {
        get => new KApi.Sqllab.Results.ResultsRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Sqllab.SqllabRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public SqllabRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/sqllab", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Sqllab.SqllabRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public SqllabRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/sqllab", rawUrl)
    {
    }
    /// <summary>
    /// Assembles SQLLab bootstrap data (active_tab, databases, queries, tab_state_ids) in a single endpoint. The data can be assembled from the current user&apos;s id.
    /// </summary>
    /// <returns>A <see cref="KClient.Models.SQLLabBootstrapSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.SQLLabBootstrapSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.SQLLabBootstrapSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.SQLLabBootstrapSchema403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.SQLLabBootstrapSchema500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KClient.Models.SQLLabBootstrapSchema?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KClient.Models.SQLLabBootstrapSchema> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.SQLLabBootstrapSchema400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.SQLLabBootstrapSchema401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.SQLLabBootstrapSchema403Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.SQLLabBootstrapSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KClient.Models.SQLLabBootstrapSchema>(requestInfo, KClient.Models.SQLLabBootstrapSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Assembles SQLLab bootstrap data (active_tab, databases, queries, tab_state_ids) in a single endpoint. The data can be assembled from the current user&apos;s id.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {
#endif
        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Sqllab.SqllabRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Sqllab.SqllabRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Sqllab.SqllabRequestBuilder(rawUrl, RequestAdapter);
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
