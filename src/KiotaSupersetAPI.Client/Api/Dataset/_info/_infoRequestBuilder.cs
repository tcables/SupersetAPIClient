
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dataset._info;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dataset\_info
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class _infoRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Dataset._info._infoRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public _infoRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/_info{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dataset._info._infoRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public _infoRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/_info{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Get metadata information about this API resource
    /// </summary>
    /// <returns>A <see cref="Dataset._info._infoGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models._info400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models._info401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models._info422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models._info500Error">When receiving a 500 status code</exception>
    public async Task<Dataset._info._infoGetResponse> Get_infoGetResponseAsync(Action<RequestConfiguration<Dataset._info._infoRequestBuilder._infoRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models._info400Error.CreateFromDiscriminatorValue },
            { "401", Models._info401Error.CreateFromDiscriminatorValue },
            { "422", Models._info422Error.CreateFromDiscriminatorValue },
            { "500", Models._info500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dataset._info._infoGetResponse>(requestInfo, Dataset._info._infoGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get metadata information about this API resource
    /// </summary>
    /// <returns>A <see cref="Dataset._info._infoResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models._info400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models._info401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models._info422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models._info500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAs_infoGetResponseAsync instead.")]
    public async Task<Dataset._info._infoResponse> GetAsync(Action<RequestConfiguration<Dataset._info._infoRequestBuilder._infoRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models._info400Error.CreateFromDiscriminatorValue },
            { "401", Models._info401Error.CreateFromDiscriminatorValue },
            { "422", Models._info422Error.CreateFromDiscriminatorValue },
            { "500", Models._info500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dataset._info._infoResponse>(requestInfo, Dataset._info._infoResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get metadata information about this API resource
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Dataset._info._infoRequestBuilder._infoRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Dataset._info._infoRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public _info._infoRequestBuilder WithUrl(string rawUrl)
    {
        return new _info._infoRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Get metadata information about this API resource
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class _infoRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class _infoRequestBuilderGetRequestConfiguration : RequestConfiguration<Dataset._info._infoRequestBuilder._infoRequestBuilderGetQueryParameters>
    {
    }
}
