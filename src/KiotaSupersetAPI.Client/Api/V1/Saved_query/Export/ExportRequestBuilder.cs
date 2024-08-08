
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Saved_query.Export;

/// <summary>
/// Builds and executes requests for operations under \api\v1\saved_query\export
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ExportRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Saved_query.Export.ExportRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ExportRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/saved_query/export{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Saved_query.Export.ExportRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ExportRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/saved_query/export{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Download multiple saved queries as YAML files
    /// </summary>
    /// <returns>A <see cref="Stream"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Export400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Export401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Export404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Export500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<Stream?> GetAsync(Action<RequestConfiguration<KApi.Saved_query.Export.ExportRequestBuilder.ExportRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<Stream> GetAsync(Action<RequestConfiguration<KApi.Saved_query.Export.ExportRequestBuilder.ExportRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Export400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Export401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Export404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Export500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Download multiple saved queries as YAML files
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Saved_query.Export.ExportRequestBuilder.ExportRequestBuilderGetQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Saved_query.Export.ExportRequestBuilder.ExportRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {
#endif
        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/zip, application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Saved_query.Export.ExportRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Saved_query.Export.ExportRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Saved_query.Export.ExportRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Download multiple saved queries as YAML files
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ExportRequestBuilderGetQueryParameters
    {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        [QueryParameter("q")]
        public string? Q { get; set; }
#nullable restore
#else
        [QueryParameter("q")]
        public string Q { get; set; }
#endif
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ExportRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Saved_query.Export.ExportRequestBuilder.ExportRequestBuilderGetQueryParameters>
    {
    }
}
