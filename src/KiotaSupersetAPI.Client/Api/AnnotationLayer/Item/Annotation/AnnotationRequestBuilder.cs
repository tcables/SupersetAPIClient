
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.AnnotationLayer.Item.Annotation;

/// <summary>
/// Builds and executes requests for operations under \api\v1\annotation_layer\{pk}\annotation
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class AnnotationRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.AnnotationLayer.item.annotation.item collection</summary>
    /// <param name="position">The annotation pk for this annotation</param>
    /// <returns>A <see cref="KApi.AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder"/></returns>
    public KApi.AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("annotation_id", position);
            return new KApi.AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.AnnotationLayer.item.annotation.item collection</summary>
    /// <param name="position">The annotation pk for this annotation</param>
    /// <returns>A <see cref="KApi.AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public KApi.AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("annotation_id", position);
            return new KApi.AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.AnnotationLayer.Item.Annotation.AnnotationRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public AnnotationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/annotation_layer/{pk}/annotation{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.AnnotationLayer.Item.Annotation.AnnotationRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public AnnotationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/annotation_layer/{pk}/annotation{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Bulk delete annotation layers
    /// </summary>
    /// <returns>A <see cref="KApi.AnnotationLayer.Item.Annotation.AnnotationDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Annotation401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Annotation404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Annotation422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Annotation500Error">When receiving a 500 status code</exception>
    public async Task<KApi.AnnotationLayer.Item.Annotation.AnnotationDeleteResponse> DeleteAsAnnotationDeleteResponseAsync(Action<RequestConfiguration<KApi.AnnotationLayer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Annotation401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Annotation404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Annotation422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Annotation500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.AnnotationLayer.Item.Annotation.AnnotationDeleteResponse>(requestInfo, KApi.AnnotationLayer.Item.Annotation.AnnotationDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete annotation layers
    /// </summary>
    /// <returns>A <see cref="KApi.AnnotationLayer.Item.Annotation.AnnotationResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Annotation401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Annotation404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Annotation422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Annotation500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsAnnotationDeleteResponseAsync instead.")]
    public async Task<KApi.AnnotationLayer.Item.Annotation.AnnotationResponse> DeleteAsync(Action<RequestConfiguration<KApi.AnnotationLayer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Annotation401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Annotation404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Annotation422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Annotation500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.AnnotationLayer.Item.Annotation.AnnotationResponse>(requestInfo, KApi.AnnotationLayer.Item.Annotation.AnnotationResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of annotation layers, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.AnnotationLayer.Item.Annotation.AnnotationGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Annotation400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Annotation401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Annotation422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Annotation500Error">When receiving a 500 status code</exception>
    public async Task<KApi.AnnotationLayer.Item.Annotation.AnnotationGetResponse> GetAsAnnotationGetResponseAsync(Action<RequestConfiguration<KApi.AnnotationLayer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Annotation400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Annotation401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Annotation422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Annotation500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.AnnotationLayer.Item.Annotation.AnnotationGetResponse>(requestInfo, KApi.AnnotationLayer.Item.Annotation.AnnotationGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of annotation layers, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.AnnotationLayer.Item.Annotation.AnnotationResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Annotation400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Annotation401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Annotation422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Annotation500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsAnnotationGetResponseAsync instead.")]
    public async Task<KApi.AnnotationLayer.Item.Annotation.AnnotationResponse> GetAsync(Action<RequestConfiguration<KApi.AnnotationLayer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Annotation400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Annotation401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Annotation422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Annotation500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.AnnotationLayer.Item.Annotation.AnnotationResponse>(requestInfo, KApi.AnnotationLayer.Item.Annotation.AnnotationResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create an annotation layer
    /// </summary>
    /// <returns>A <see cref="KApi.AnnotationLayer.Item.Annotation.AnnotationPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Annotation400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Annotation401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Annotation404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Annotation500Error">When receiving a 500 status code</exception>
    public async Task<KApi.AnnotationLayer.Item.Annotation.AnnotationPostResponse> PostAsAnnotationPostResponseAsync(KClient.Models.AnnotationRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Annotation400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Annotation401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Annotation404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Annotation500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.AnnotationLayer.Item.Annotation.AnnotationPostResponse>(requestInfo, KApi.AnnotationLayer.Item.Annotation.AnnotationPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create an annotation layer
    /// </summary>
    /// <returns>A <see cref="KApi.AnnotationLayer.Item.Annotation.AnnotationResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Annotation400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Annotation401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Annotation404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Annotation500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsAnnotationPostResponseAsync instead.")]
    public async Task<KApi.AnnotationLayer.Item.Annotation.AnnotationResponse> PostAsync(KClient.Models.AnnotationRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Annotation400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Annotation401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Annotation404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Annotation500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.AnnotationLayer.Item.Annotation.AnnotationResponse>(requestInfo, KApi.AnnotationLayer.Item.Annotation.AnnotationResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete annotation layers
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<KApi.AnnotationLayer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
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
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.AnnotationLayer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
    public RequestInformation ToPostRequestInformation(KClient.Models.AnnotationRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="KApi.AnnotationLayer.Item.Annotation.AnnotationRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.AnnotationLayer.Item.Annotation.AnnotationRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.AnnotationLayer.Item.Annotation.AnnotationRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Bulk delete annotation layers
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class AnnotationRequestBuilderDeleteQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class AnnotationRequestBuilderDeleteRequestConfiguration : RequestConfiguration<KApi.AnnotationLayer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderDeleteQueryParameters>
    {
    }
    /// <summary>
    /// Gets a list of annotation layers, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class AnnotationRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class AnnotationRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.AnnotationLayer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class AnnotationRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
