
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KiotaSupersetAPI.Client.Api.V1.Database.Item.Select_star.Item.Item;
using KiotaSupersetAPI.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Database.Item.Select_star.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\{pk}\select_star\{table_name}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithTable_nameItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.database.item.select_star.item.item collection</summary>
    /// <param name="position">Table schema</param>
    /// <returns>A <see cref="KApi.Database.Item.Select_star.Item.Item.WithSchema_nameItemRequestBuilder"/></returns>
    public KApi.Database.Item.Select_star.Item.Item.WithSchema_nameItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("schema_name", position);
            return new KApi.Database.Item.Select_star.Item.Item.WithSchema_nameItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Database.Item.Select_star.Item.WithTable_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithTable_nameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/select_star/{table_name}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Database.Item.Select_star.Item.WithTable_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithTable_nameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/select_star/{table_name}", rawUrl)
    {
    }
    /// <summary>
    /// Get database select star for table
    /// </summary>
    /// <returns>A <see cref="KClient.Models.SelectStarResponseSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.SelectStarResponseSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.SelectStarResponseSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.SelectStarResponseSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.SelectStarResponseSchema422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.SelectStarResponseSchema500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KClient.Models.SelectStarResponseSchema?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KClient.Models.SelectStarResponseSchema> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.SelectStarResponseSchema400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.SelectStarResponseSchema401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.SelectStarResponseSchema404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.SelectStarResponseSchema422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.SelectStarResponseSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KClient.Models.SelectStarResponseSchema>(requestInfo, KClient.Models.SelectStarResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get database select star for table
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="KApi.Database.Item.Select_star.Item.WithTable_nameItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Database.Item.Select_star.Item.WithTable_nameItemRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Database.Item.Select_star.Item.WithTable_nameItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithTable_nameItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
