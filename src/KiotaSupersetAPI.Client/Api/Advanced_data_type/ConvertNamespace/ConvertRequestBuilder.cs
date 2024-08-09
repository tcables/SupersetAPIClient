
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Advanced_data_type.ConvertNamespace;

/// <summary>
/// Builds and executes requests for operations under \api\v1\advanced_data_type\convert
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ConvertRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Advanced_data_type.ConvertNamespace.ConvertRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ConvertRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/advanced_data_type/convert{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Advanced_data_type.ConvertNamespace.ConvertRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ConvertRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/advanced_data_type/convert{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Returns an AdvancedDataTypeResponse object populated with the passed in args.
    /// </summary>
    /// <returns>A <see cref="KClient.Models.AdvancedDataTypeSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.AdvancedDataTypeSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.AdvancedDataTypeSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.AdvancedDataTypeSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.AdvancedDataTypeSchema500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KClient.Models.AdvancedDataTypeSchema?> GetAsync(Action<RequestConfiguration<Advanced_data_type.ConvertNamespace.ConvertRequestBuilder.ConvertRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KClient.Models.AdvancedDataTypeSchema> GetAsync(Action<RequestConfiguration<Advanced_data_type.ConvertNamespace.ConvertRequestBuilder.ConvertRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.AdvancedDataTypeSchema400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.AdvancedDataTypeSchema401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.AdvancedDataTypeSchema404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.AdvancedDataTypeSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KClient.Models.AdvancedDataTypeSchema>(requestInfo, KClient.Models.AdvancedDataTypeSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Returns an AdvancedDataTypeResponse object populated with the passed in args.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Advanced_data_type.ConvertNamespace.ConvertRequestBuilder.ConvertRequestBuilderGetQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Advanced_data_type.ConvertNamespace.ConvertRequestBuilder.ConvertRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {
#endif
        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Advanced_data_type.ConvertNamespace.ConvertRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Advanced_data_type.ConvertNamespace.ConvertRequestBuilder WithUrl(string rawUrl)
    {
        return new Advanced_data_type.ConvertNamespace.ConvertRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Returns an AdvancedDataTypeResponse object populated with the passed in args.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ConvertRequestBuilderGetQueryParameters
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
    public partial class ConvertRequestBuilderGetRequestConfiguration : RequestConfiguration<Advanced_data_type.ConvertNamespace.ConvertRequestBuilder.ConvertRequestBuilderGetQueryParameters>
    {
    }
}
