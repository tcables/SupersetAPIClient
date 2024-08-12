
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Report.Item.Log.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\report\{pk}\log\{log_id}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithLog_ItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="API.Report.Item.Log.Item.WithLog_ItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithLog_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/report/{pk}/log/{log_id}{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="API.Report.Item.Log.Item.WithLog_ItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithLog_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/report/{pk}/log/{log_id}{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Get a report schedule log
    /// </summary>
    /// <returns>A <see cref="API.Report.Item.Log.Item.WithLog_GetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithLog_400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithLog_401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithLog_404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithLog_422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithLog_500Error">When receiving a 500 status code</exception>

    public async Task<Report.Item.Log.Item.WithLog_GetResponse> GetWithLog_GetResponseAsync(Action<RequestConfiguration<Report.Item.Log.Item.WithLog_ItemRequestBuilder.WithLog_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithLog_400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithLog_401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithLog_404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithLog_422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithLog_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Report.Item.Log.Item.WithLog_GetResponse>(requestInfo, Report.Item.Log.Item.WithLog_GetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a report schedule log
    /// </summary>
    /// <returns>A <see cref="API.Report.Item.Log.Item.WithLog_Response"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithLog_400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithLog_401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithLog_404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithLog_422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithLog_500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithLog_GetResponseAsync instead.")]

    public async Task<Report.Item.Log.Item.WithLog_Response> GetAsync(Action<RequestConfiguration<Report.Item.Log.Item.WithLog_ItemRequestBuilder.WithLog_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithLog_400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithLog_401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithLog_404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithLog_422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithLog_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Report.Item.Log.Item.WithLog_Response>(requestInfo, Report.Item.Log.Item.WithLog_Response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a report schedule log
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>

    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Report.Item.Log.Item.WithLog_ItemRequestBuilder.WithLog_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="API.Report.Item.Log.Item.WithLog_ItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Log.Item.WithLog_ItemRequestBuilder WithUrl(string rawUrl)
    {
        return new Report.Item.Log.Item.WithLog_ItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Get a report schedule log
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithLog_ItemRequestBuilderGetQueryParameters
    {

        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithLog_ItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Report.Item.Log.Item.WithLog_ItemRequestBuilder.WithLog_ItemRequestBuilderGetQueryParameters>
    {
    }
}
