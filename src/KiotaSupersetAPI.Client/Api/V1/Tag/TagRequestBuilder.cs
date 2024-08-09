
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Tag;

/// <summary>
/// Builds and executes requests for operations under \api\v1\tag
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class TagRequestBuilder : BaseRequestBuilder
{
    /// <summary>The _info property</summary>
    public KApi.Tag._info._infoRequestBuilder _info
    {
        get => new KApi.Tag._info._infoRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The bulk_create property</summary>
    public KApi.Tag.Bulk_create.Bulk_createRequestBuilder Bulk_create
    {
        get => new KApi.Tag.Bulk_create.Bulk_createRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The favorite_status property</summary>
    public KApi.Tag.Favorite_status.Favorite_statusRequestBuilder Favorite_status
    {
        get => new KApi.Tag.Favorite_status.Favorite_statusRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The get_objects property</summary>
    public KApi.Tag.Get_objects.Get_objectsRequestBuilder Get_objects
    {
        get => new KApi.Tag.Get_objects.Get_objectsRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related property</summary>
    public KApi.Tag.Related.RelatedRequestBuilder Related
    {
        get => new KApi.Tag.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.tag.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Tag.Item.Object_typeItemRequestBuilder"/></returns>
    public KApi.Tag.Item.Object_typeItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("object_type%2Did", position);
            return new KApi.Tag.Item.Object_typeItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.tag.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Tag.Item.Object_typeItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public KApi.Tag.Item.Object_typeItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("object_type%2Did", position);
            return new KApi.Tag.Item.Object_typeItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Tag.TagRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public TagRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Tag.TagRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public TagRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Bulk deletes tags. This will remove all tagged objects with this tag.
    /// </summary>
    /// <returns>A <see cref="KApi.Tag.TagDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Tag401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Tag403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Tag404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Tag422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Tag500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Tag.TagDeleteResponse> DeleteAsTagDeleteResponseAsync(Action<RequestConfiguration<KApi.Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Tag401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Tag403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Tag404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Tag422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Tag500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Tag.TagDeleteResponse>(requestInfo, KApi.Tag.TagDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk deletes tags. This will remove all tagged objects with this tag.
    /// </summary>
    /// <returns>A <see cref="KApi.Tag.TagResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Tag401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Tag403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Tag404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Tag422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Tag500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsTagDeleteResponseAsync instead.")]
    public async Task<KApi.Tag.TagResponse> DeleteAsync(Action<RequestConfiguration<KApi.Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Tag401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Tag403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Tag404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Tag422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Tag500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Tag.TagResponse>(requestInfo, KApi.Tag.TagResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a list of tags, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Tag.TagGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Tag400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Tag401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Tag422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Tag500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Tag.TagGetResponse> GetAsTagGetResponseAsync(Action<RequestConfiguration<KApi.Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Tag400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Tag401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Tag422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Tag500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Tag.TagGetResponse>(requestInfo, KApi.Tag.TagGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a list of tags, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Tag.TagResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Tag400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Tag401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Tag422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Tag500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsTagGetResponseAsync instead.")]
    public async Task<KApi.Tag.TagResponse> GetAsync(Action<RequestConfiguration<KApi.Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Tag400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Tag401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Tag422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Tag500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Tag.TagResponse>(requestInfo, KApi.Tag.TagResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new Tag
    /// </summary>
    /// <returns>A <see cref="KApi.Tag.TagPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Tag400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Tag401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Tag422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Tag500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Tag.TagPostResponse> PostAsTagPostResponseAsync(KClient.Models.TagRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Tag400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Tag401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Tag422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Tag500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Tag.TagPostResponse>(requestInfo, KApi.Tag.TagPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new Tag
    /// </summary>
    /// <returns>A <see cref="KApi.Tag.TagResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Tag400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Tag401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Tag422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Tag500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsTagPostResponseAsync instead.")]
    public async Task<KApi.Tag.TagResponse> PostAsync(KClient.Models.TagRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Tag400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Tag401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Tag422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Tag500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Tag.TagResponse>(requestInfo, KApi.Tag.TagResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk deletes tags. This will remove all tagged objects with this tag.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<KApi.Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Get a list of tags, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Create a new Tag
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(KClient.Models.TagRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="KApi.Tag.TagRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Tag.TagRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Tag.TagRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Bulk deletes tags. This will remove all tagged objects with this tag.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class TagRequestBuilderDeleteQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class TagRequestBuilderDeleteRequestConfiguration : RequestConfiguration<KApi.Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>
    {
    }
    /// <summary>
    /// Get a list of tags, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class TagRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class TagRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class TagRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
