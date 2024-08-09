
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Chart.Item.Data;

/// <summary>
/// Builds and executes requests for operations under \api\v1\chart\{pk}\data
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class DataRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Chart.Item.Data.DataRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DataRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/{pk}/data{?force*,format*,type*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Chart.Item.Data.DataRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DataRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/{pk}/data{?force*,format*,type*}", rawUrl)
    {
    }
    /// <summary>
    /// Takes a chart ID and uses the query context stored when the chart was saved to return payload data response.
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ChartDataResponseSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.ChartDataResponseSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.ChartDataResponseSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.ChartDataResponseSchema500Error">When receiving a 500 status code</exception>
    public async Task<KClient.Models.ChartDataResponseSchema> GetAsync(Action<RequestConfiguration<KApi.Chart.Item.Data.DataRequestBuilder.DataRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.ChartDataResponseSchema400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.ChartDataResponseSchema401Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.ChartDataResponseSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KClient.Models.ChartDataResponseSchema>(requestInfo, KClient.Models.ChartDataResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Takes a chart ID and uses the query context stored when the chart was saved to return payload data response.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Chart.Item.Data.DataRequestBuilder.DataRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.Item.Data.DataRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Chart.Item.Data.DataRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Chart.Item.Data.DataRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Takes a chart ID and uses the query context stored when the chart was saved to return payload data response.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DataRequestBuilderGetQueryParameters
    {
        /// <summary>Should the queries be forced to load from the source</summary>
        [QueryParameter("force")]
        public bool? Force { get; set; }
        /// <summary>The format in which the data should be returned</summary>
        [QueryParameter("format")]
        public string Format { get; set; }

        /// <summary>The type in which the data should be returned</summary>
        [QueryParameter("type")]
        public string Type { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DataRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Chart.Item.Data.DataRequestBuilder.DataRequestBuilderGetQueryParameters>
    {
    }
}
