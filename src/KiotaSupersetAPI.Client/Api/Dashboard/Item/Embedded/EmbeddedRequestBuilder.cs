
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Embedded;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dashboard\{dashboard_-id}\embedded
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class EmbeddedRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Embedded.EmbeddedRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public EmbeddedRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/embedded", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Embedded.EmbeddedRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public EmbeddedRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/embedded", rawUrl)
    {
    }
    /// <summary>
    /// Delete a dashboard&apos;s embedded configuration
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Embedded.EmbeddedDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Embedded401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Embedded500Error">When receiving a 500 status code</exception>
    public async Task<Dashboard.Item.Embedded.EmbeddedDeleteResponse> DeleteAsEmbeddedDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Embedded401Error.CreateFromDiscriminatorValue },
            { "500", Models.Embedded500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Embedded.EmbeddedDeleteResponse>(requestInfo, Dashboard.Item.Embedded.EmbeddedDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a dashboard&apos;s embedded configuration
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Embedded.EmbeddedResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Embedded401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Embedded500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsEmbeddedDeleteResponseAsync instead.")]
    public async Task<Dashboard.Item.Embedded.EmbeddedResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Embedded401Error.CreateFromDiscriminatorValue },
            { "500", Models.Embedded500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Embedded.EmbeddedResponse>(requestInfo, Dashboard.Item.Embedded.EmbeddedResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get the dashboard&apos;s embedded configuration
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Embedded.EmbeddedGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Embedded401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Embedded500Error">When receiving a 500 status code</exception>
    public async Task<Dashboard.Item.Embedded.EmbeddedGetResponse> GetEmbeddedGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Embedded401Error.CreateFromDiscriminatorValue },
            { "500", Models.Embedded500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Embedded.EmbeddedGetResponse>(requestInfo, Dashboard.Item.Embedded.EmbeddedGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get the dashboard&apos;s embedded configuration
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Embedded.EmbeddedResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Embedded401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Embedded500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsEmbeddedGetResponseAsync instead.")]
    public async Task<Dashboard.Item.Embedded.EmbeddedResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Embedded401Error.CreateFromDiscriminatorValue },
            { "500", Models.Embedded500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Embedded.EmbeddedResponse>(requestInfo, Dashboard.Item.Embedded.EmbeddedResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Set a dashboard&apos;s embedded configuration
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Embedded.EmbeddedPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Embedded401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Embedded500Error">When receiving a 500 status code</exception>
    public async Task<Dashboard.Item.Embedded.EmbeddedPostResponse> PostAsEmbeddedPostResponseAsync(Models.EmbeddedDashboardConfig body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Embedded401Error.CreateFromDiscriminatorValue },
            { "500", Models.Embedded500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Embedded.EmbeddedPostResponse>(requestInfo, Dashboard.Item.Embedded.EmbeddedPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Set a dashboard&apos;s embedded configuration
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Embedded.EmbeddedResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Embedded401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Embedded500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsEmbeddedPostResponseAsync instead.")]
    public async Task<Dashboard.Item.Embedded.EmbeddedResponse> PostAsync(Models.EmbeddedDashboardConfig body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Embedded401Error.CreateFromDiscriminatorValue },
            { "500", Models.Embedded500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Embedded.EmbeddedResponse>(requestInfo, Dashboard.Item.Embedded.EmbeddedResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Sets a dashboard&apos;s embedded configuration.
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Embedded.EmbeddedPutResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Embedded401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Embedded500Error">When receiving a 500 status code</exception>
    public async Task<Dashboard.Item.Embedded.EmbeddedPutResponse> PutAsEmbeddedPutResponseAsync(Models.EmbeddedDashboardConfig body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Embedded401Error.CreateFromDiscriminatorValue },
            { "500", Models.Embedded500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Embedded.EmbeddedPutResponse>(requestInfo, Dashboard.Item.Embedded.EmbeddedPutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Sets a dashboard&apos;s embedded configuration.
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Embedded.EmbeddedResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Embedded401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Embedded500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PutAsEmbeddedPutResponseAsync instead.")]
    public async Task<Dashboard.Item.Embedded.EmbeddedResponse> PutAsync(Models.EmbeddedDashboardConfig body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Embedded401Error.CreateFromDiscriminatorValue },
            { "500", Models.Embedded500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dashboard.Item.Embedded.EmbeddedResponse>(requestInfo, Dashboard.Item.Embedded.EmbeddedResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a dashboard&apos;s embedded configuration
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Get the dashboard&apos;s embedded configuration
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
    /// Set a dashboard&apos;s embedded configuration
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Models.EmbeddedDashboardConfig body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
        return requestInfo;
    }
    /// <summary>
    /// Sets a dashboard&apos;s embedded configuration.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPutRequestInformation(Models.EmbeddedDashboardConfig body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Embedded.EmbeddedRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Embedded.EmbeddedRequestBuilder WithUrl(string rawUrl)
    {
        return new Item.Embedded.EmbeddedRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class EmbeddedRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class EmbeddedRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class EmbeddedRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class EmbeddedRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
