
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Datasource.Item.Item.Column.Item.Values;

/// <summary>
/// Builds and executes requests for operations under \api\v1\datasource\{datasource_type}\{datasource_id}\column\{column_name}\values
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ValuesRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Datasource.Item.Item.Column.Item.Values.ValuesRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ValuesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/datasource/{datasource_type}/{datasource_id}/column/{column_name}/values", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Datasource.Item.Item.Column.Item.Values.ValuesRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ValuesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/datasource/{datasource_type}/{datasource_id}/column/{column_name}/values", rawUrl)
    {
    }
    /// <summary>
    /// Get possible values for a datasource column
    /// </summary>
    /// <returns>A <see cref="KApi.Datasource.Item.Item.Column.Item.Values.ValuesGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Values400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Values401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Values403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Values404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Values500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Datasource.Item.Item.Column.Item.Values.ValuesGetResponse> GetValuesGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Values400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Values401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Values403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Values404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Values500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Datasource.Item.Item.Column.Item.Values.ValuesGetResponse>(requestInfo, KApi.Datasource.Item.Item.Column.Item.Values.ValuesGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get possible values for a datasource column
    /// </summary>
    /// <returns>A <see cref="KApi.Datasource.Item.Item.Column.Item.Values.ValuesResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Values400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Values401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Values403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Values404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Values500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsValuesGetResponseAsync instead.")]
    public async Task<KApi.Datasource.Item.Item.Column.Item.Values.ValuesResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Values400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Values401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Values403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Values404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Values500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Datasource.Item.Item.Column.Item.Values.ValuesResponse>(requestInfo, KApi.Datasource.Item.Item.Column.Item.Values.ValuesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get possible values for a datasource column
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
    /// <returns>A <see cref="KApi.Datasource.Item.Item.Column.Item.Values.ValuesRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Datasource.Item.Item.Column.Item.Values.ValuesRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Datasource.Item.Item.Column.Item.Values.ValuesRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ValuesRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
