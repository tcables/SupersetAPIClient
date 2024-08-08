
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Database.Item.Tables;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\{pk}\tables
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class TablesRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Database.Item.Tables.TablesRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public TablesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/tables{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Database.Item.Tables.TablesRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public TablesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/tables{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Get a list of tables for given database
    /// </summary>
    /// <returns>A <see cref="KApi.Database.Item.Tables.TablesGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Tables400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Tables401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Tables404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Tables422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Tables500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Database.Item.Tables.TablesGetResponse> GetAsTablesGetResponseAsync(Action<RequestConfiguration<KApi.Database.Item.Tables.TablesRequestBuilder.TablesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Tables400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Tables401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Tables404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Tables422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Tables500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Database.Item.Tables.TablesGetResponse>(requestInfo, KApi.Database.Item.Tables.TablesGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a list of tables for given database
    /// </summary>
    /// <returns>A <see cref="KApi.Database.Item.Tables.TablesResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Tables400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Tables401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Tables404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Tables422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Tables500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsTablesGetResponseAsync instead.")]
    public async Task<KApi.Database.Item.Tables.TablesResponse> GetAsync(Action<RequestConfiguration<KApi.Database.Item.Tables.TablesRequestBuilder.TablesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Tables400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Tables401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Tables404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Tables422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Tables500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Database.Item.Tables.TablesResponse>(requestInfo, KApi.Database.Item.Tables.TablesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a list of tables for given database
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Database.Item.Tables.TablesRequestBuilder.TablesRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Database.Item.Tables.TablesRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Database.Item.Tables.TablesRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Database.Item.Tables.TablesRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Get a list of tables for given database
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class TablesRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class TablesRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Database.Item.Tables.TablesRequestBuilder.TablesRequestBuilderGetQueryParameters>
    {
    }
}
