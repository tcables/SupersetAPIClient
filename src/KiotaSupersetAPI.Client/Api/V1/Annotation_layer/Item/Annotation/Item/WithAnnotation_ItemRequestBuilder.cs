
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KiotaSupersetAPI.Client.Models;
using KiotaSupersetAPI.Client.Models.AnnotationRestApi;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Annotation_layer.Item.Annotation.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\annotation_layer\{pk}\annotation\{annotation_id}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithAnnotation_ItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithAnnotation_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/annotation_layer/{pk}/annotation/{annotation_id}{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithAnnotation_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/annotation_layer/{pk}/annotation/{annotation_id}{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Delete annotation layer
    /// </summary>
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_DeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithAnnotation_404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_DeleteResponse?> DeleteAsWithAnnotation_DeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_DeleteResponse> DeleteAsWithAnnotation_DeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "404", KClient.Models.WithAnnotation_404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithAnnotation_422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithAnnotation_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_DeleteResponse>(requestInfo, KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_DeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete annotation layer
    /// </summary>
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithAnnotation_404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsWithAnnotation_DeleteResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "404", KClient.Models.WithAnnotation_404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithAnnotation_422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithAnnotation_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response>(requestInfo, KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an annotation layer
    /// </summary>
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_GetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithAnnotation_400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_GetResponse?> GetAsWithAnnotation_GetResponseAsync(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder.WithAnnotation_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_GetResponse> GetAsWithAnnotation_GetResponseAsync(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder.WithAnnotation_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithAnnotation_400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithAnnotation_401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithAnnotation_404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithAnnotation_422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithAnnotation_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_GetResponse>(requestInfo, KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_GetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an annotation layer
    /// </summary>
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithAnnotation_400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithAnnotation_GetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response?> GetAsync(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder.WithAnnotation_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response> GetAsync(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder.WithAnnotation_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithAnnotation_400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithAnnotation_401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithAnnotation_404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithAnnotation_422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithAnnotation_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response>(requestInfo, KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update an annotation layer
    /// </summary>
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_PutResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithAnnotation_400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_PutResponse?> PutAsWithAnnotation_PutResponseAsync(KClient.Models.AnnotationRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_PutResponse> PutAsWithAnnotation_PutResponseAsync(KClient.Models.AnnotationRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithAnnotation_400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithAnnotation_401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithAnnotation_404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithAnnotation_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_PutResponse>(requestInfo, KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_PutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update an annotation layer
    /// </summary>
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithAnnotation_400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithAnnotation_500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PutAsWithAnnotation_PutResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response?> PutAsync(KClient.Models.AnnotationRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response> PutAsync(KClient.Models.AnnotationRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithAnnotation_400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithAnnotation_401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithAnnotation_404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithAnnotation_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response>(requestInfo, KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_Response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete annotation layer
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {
#endif
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder.WithAnnotation_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder.WithAnnotation_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {
#endif
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPutRequestInformation(KClient.Models.AnnotationRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToPutRequestInformation(KClient.Models.AnnotationRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {
#endif
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
    /// <returns>A <see cref="KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder(rawUrl, RequestAdapter);
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
    public partial class WithAnnotation_ItemRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Annotation_layer.Item.Annotation.Item.WithAnnotation_ItemRequestBuilder.WithAnnotation_ItemRequestBuilderGetQueryParameters>
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
