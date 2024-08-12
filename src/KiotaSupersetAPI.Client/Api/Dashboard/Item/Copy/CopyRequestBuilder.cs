
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Copy;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dashboard\{dashboard_-id}\copy
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class CopyRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Copy.CopyRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public CopyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/copy", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Copy.CopyRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public CopyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/copy", rawUrl)
    {
    }
    /// <summary>
    /// Create a copy of an existing dashboard
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Copy.CopyPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Copy400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Copy401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Copy403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Copy404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Copy500Error">When receiving a 500 status code</exception>
    public async Task<Dashboard.Item.Copy.CopyPostResponse> PostAsCopyPostResponseAsync(Models.DashboardCopySchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Copy400Error.CreateFromDiscriminatorValue },
            { "401", Models.Copy401Error.CreateFromDiscriminatorValue },
            { "403", Models.Copy403Error.CreateFromDiscriminatorValue },
            { "404", Models.Copy404Error.CreateFromDiscriminatorValue },
            { "500", Models.Copy500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Copy.CopyPostResponse>(requestInfo, Dashboard.Item.Copy.CopyPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a copy of an existing dashboard
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Copy.CopyResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Copy400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Copy401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Copy403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Copy404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Copy500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsCopyPostResponseAsync instead.")]
    public async Task<Dashboard.Item.Copy.CopyResponse> PostAsync(Models.DashboardCopySchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Copy400Error.CreateFromDiscriminatorValue },
            { "401", Models.Copy401Error.CreateFromDiscriminatorValue },
            { "403", Models.Copy403Error.CreateFromDiscriminatorValue },
            { "404", Models.Copy404Error.CreateFromDiscriminatorValue },
            { "500", Models.Copy500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Copy.CopyResponse>(requestInfo, Dashboard.Item.Copy.CopyResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a copy of an existing dashboard
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Models.DashboardCopySchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Dashboard.Item.Copy.CopyRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Copy.CopyRequestBuilder WithUrl(string rawUrl)
    {
        return new Dashboard.Item.Copy.CopyRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class CopyRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
