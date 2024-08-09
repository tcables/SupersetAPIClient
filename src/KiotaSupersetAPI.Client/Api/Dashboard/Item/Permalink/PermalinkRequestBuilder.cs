
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Permalink;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dashboard\{dashboard_-id}\permalink
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class PermalinkRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Permalink.PermalinkRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public PermalinkRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/permalink", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Permalink.PermalinkRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public PermalinkRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/permalink", rawUrl)
    {
    }
    /// <summary>
    /// Create a new dashboard&apos;s permanent link
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Permalink.PermalinkPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Permalink400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Permalink401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Permalink422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Permalink500Error">When receiving a 500 status code</exception>
    public async Task<Dashboard.Item.Permalink.PermalinkPostResponse> PostAsPermalinkPostResponseAsync(KClient.Models.DashboardPermalinkStateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Permalink400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Permalink401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Permalink422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Permalink500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Permalink.PermalinkPostResponse>(requestInfo, Dashboard.Item.Permalink.PermalinkPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new dashboard&apos;s permanent link
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Permalink.PermalinkResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Permalink400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Permalink401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Permalink422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Permalink500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsPermalinkPostResponseAsync instead.")]
    public async Task<Dashboard.Item.Permalink.PermalinkResponse> PostAsync(KClient.Models.DashboardPermalinkStateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Permalink400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Permalink401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Permalink422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Permalink500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Permalink.PermalinkResponse>(requestInfo, Dashboard.Item.Permalink.PermalinkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new dashboard&apos;s permanent link
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(KClient.Models.DashboardPermalinkStateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Dashboard.Item.Permalink.PermalinkRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Dashboard.Item.Permalink.PermalinkRequestBuilder WithUrl(string rawUrl)
    {
        return new Dashboard.Item.Permalink.PermalinkRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class PermalinkRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
