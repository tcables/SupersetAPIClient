
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Tag;

/// <summary>
/// Builds and executes requests for operations under \api\v1\tag
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class TagRequestBuilder : BaseRequestBuilder
{
    /// <summary>The _info property</summary>
    public Tag._info._infoRequestBuilder _info
    {
        get => new Tag._info._infoRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The bulk_create property</summary>
    public Tag.Bulk_create.Bulk_createRequestBuilder Bulk_create
    {
        get => new Tag.Bulk_create.Bulk_createRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The favorite_status property</summary>
    public Tag.Favorite_status.Favorite_statusRequestBuilder Favorite_status
    {
        get => new Tag.Favorite_status.Favorite_statusRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The get_objects property</summary>
    public Tag.Get_objects.Get_objectsRequestBuilder Get_objects
    {
        get => new Tag.Get_objects.Get_objectsRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related property</summary>
    public Tag.Related.RelatedRequestBuilder Related
    {
        get => new Tag.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.tag.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="Tag.Item.Object_typeItemRequestBuilder"/></returns>
    public Tag.Item.Object_typeItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("object_type%2Did", position);
            return new Tag.Item.Object_typeItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.tag.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="Tag.Item.Object_typeItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public Tag.Item.Object_typeItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("object_type%2Did", position);
            return new Tag.Item.Object_typeItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Tag.TagRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public TagRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Tag.TagRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public TagRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Bulk deletes tags. This will remove all tagged objects with this tag.
    /// </summary>
    /// <returns>A <see cref="Tag.TagDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Tag401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Tag403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Tag404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Tag422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Tag500Error">When receiving a 500 status code</exception>
    public async Task<Tag.TagDeleteResponse> DeleteAsTagDeleteResponseAsync(Action<RequestConfiguration<Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Tag401Error.CreateFromDiscriminatorValue },
            { "403", Models.Tag403Error.CreateFromDiscriminatorValue },
            { "404", Models.Tag404Error.CreateFromDiscriminatorValue },
            { "422", Models.Tag422Error.CreateFromDiscriminatorValue },
            { "500", Models.Tag500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Tag.TagDeleteResponse>(requestInfo, Tag.TagDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk deletes tags. This will remove all tagged objects with this tag.
    /// </summary>
    /// <returns>A <see cref="Tag.TagResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Tag401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Tag403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Tag404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Tag422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Tag500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsTagDeleteResponseAsync instead.")]
    public async Task<Tag.TagResponse> DeleteAsync(Action<RequestConfiguration<Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.Tag401Error.CreateFromDiscriminatorValue },
            { "403", Models.Tag403Error.CreateFromDiscriminatorValue },
            { "404", Models.Tag404Error.CreateFromDiscriminatorValue },
            { "422", Models.Tag422Error.CreateFromDiscriminatorValue },
            { "500", Models.Tag500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Tag.TagResponse>(requestInfo, Tag.TagResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a list of tags, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="Tag.TagGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Tag400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Tag401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Tag422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Tag500Error">When receiving a 500 status code</exception>
    public async Task<Tag.TagGetResponse> GetTagGetResponseAsync(Action<RequestConfiguration<Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Tag400Error.CreateFromDiscriminatorValue },
            { "401", Models.Tag401Error.CreateFromDiscriminatorValue },
            { "422", Models.Tag422Error.CreateFromDiscriminatorValue },
            { "500", Models.Tag500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Tag.TagGetResponse>(requestInfo, Tag.TagGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a list of tags, use Rison or JSON query parameters for filtering, sorting, pagination and  for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="Tag.TagResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Tag400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Tag401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Tag422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Tag500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsTagGetResponseAsync instead.")]
    public async Task<Tag.TagResponse> GetAsync(Action<RequestConfiguration<Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Tag400Error.CreateFromDiscriminatorValue },
            { "401", Models.Tag401Error.CreateFromDiscriminatorValue },
            { "422", Models.Tag422Error.CreateFromDiscriminatorValue },
            { "500", Models.Tag500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Tag.TagResponse>(requestInfo, Tag.TagResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new Tag
    /// </summary>
    /// <returns>A <see cref="Tag.TagPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Tag400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Tag401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Tag422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Tag500Error">When receiving a 500 status code</exception>
    public async Task<Tag.TagPostResponse> PostAsTagPostResponseAsync(Models.TagRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Tag400Error.CreateFromDiscriminatorValue },
            { "401", Models.Tag401Error.CreateFromDiscriminatorValue },
            { "422", Models.Tag422Error.CreateFromDiscriminatorValue },
            { "500", Models.Tag500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Tag.TagPostResponse>(requestInfo, Tag.TagPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new Tag
    /// </summary>
    /// <returns>A <see cref="Tag.TagResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Tag400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Tag401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Tag422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Tag500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsTagPostResponseAsync instead.")]
    public async Task<Tag.TagResponse> PostAsync(Models.TagRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Tag400Error.CreateFromDiscriminatorValue },
            { "401", Models.Tag401Error.CreateFromDiscriminatorValue },
            { "422", Models.Tag422Error.CreateFromDiscriminatorValue },
            { "500", Models.Tag500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Tag.TagResponse>(requestInfo, Tag.TagResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk deletes tags. This will remove all tagged objects with this tag.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
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
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
    public RequestInformation ToPostRequestInformation(Models.TagRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Tag.TagRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Tag.TagRequestBuilder WithUrl(string rawUrl)
    {
        return new Tag.TagRequestBuilder(rawUrl, RequestAdapter);
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
    public partial class TagRequestBuilderDeleteRequestConfiguration : RequestConfiguration<Tag.TagRequestBuilder.TagRequestBuilderDeleteQueryParameters>
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
    public partial class TagRequestBuilderGetRequestConfiguration : RequestConfiguration<Tag.TagRequestBuilder.TagRequestBuilderGetQueryParameters>
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
