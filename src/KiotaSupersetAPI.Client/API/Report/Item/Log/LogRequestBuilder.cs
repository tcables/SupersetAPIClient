
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Report.Item.Log;

/// <summary>
/// Builds and executes requests for operations under \api\v1\report\{pk}\log
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class LogRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.report.item.log.item collection</summary>
    /// <param name="position">The log pk</param>
    /// <returns>A <see cref="API.Report.Item.Log.Item.WithLog_ItemRequestBuilder"/></returns>
    public Report.Item.Log.Item.WithLog_ItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("log_id", position);
            return new Report.Item.Log.Item.WithLog_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.report.item.log.item collection</summary>
    /// <param name="position">The log pk</param>
    /// <returns>A <see cref="API.Report.Item.Log.Item.WithLog_ItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public Report.Item.Log.Item.WithLog_ItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("log_id", position);
            return new Report.Item.Log.Item.WithLog_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="API.Report.Item.Log.LogRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public LogRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/report/{pk}/log{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="API.Report.Item.Log.LogRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public LogRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/report/{pk}/log{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Gets a list of report schedule logs, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="API.Report.Item.Log.LogGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Log400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Log401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Log422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Log500Error">When receiving a 500 status code</exception>

    public async Task<Report.Item.Log.LogGetResponse> GetLogGetResponseAsync(Action<RequestConfiguration<Report.Item.Log.LogRequestBuilder.LogRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Log400Error.CreateFromDiscriminatorValue },
            { "401", Models.Log401Error.CreateFromDiscriminatorValue },
            { "422", Models.Log422Error.CreateFromDiscriminatorValue },
            { "500", Models.Log500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Report.Item.Log.LogGetResponse>(requestInfo, Report.Item.Log.LogGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of report schedule logs, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="API.Report.Item.Log.LogResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Log400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Log401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Log422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Log500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsLogGetResponseAsync instead.")]

    public async Task<Report.Item.Log.LogResponse> GetAsync(Action<RequestConfiguration<Report.Item.Log.LogRequestBuilder.LogRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Log400Error.CreateFromDiscriminatorValue },
            { "401", Models.Log401Error.CreateFromDiscriminatorValue },
            { "422", Models.Log422Error.CreateFromDiscriminatorValue },
            { "500", Models.Log500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Report.Item.Log.LogResponse>(requestInfo, Report.Item.Log.LogResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of report schedule logs, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>

    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Report.Item.Log.LogRequestBuilder.LogRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="API.Report.Item.Log.LogRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Report.Item.Log.LogRequestBuilder WithUrl(string rawUrl)
    {
        return new Report.Item.Log.LogRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Gets a list of report schedule logs, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
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
    public partial class LogRequestBuilderGetRequestConfiguration : RequestConfiguration<Report.Item.Log.LogRequestBuilder.LogRequestBuilderGetQueryParameters>
    {
    }
}
