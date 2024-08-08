
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KiotaSupersetAPI.Client.Api.V1.Annotation_layer.Item.Annotation.Item;
using KiotaSupersetAPI.Client.Models;
using KiotaSupersetAPI.Client.Models.AnnotationRestApi;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Annotation_layer.Item.Annotation;

/// <summary>
/// Builds and executes requests for operations under \api\v1\annotation_layer\{pk}\annotation
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class AnnotationRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.annotation_layer.item.annotation.item collection</summary>
    /// <param name="position">The annotation pk for this annotation</param>
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder"/></returns>
    public KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("annotation_id", position);
            return new KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.annotation_layer.item.annotation.item collection</summary>
    /// <param name="position">The annotation pk for this annotation</param>
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("annotation_id", position);
            return new KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public AnnotationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/annotation_layer/{pk}/annotation{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public AnnotationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/annotation_layer/{pk}/annotation{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Bulk delete annotation layers
    /// </summary>
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.AnnotationDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Annotation401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Annotation404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Annotation422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Annotation500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Annotation_layer.Item.Annotation.AnnotationDeleteResponse?> DeleteAsAnnotationDeleteResponseAsync(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Annotation_layer.Item.Annotation.AnnotationDeleteResponse> DeleteAsAnnotationDeleteResponseAsync(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Annotation401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Annotation404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Annotation422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Annotation500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Annotation_layer.Item.Annotation.AnnotationDeleteResponse>(requestInfo, KApi.Annotation_layer.Item.Annotation.AnnotationDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete annotation layers
    /// </summary>
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.AnnotationResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Annotation401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Annotation404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Annotation422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Annotation500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsAnnotationDeleteResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Annotation_layer.Item.Annotation.AnnotationResponse?> DeleteAsync(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Annotation_layer.Item.Annotation.AnnotationResponse> DeleteAsync(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Annotation401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Annotation404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Annotation422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Annotation500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Annotation_layer.Item.Annotation.AnnotationResponse>(requestInfo, KApi.Annotation_layer.Item.Annotation.AnnotationResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of annotation layers, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.AnnotationGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Annotation400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Annotation401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Annotation422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Annotation500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Annotation_layer.Item.Annotation.AnnotationGetResponse?> GetAsAnnotationGetResponseAsync(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Annotation_layer.Item.Annotation.AnnotationGetResponse> GetAsAnnotationGetResponseAsync(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Annotation400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Annotation401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Annotation422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Annotation500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Annotation_layer.Item.Annotation.AnnotationGetResponse>(requestInfo, KApi.Annotation_layer.Item.Annotation.AnnotationGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of annotation layers, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.AnnotationResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Annotation400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Annotation401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Annotation422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Annotation500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsAnnotationGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Annotation_layer.Item.Annotation.AnnotationResponse?> GetAsync(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Annotation_layer.Item.Annotation.AnnotationResponse> GetAsync(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Annotation400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Annotation401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Annotation422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Annotation500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Annotation_layer.Item.Annotation.AnnotationResponse>(requestInfo, KApi.Annotation_layer.Item.Annotation.AnnotationResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create an annotation layer
    /// </summary>
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.AnnotationPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Annotation400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Annotation401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Annotation404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Annotation500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Annotation_layer.Item.Annotation.AnnotationPostResponse?> PostAsAnnotationPostResponseAsync(KClient.Models.AnnotationRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Annotation_layer.Item.Annotation.AnnotationPostResponse> PostAsAnnotationPostResponseAsync(KClient.Models.AnnotationRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Annotation400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Annotation401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Annotation404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Annotation500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Annotation_layer.Item.Annotation.AnnotationPostResponse>(requestInfo, KApi.Annotation_layer.Item.Annotation.AnnotationPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create an annotation layer
    /// </summary>
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.AnnotationResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Annotation400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Annotation401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Annotation404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Annotation500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsAnnotationPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Annotation_layer.Item.Annotation.AnnotationResponse?> PostAsync(KClient.Models.AnnotationRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Annotation_layer.Item.Annotation.AnnotationResponse> PostAsync(KClient.Models.AnnotationRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Annotation400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Annotation401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Annotation404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Annotation500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Annotation_layer.Item.Annotation.AnnotationResponse>(requestInfo, KApi.Annotation_layer.Item.Annotation.AnnotationResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete annotation layers
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
    {
#endif
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderGetQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {
#endif
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPostRequestInformation(KClient.Models.AnnotationRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToPostRequestInformation(KClient.Models.AnnotationRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {
#endif
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
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Bulk delete annotation layers
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class AnnotationRequestBuilderDeleteQueryParameters
    {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        [QueryParameter("q")]
        public string? Q { get; set; }
#nullable restore
#else
        [QueryParameter("q")]
        public string Q { get; set; }
#endif
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class AnnotationRequestBuilderDeleteRequestConfiguration : RequestConfiguration<KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderDeleteQueryParameters>
    {
    }
    /// <summary>
    /// Gets a list of annotation layers, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class AnnotationRequestBuilderGetQueryParameters
    {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        [QueryParameter("q")]
        public string? Q { get; set; }
#nullable restore
#else
        [QueryParameter("q")]
        public string Q { get; set; }
#endif
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class AnnotationRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Annotation_layer.Item.Annotation.AnnotationRequestBuilder.AnnotationRequestBuilderGetQueryParameters>
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
