
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Saved_query.Related.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\saved_query\related\{column_name}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithColumn_nameItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Saved_query.Related.Item.WithColumn_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithColumn_nameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/saved_query/related/{column_name}{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Saved_query.Related.Item.WithColumn_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithColumn_nameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/saved_query/related/{column_name}{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Get related fields data
    /// </summary>
    /// <returns>A <see cref="KClient.Models.RelatedResponseSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.RelatedResponseSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.RelatedResponseSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.RelatedResponseSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.RelatedResponseSchema500Error">When receiving a 500 status code</exception>
    public async Task<KClient.Models.RelatedResponseSchema> GetAsync(Action<RequestConfiguration<Saved_query.Related.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.RelatedResponseSchema400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.RelatedResponseSchema401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.RelatedResponseSchema404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.RelatedResponseSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KClient.Models.RelatedResponseSchema>(requestInfo, KClient.Models.RelatedResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get related fields data
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Saved_query.Related.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Saved_query.Related.Item.WithColumn_nameItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Saved_query.Related.Item.WithColumn_nameItemRequestBuilder WithUrl(string rawUrl)
    {
        return new Saved_query.Related.Item.WithColumn_nameItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Get related fields data
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
    public partial class WithColumn_nameItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Saved_query.Related.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>
    {
    }
}
