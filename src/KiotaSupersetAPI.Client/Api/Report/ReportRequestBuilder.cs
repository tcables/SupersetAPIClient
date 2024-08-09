
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Report;

/// <summary>
/// Builds and executes requests for operations under \api\v1\report
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ReportRequestBuilder : BaseRequestBuilder
{
    /// <summary>The _info property</summary>
    public Report._info._infoRequestBuilder _info
    {
        get => new Report._info._infoRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related property</summary>
    public Report.Related.RelatedRequestBuilder Related
    {
        get => new Report.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.report.item collection</summary>
    /// <param name="position">The report schedule pk</param>
    /// <returns>A <see cref="Report.Item.WithPkItemRequestBuilder"/></returns>
    public Report.Item.WithPkItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("pk", position);
            return new Report.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.report.item collection</summary>
    /// <param name="position">The report schedule pk</param>
    /// <returns>A <see cref="Report.Item.WithPkItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public Report.Item.WithPkItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("pk", position);
            return new Report.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Report.ReportRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ReportRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/report{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Report.ReportRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ReportRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/report{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Bulk delete report schedules
    /// </summary>
    /// <returns>A <see cref="Report.ReportDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Report401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Report403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Report404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Report422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Report500Error">When receiving a 500 status code</exception>
    public async Task<Report.ReportDeleteResponse> DeleteAsReportDeleteResponseAsync(Action<RequestConfiguration<Report.ReportRequestBuilder.ReportRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Report401Error.CreateFromDiscriminatorValue },
            { "403", Models.Report403Error.CreateFromDiscriminatorValue },
            { "404", Models.Report404Error.CreateFromDiscriminatorValue },
            { "422", Models.Report422Error.CreateFromDiscriminatorValue },
            { "500", Models.Report500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Report.ReportDeleteResponse>(requestInfo, Report.ReportDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete report schedules
    /// </summary>
    /// <returns>A <see cref="Report.ReportResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Report401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Report403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Report404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Report422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Report500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsReportDeleteResponseAsync instead.")]
    public async Task<Report.ReportResponse> DeleteAsync(Action<RequestConfiguration<Report.ReportRequestBuilder.ReportRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Report401Error.CreateFromDiscriminatorValue },
            { "403", Models.Report403Error.CreateFromDiscriminatorValue },
            { "404", Models.Report404Error.CreateFromDiscriminatorValue },
            { "422", Models.Report422Error.CreateFromDiscriminatorValue },
            { "500", Models.Report500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Report.ReportResponse>(requestInfo, Report.ReportResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of report schedules, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="Report.ReportGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Report400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Report401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Report422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Report500Error">When receiving a 500 status code</exception>
    public async Task<Report.ReportGetResponse> GetReportGetResponseAsync(Action<RequestConfiguration<Report.ReportRequestBuilder.ReportRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Report400Error.CreateFromDiscriminatorValue },
            { "401", Models.Report401Error.CreateFromDiscriminatorValue },
            { "422", Models.Report422Error.CreateFromDiscriminatorValue },
            { "500", Models.Report500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Report.ReportGetResponse>(requestInfo, Report.ReportGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of report schedules, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="Report.ReportResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Report400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Report401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Report422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Report500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsReportGetResponseAsync instead.")]
    public async Task<Report.ReportResponse> GetAsync(Action<RequestConfiguration<Report.ReportRequestBuilder.ReportRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Report400Error.CreateFromDiscriminatorValue },
            { "401", Models.Report401Error.CreateFromDiscriminatorValue },
            { "422", Models.Report422Error.CreateFromDiscriminatorValue },
            { "500", Models.Report500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Report.ReportResponse>(requestInfo, Report.ReportResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a report schedule
    /// </summary>
    /// <returns>A <see cref="Report.ReportPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Report400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Report401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Report404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Report422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Report500Error">When receiving a 500 status code</exception>
    public async Task<Report.ReportPostResponse> PostAsReportPostResponseAsync(Models.ReportScheduleRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Report400Error.CreateFromDiscriminatorValue },
            { "401", Models.Report401Error.CreateFromDiscriminatorValue },
            { "404", Models.Report404Error.CreateFromDiscriminatorValue },
            { "422", Models.Report422Error.CreateFromDiscriminatorValue },
            { "500", Models.Report500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Report.ReportPostResponse>(requestInfo, Report.ReportPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a report schedule
    /// </summary>
    /// <returns>A <see cref="Report.ReportResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Report400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Report401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Report404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Report422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Report500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsReportPostResponseAsync instead.")]
    public async Task<Report.ReportResponse> PostAsync(Models.ReportScheduleRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Report400Error.CreateFromDiscriminatorValue },
            { "401", Models.Report401Error.CreateFromDiscriminatorValue },
            { "404", Models.Report404Error.CreateFromDiscriminatorValue },
            { "422", Models.Report422Error.CreateFromDiscriminatorValue },
            { "500", Models.Report500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Report.ReportResponse>(requestInfo, Report.ReportResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete report schedules
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<Report.ReportRequestBuilder.ReportRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Gets a list of report schedules, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Report.ReportRequestBuilder.ReportRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Create a report schedule
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Models.ReportScheduleRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Report.ReportRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Report.ReportRequestBuilder WithUrl(string rawUrl)
    {
        return new Report.ReportRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Bulk delete report schedules
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ReportRequestBuilderDeleteQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ReportRequestBuilderDeleteRequestConfiguration : RequestConfiguration<Report.ReportRequestBuilder.ReportRequestBuilderDeleteQueryParameters>
    {
    }
    /// <summary>
    /// Gets a list of report schedules, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ReportRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ReportRequestBuilderGetRequestConfiguration : RequestConfiguration<Report.ReportRequestBuilder.ReportRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ReportRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
