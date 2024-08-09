
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Embedded_dashboard.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\embedded_dashboard\{uuid}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithUuItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Embedded_dashboard.Item.WithUuItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithUuItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/embedded_dashboard/{uuid}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Embedded_dashboard.Item.WithUuItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithUuItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/embedded_dashboard/{uuid}", rawUrl)
    {
    }
    /// <summary>
    /// Get a report schedule log
    /// </summary>
    /// <returns>A <see cref="KApi.Embedded_dashboard.Item.WithUuGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithUu401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithUu404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithUu500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Embedded_dashboard.Item.WithUuGetResponse> GetAsWithUuGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.WithUu401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithUu404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithUu500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Embedded_dashboard.Item.WithUuGetResponse>(requestInfo, KApi.Embedded_dashboard.Item.WithUuGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a report schedule log
    /// </summary>
    /// <returns>A <see cref="KApi.Embedded_dashboard.Item.WithUuResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithUu401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithUu404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithUu500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithUuGetResponseAsync instead.")]
    public async Task<KApi.Embedded_dashboard.Item.WithUuResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.WithUu401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithUu404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithUu500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Embedded_dashboard.Item.WithUuResponse>(requestInfo, KApi.Embedded_dashboard.Item.WithUuResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a report schedule log
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
    /// <returns>A <see cref="KApi.Embedded_dashboard.Item.WithUuItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Embedded_dashboard.Item.WithUuItemRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Embedded_dashboard.Item.WithUuItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithUuItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
