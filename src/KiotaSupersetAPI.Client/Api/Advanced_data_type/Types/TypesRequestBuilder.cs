
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Advanced_data_type.Types;

/// <summary>
/// Builds and executes requests for operations under \api\v1\advanced_data_type\types
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class TypesRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Advanced_data_type.Types.TypesRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public TypesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/advanced_data_type/types", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Advanced_data_type.Types.TypesRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public TypesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/advanced_data_type/types", rawUrl)
    {
    }
    /// <summary>
    /// Return a list of available advanced data types
    /// </summary>
    /// <returns>A <see cref="Advanced_data_type.Types.TypesGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Types401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Types404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Types500Error">When receiving a 500 status code</exception>
    public async Task<Advanced_data_type.Types.TypesGetResponse> GetTypesGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Types401Error.CreateFromDiscriminatorValue },
            { "404", Models.Types404Error.CreateFromDiscriminatorValue },
            { "500", Models.Types500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Advanced_data_type.Types.TypesGetResponse>(requestInfo, Advanced_data_type.Types.TypesGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Return a list of available advanced data types
    /// </summary>
    /// <returns>A <see cref="Advanced_data_type.Types.TypesResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Types401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Types404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Types500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsTypesGetResponseAsync instead.")]
    public async Task<Advanced_data_type.Types.TypesResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Types401Error.CreateFromDiscriminatorValue },
            { "404", Models.Types404Error.CreateFromDiscriminatorValue },
            { "500", Models.Types500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Advanced_data_type.Types.TypesResponse>(requestInfo, Advanced_data_type.Types.TypesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Return a list of available advanced data types
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
    /// <returns>A <see cref="Advanced_data_type.Types.TypesRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Advanced_data_type.Types.TypesRequestBuilder WithUrl(string rawUrl)
    {
        return new Advanced_data_type.Types.TypesRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class TypesRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
