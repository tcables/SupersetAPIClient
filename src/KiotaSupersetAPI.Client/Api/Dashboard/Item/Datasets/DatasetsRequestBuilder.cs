
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Datasets;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dashboard\{dashboard_-id}\datasets
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class DatasetsRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Datasets.DatasetsRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DatasetsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/datasets", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Datasets.DatasetsRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DatasetsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/datasets", rawUrl)
    {
    }
    /// <summary>
    /// Returns a list of a dashboard&apos;s datasets. Each dataset includes only the information necessary to render the dashboard&apos;s charts.
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Datasets.DatasetsGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Datasets400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Datasets401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Datasets403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Datasets404Error">When receiving a 404 status code</exception>
    public async Task<Dashboard.Item.Datasets.DatasetsGetResponse> GetDatasetsGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Datasets400Error.CreateFromDiscriminatorValue },
            { "401", Models.Datasets401Error.CreateFromDiscriminatorValue },
            { "403", Models.Datasets403Error.CreateFromDiscriminatorValue },
            { "404", Models.Datasets404Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Datasets.DatasetsGetResponse>(requestInfo, Dashboard.Item.Datasets.DatasetsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Returns a list of a dashboard&apos;s datasets. Each dataset includes only the information necessary to render the dashboard&apos;s charts.
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Datasets.DatasetsResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Datasets400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Datasets401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Datasets403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Datasets404Error">When receiving a 404 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsDatasetsGetResponseAsync instead.")]
    public async Task<Dashboard.Item.Datasets.DatasetsResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Datasets400Error.CreateFromDiscriminatorValue },
            { "401", Models.Datasets401Error.CreateFromDiscriminatorValue },
            { "403", Models.Datasets403Error.CreateFromDiscriminatorValue },
            { "404", Models.Datasets404Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Datasets.DatasetsResponse>(requestInfo, Dashboard.Item.Datasets.DatasetsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Returns a list of a dashboard&apos;s datasets. Each dataset includes only the information necessary to render the dashboard&apos;s charts.
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
    /// <returns>A <see cref="Dashboard.Item.Datasets.DatasetsRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Dashboard.Item.Datasets.DatasetsRequestBuilder WithUrl(string rawUrl)
    {
        return new Dashboard.Item.Datasets.DatasetsRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DatasetsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
