
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Async_event;

/// <summary>
/// Builds and executes requests for operations under \api\v1\async_event
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Async_eventRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Async_event.Async_eventRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Async_eventRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/async_event{?last_id*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Async_event.Async_eventRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Async_eventRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/async_event{?last_id*}", rawUrl)
    {
    }
    /// <summary>
    /// Reads off of the Redis events stream, using the user&apos;s JWT token and optional query params for last event received.
    /// </summary>
    /// <returns>A <see cref="Async_event.Async_eventGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Async_event401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Async_event500Error">When receiving a 500 status code</exception>
    public async Task<Async_event.Async_eventGetResponse> GetAsync_eventGetResponseAsync(Action<RequestConfiguration<Async_event.Async_eventRequestBuilder.Async_eventRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Async_event401Error.CreateFromDiscriminatorValue },
            { "500", Models.Async_event500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Async_event.Async_eventGetResponse>(requestInfo, Async_event.Async_eventGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Reads off of the Redis events stream, using the user&apos;s JWT token and optional query params for last event received.
    /// </summary>
    /// <returns>A <see cref="Async_event.Async_eventResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Async_event401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Async_event500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsAsync_eventGetResponseAsync instead.")]
    public async Task<Async_event.Async_eventResponse> GetAsync(Action<RequestConfiguration<Async_event.Async_eventRequestBuilder.Async_eventRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Async_event401Error.CreateFromDiscriminatorValue },
            { "500", Models.Async_event500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Async_event.Async_eventResponse>(requestInfo, Async_event.Async_eventResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Reads off of the Redis events stream, using the user&apos;s JWT token and optional query params for last event received.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Async_event.Async_eventRequestBuilder.Async_eventRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Async_event.Async_eventRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Async_event.Async_eventRequestBuilder WithUrl(string rawUrl)
    {
        return new Async_event.Async_eventRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Reads off of the Redis events stream, using the user&apos;s JWT token and optional query params for last event received.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Async_eventRequestBuilderGetQueryParameters
    {
        /// <summary>Last ID received by the client</summary>
        [QueryParameter("last_id")]
        public string LastId { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Async_eventRequestBuilderGetRequestConfiguration : RequestConfiguration<Async_event.Async_eventRequestBuilder.Async_eventRequestBuilderGetQueryParameters>
    {
    }
}
