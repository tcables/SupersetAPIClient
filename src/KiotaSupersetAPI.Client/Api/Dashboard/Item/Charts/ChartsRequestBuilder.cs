
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Charts;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dashboard\{dashboard_-id}\charts
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ChartsRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Charts.ChartsRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ChartsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/charts", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Charts.ChartsRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ChartsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/charts", rawUrl)
    {
    }
    /// <summary>
    /// Get a dashboard&apos;s chart definitions.
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Charts.ChartsGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Charts400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Charts401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Charts403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Charts404Error">When receiving a 404 status code</exception>
    public async Task<Dashboard.Item.Charts.ChartsGetResponse> GetChartsGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Charts400Error.CreateFromDiscriminatorValue },
            { "401", Models.Charts401Error.CreateFromDiscriminatorValue },
            { "403", Models.Charts403Error.CreateFromDiscriminatorValue },
            { "404", Models.Charts404Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Charts.ChartsGetResponse>(requestInfo, Dashboard.Item.Charts.ChartsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a dashboard&apos;s chart definitions.
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Charts.ChartsResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Charts400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Charts401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Charts403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Charts404Error">When receiving a 404 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsChartsGetResponseAsync instead.")]
    public async Task<Dashboard.Item.Charts.ChartsResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Charts400Error.CreateFromDiscriminatorValue },
            { "401", Models.Charts401Error.CreateFromDiscriminatorValue },
            { "403", Models.Charts403Error.CreateFromDiscriminatorValue },
            { "404", Models.Charts404Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Charts.ChartsResponse>(requestInfo, Dashboard.Item.Charts.ChartsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a dashboard&apos;s chart definitions.
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
    /// <returns>A <see cref="Dashboard.Item.Charts.ChartsRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Charts.ChartsRequestBuilder WithUrl(string rawUrl)
    {
        return new Item.Charts.ChartsRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ChartsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
