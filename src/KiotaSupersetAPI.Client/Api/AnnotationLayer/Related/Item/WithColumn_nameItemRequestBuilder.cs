
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.AnnotationLayer.Related.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\annotation_layer\related\{column_name}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithColumn_nameItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="AnnotationLayer.Related.Item.WithColumn_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithColumn_nameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/annotation_layer/related/{column_name}{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="AnnotationLayer.Related.Item.WithColumn_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithColumn_nameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/annotation_layer/related/{column_name}{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Get related fields data
    /// </summary>
    /// <returns>A <see cref="Models.RelatedResponseSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.RelatedResponseSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.RelatedResponseSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.RelatedResponseSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.RelatedResponseSchema500Error">When receiving a 500 status code</exception>
    public async Task<Models.RelatedResponseSchema> GetAsync(Action<RequestConfiguration<AnnotationLayer.Related.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.RelatedResponseSchema400Error.CreateFromDiscriminatorValue },
            { "401", Models.RelatedResponseSchema401Error.CreateFromDiscriminatorValue },
            { "404", Models.RelatedResponseSchema404Error.CreateFromDiscriminatorValue },
            { "500", Models.RelatedResponseSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Models.RelatedResponseSchema>(requestInfo, Models.RelatedResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get related fields data
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AnnotationLayer.Related.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Related.Item.WithColumn_nameItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public AnnotationLayer.Related.Item.WithColumn_nameItemRequestBuilder WithUrl(string rawUrl)
    {
        return new AnnotationLayer.Related.Item.WithColumn_nameItemRequestBuilder(rawUrl, RequestAdapter);
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
    public partial class WithColumn_nameItemRequestBuilderGetRequestConfiguration : RequestConfiguration<AnnotationLayer.Related.Item.WithColumn_nameItemRequestBuilder.WithColumn_nameItemRequestBuilderGetQueryParameters>
    {
    }
}
