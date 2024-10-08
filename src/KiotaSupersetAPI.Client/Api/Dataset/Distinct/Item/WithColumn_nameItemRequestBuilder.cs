
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dataset.Distinct.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dataset\distinct\{column_name}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithColumn_nameItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Dataset.Distinct.Item.WithColumn_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithColumn_nameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/distinct/{column_name}{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dataset.Distinct.Item.WithColumn_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithColumn_nameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/distinct/{column_name}{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Get distinct values from field data
    /// </summary>
    /// <returns>A <see cref="Models.DistincResponseSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.DistincResponseSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.DistincResponseSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.DistincResponseSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.DistincResponseSchema500Error">When receiving a 500 status code</exception>
    public async Task<Models.DistincResponseSchema> GetAsync(Action<RequestConfiguration<Dataset.Distinct.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.DistincResponseSchema400Error.CreateFromDiscriminatorValue },
            { "401", Models.DistincResponseSchema401Error.CreateFromDiscriminatorValue },
            { "404", Models.DistincResponseSchema404Error.CreateFromDiscriminatorValue },
            { "500", Models.DistincResponseSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Models.DistincResponseSchema>(requestInfo, Models.DistincResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get distinct values from field data
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Dataset.Distinct.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Dataset.Distinct.Item.WithColumn_nameItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Item.WithColumn_nameItemRequestBuilder WithUrl(string rawUrl)
    {
        return new Distinct.Item.WithColumn_nameItemRequestBuilder(rawUrl, RequestAdapter);
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
    public partial class WithColumn_nameItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Dataset.Distinct.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>
    {
    }
}
