
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Database.Item.Function_names;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\{pk}\function_names
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Function_namesRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Function_names.Function_namesRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Function_namesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/function_names", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Function_names.Function_namesRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Function_namesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/function_names", rawUrl)
    {
    }
    /// <summary>
    /// Get function names supported by a database
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatabaseFunctionNamesResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.DatabaseFunctionNamesResponse401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.DatabaseFunctionNamesResponse404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.DatabaseFunctionNamesResponse500Error">When receiving a 500 status code</exception>
    public async Task<KClient.Models.DatabaseFunctionNamesResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.DatabaseFunctionNamesResponse401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.DatabaseFunctionNamesResponse404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.DatabaseFunctionNamesResponse500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KClient.Models.DatabaseFunctionNamesResponse>(requestInfo, KClient.Models.DatabaseFunctionNamesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get function names supported by a database
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
    /// <returns>A <see cref="Database.Item.Function_names.Function_namesRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Database.Item.Function_names.Function_namesRequestBuilder WithUrl(string rawUrl)
    {
        return new Database.Item.Function_names.Function_namesRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Function_namesRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
