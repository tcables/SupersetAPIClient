
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Available_domains;

/// <summary>
/// Builds and executes requests for operations under \api\v1\available_domains
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Available_domainsRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Available_domains.Available_domainsRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Available_domainsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/available_domains", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Available_domains.Available_domainsRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Available_domainsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/available_domains", rawUrl)
    {
    }
    /// <summary>
    /// Get all available domains
    /// </summary>
    /// <returns>A <see cref="KApi.Available_domains.Available_domainsGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Available_domains401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Available_domains403Error">When receiving a 403 status code</exception>
    public async Task<KApi.Available_domains.Available_domainsGetResponse> GetAsAvailable_domainsGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Available_domains401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Available_domains403Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Available_domains.Available_domainsGetResponse>(requestInfo, KApi.Available_domains.Available_domainsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get all available domains
    /// </summary>
    /// <returns>A <see cref="KApi.Available_domains.Available_domainsResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Available_domains401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Available_domains403Error">When receiving a 403 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsAvailable_domainsGetResponseAsync instead.")]
    public async Task<KApi.Available_domains.Available_domainsResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Available_domains401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Available_domains403Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Available_domains.Available_domainsResponse>(requestInfo, KApi.Available_domains.Available_domainsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get all available domains
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
    /// <returns>A <see cref="KApi.Available_domains.Available_domainsRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Available_domains.Available_domainsRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Available_domains.Available_domainsRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Available_domainsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
