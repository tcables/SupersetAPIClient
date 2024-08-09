
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.AnnotationLayer.Item.Annotation.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\annotation_layer\{pk}\annotation\{annotation_id}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithAnnotation_ItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithAnnotation_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/annotation_layer/{pk}/annotation/{annotation_id}{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithAnnotation_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/annotation_layer/{pk}/annotation/{annotation_id}{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Delete annotation layer
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Item.Annotation.Item.WithAnnotation_DeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithAnnotation_404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithAnnotation_422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithAnnotation_500Error">When receiving a 500 status code</exception>
    public async Task<AnnotationLayer.Item.Annotation.Item.WithAnnotation_DeleteResponse> DeleteAsWithAnnotation_DeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "404", Models.WithAnnotation_404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithAnnotation_422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithAnnotation_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<AnnotationLayer.Item.Annotation.Item.WithAnnotation_DeleteResponse>(requestInfo, AnnotationLayer.Item.Annotation.Item.WithAnnotation_DeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete annotation layer
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithAnnotation_404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithAnnotation_422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithAnnotation_500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsWithAnnotation_DeleteResponseAsync instead.")]
    public async Task<AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "404", Models.WithAnnotation_404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithAnnotation_422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithAnnotation_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response>(requestInfo, AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an annotation layer
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Item.Annotation.Item.WithAnnotation_GetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithAnnotation_400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithAnnotation_401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithAnnotation_404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithAnnotation_422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithAnnotation_500Error">When receiving a 500 status code</exception>
    public async Task<AnnotationLayer.Item.Annotation.Item.WithAnnotation_GetResponse> GetWithAnnotation_GetResponseAsync(Action<RequestConfiguration<AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder.WithAnnotation_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithAnnotation_400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithAnnotation_401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithAnnotation_404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithAnnotation_422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithAnnotation_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<AnnotationLayer.Item.Annotation.Item.WithAnnotation_GetResponse>(requestInfo, AnnotationLayer.Item.Annotation.Item.WithAnnotation_GetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an annotation layer
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithAnnotation_400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithAnnotation_401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithAnnotation_404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithAnnotation_422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithAnnotation_500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithAnnotation_GetResponseAsync instead.")]
    public async Task<AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response> GetAsync(Action<RequestConfiguration<AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder.WithAnnotation_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithAnnotation_400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithAnnotation_401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithAnnotation_404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithAnnotation_422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithAnnotation_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response>(requestInfo, AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update an annotation layer
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Item.Annotation.Item.WithAnnotation_PutResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithAnnotation_400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithAnnotation_401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithAnnotation_404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithAnnotation_500Error">When receiving a 500 status code</exception>
    public async Task<AnnotationLayer.Item.Annotation.Item.WithAnnotation_PutResponse> PutAsWithAnnotation_PutResponseAsync(Models.AnnotationRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithAnnotation_400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithAnnotation_401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithAnnotation_404Error.CreateFromDiscriminatorValue },
            { "500", Models.WithAnnotation_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<AnnotationLayer.Item.Annotation.Item.WithAnnotation_PutResponse>(requestInfo, AnnotationLayer.Item.Annotation.Item.WithAnnotation_PutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update an annotation layer
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithAnnotation_400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithAnnotation_401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithAnnotation_404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithAnnotation_500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PutAsWithAnnotation_PutResponseAsync instead.")]
    public async Task<AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response> PutAsync(Models.AnnotationRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithAnnotation_400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithAnnotation_401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithAnnotation_404Error.CreateFromDiscriminatorValue },
            { "500", Models.WithAnnotation_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response>(requestInfo, AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete annotation layer
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Get an annotation layer
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder.WithAnnotation_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Update an annotation layer
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPutRequestInformation(Models.AnnotationRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder WithUrl(string rawUrl)
    {
        return new AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithAnnotation_ItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Get an annotation layer
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithAnnotation_ItemRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithAnnotation_ItemRequestBuilderGetRequestConfiguration : RequestConfiguration<AnnotationLayer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder.WithAnnotation_ItemRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithAnnotation_ItemRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
