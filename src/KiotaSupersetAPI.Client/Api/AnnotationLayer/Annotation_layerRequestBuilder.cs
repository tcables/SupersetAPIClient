
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.AnnotationLayer;

/// <summary>
/// Builds and executes requests for operations under \api\v1\annotation_layer
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Annotation_layerRequestBuilder : BaseRequestBuilder
{
    /// <summary>The _info property</summary>
    public _info._infoRequestBuilder _info
    {
        get => new _info._infoRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related property</summary>
    public Related.RelatedRequestBuilder Related
    {
        get => new Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.AnnotationLayer.item collection</summary>
    /// <param name="position">The annotation layer pk for this annotation</param>
    /// <returns>A <see cref="AnnotationLayer.Item.WithPkItemRequestBuilder"/></returns>
    public Item.WithPkItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("pk", position);
            return new Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.AnnotationLayer.item collection</summary>
    /// <param name="position">The annotation layer pk for this annotation</param>
    /// <returns>A <see cref="AnnotationLayer.Item.WithPkItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public Item.WithPkItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("pk", position);
            return new Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="AnnotationLayer.Annotation_layerRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Annotation_layerRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/annotation_layer{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="AnnotationLayer.Annotation_layerRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Annotation_layerRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/annotation_layer{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Delete multiple annotation layers in a bulk operation
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Annotation_layerDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Annotation_layer401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Annotation_layer404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Annotation_layer422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Annotation_layer500Error">When receiving a 500 status code</exception>
    public async Task<AnnotationLayer.Annotation_layerDeleteResponse> DeleteAsAnnotation_layerDeleteResponseAsync(Action<RequestConfiguration<AnnotationLayer.Annotation_layerRequestBuilder.Annotation_layerRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Annotation_layer401Error.CreateFromDiscriminatorValue },
            { "404", Models.Annotation_layer404Error.CreateFromDiscriminatorValue },
            { "422", Models.Annotation_layer422Error.CreateFromDiscriminatorValue },
            { "500", Models.Annotation_layer500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<AnnotationLayer.Annotation_layerDeleteResponse>(requestInfo, AnnotationLayer.Annotation_layerDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete multiple annotation layers in a bulk operation
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Annotation_layerResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Annotation_layer401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Annotation_layer404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Annotation_layer422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Annotation_layer500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsAnnotation_layerDeleteResponseAsync instead.")]
    public async Task<AnnotationLayer.Annotation_layerResponse> DeleteAsync(Action<RequestConfiguration<AnnotationLayer.Annotation_layerRequestBuilder.Annotation_layerRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Annotation_layer401Error.CreateFromDiscriminatorValue },
            { "404", Models.Annotation_layer404Error.CreateFromDiscriminatorValue },
            { "422", Models.Annotation_layer422Error.CreateFromDiscriminatorValue },
            { "500", Models.Annotation_layer500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<AnnotationLayer.Annotation_layerResponse>(requestInfo, AnnotationLayer.Annotation_layerResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of annotation layers, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Annotation_layerGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Annotation_layer400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Annotation_layer401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Annotation_layer422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Annotation_layer500Error">When receiving a 500 status code</exception>
    public async Task<AnnotationLayer.Annotation_layerGetResponse> GetAnnotation_layerGetResponseAsync(Action<RequestConfiguration<AnnotationLayer.Annotation_layerRequestBuilder.Annotation_layerRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Annotation_layer400Error.CreateFromDiscriminatorValue },
            { "401", Models.Annotation_layer401Error.CreateFromDiscriminatorValue },
            { "422", Models.Annotation_layer422Error.CreateFromDiscriminatorValue },
            { "500", Models.Annotation_layer500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<AnnotationLayer.Annotation_layerGetResponse>(requestInfo, AnnotationLayer.Annotation_layerGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of annotation layers, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Annotation_layerResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Annotation_layer400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Annotation_layer401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Annotation_layer422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Annotation_layer500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsAnnotation_layerGetResponseAsync instead.")]
    public async Task<AnnotationLayer.Annotation_layerResponse> GetAsync(Action<RequestConfiguration<AnnotationLayer.Annotation_layerRequestBuilder.Annotation_layerRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Annotation_layer400Error.CreateFromDiscriminatorValue },
            { "401", Models.Annotation_layer401Error.CreateFromDiscriminatorValue },
            { "422", Models.Annotation_layer422Error.CreateFromDiscriminatorValue },
            { "500", Models.Annotation_layer500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<AnnotationLayer.Annotation_layerResponse>(requestInfo, AnnotationLayer.Annotation_layerResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create an annotation layer
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Annotation_layerPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Annotation_layer400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Annotation_layer401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Annotation_layer404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Annotation_layer500Error">When receiving a 500 status code</exception>
    public async Task<AnnotationLayer.Annotation_layerPostResponse> PostAsAnnotation_layerPostResponseAsync(Models.AnnotationLayerRestAPI.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Annotation_layer400Error.CreateFromDiscriminatorValue },
            { "401", Models.Annotation_layer401Error.CreateFromDiscriminatorValue },
            { "404", Models.Annotation_layer404Error.CreateFromDiscriminatorValue },
            { "500", Models.Annotation_layer500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<AnnotationLayer.Annotation_layerPostResponse>(requestInfo, AnnotationLayer.Annotation_layerPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create an annotation layer
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Annotation_layerResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Annotation_layer400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Annotation_layer401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Annotation_layer404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Annotation_layer500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsAnnotation_layerPostResponseAsync instead.")]
    public async Task<AnnotationLayer.Annotation_layerResponse> PostAsync(Models.AnnotationLayerRestAPI.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Annotation_layer400Error.CreateFromDiscriminatorValue },
            { "401", Models.Annotation_layer401Error.CreateFromDiscriminatorValue },
            { "404", Models.Annotation_layer404Error.CreateFromDiscriminatorValue },
            { "500", Models.Annotation_layer500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<AnnotationLayer.Annotation_layerResponse>(requestInfo, AnnotationLayer.Annotation_layerResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete multiple annotation layers in a bulk operation
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<AnnotationLayer.Annotation_layerRequestBuilder.Annotation_layerRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Gets a list of annotation layers, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AnnotationLayer.Annotation_layerRequestBuilder.Annotation_layerRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Create an annotation layer
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Models.AnnotationLayerRestAPI.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Annotation_layerRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Annotation_layerRequestBuilder WithUrl(string rawUrl)
    {
        return new Annotation_layerRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Delete multiple annotation layers in a bulk operation
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Annotation_layerRequestBuilderDeleteQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Annotation_layerRequestBuilderDeleteRequestConfiguration : RequestConfiguration<AnnotationLayer.Annotation_layerRequestBuilder.Annotation_layerRequestBuilderDeleteQueryParameters>
    {
    }
    /// <summary>
    /// Gets a list of annotation layers, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Annotation_layerRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Annotation_layerRequestBuilderGetRequestConfiguration : RequestConfiguration<AnnotationLayer.Annotation_layerRequestBuilder.Annotation_layerRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Annotation_layerRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
