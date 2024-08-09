
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Query.Distinct.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\query\distinct\{column_name}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithColumn_nameItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Query.Distinct.Item.WithColumn_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithColumn_nameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/query/distinct/{column_name}{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Query.Distinct.Item.WithColumn_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithColumn_nameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/query/distinct/{column_name}{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Get distinct values from field data
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DistincResponseSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.DistincResponseSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.DistincResponseSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.DistincResponseSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.DistincResponseSchema500Error">When receiving a 500 status code</exception>
    public async Task<KClient.Models.DistincResponseSchema> GetAsync(Action<RequestConfiguration<Query.Distinct.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.DistincResponseSchema400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.DistincResponseSchema401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.DistincResponseSchema404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.DistincResponseSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KClient.Models.DistincResponseSchema>(requestInfo, KClient.Models.DistincResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get distinct values from field data
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Query.Distinct.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Query.Distinct.Item.WithColumn_nameItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Query.Distinct.Item.WithColumn_nameItemRequestBuilder WithUrl(string rawUrl)
    {
        return new Query.Distinct.Item.WithColumn_nameItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Get distinct values from field data
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithColumn_nameItemRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithColumn_nameItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Query.Distinct.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>
    {
    }
}
