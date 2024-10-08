
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Tag.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\tag\{object_type-id}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Object_typeItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>The favorites property</summary>
    public Favorites.FavoritesRequestBuilder Favorites
    {
        get => new Favorites.FavoritesRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.tag.item.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="Tag.Item.Item.WithObject_ItemRequestBuilder"/></returns>
    public Item.WithObject_ItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("object_id", position);
            return new Item.WithObject_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.tag.item.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="Tag.Item.Item.WithObject_ItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public Item.WithObject_ItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("object_id", position);
            return new Item.WithObject_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Tag.Item.Object_typeItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Object_typeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag/{object_type%2Did}{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Tag.Item.Object_typeItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Object_typeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag/{object_type%2Did}{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Delete a tag
    /// </summary>
    /// <returns>A <see cref="Tag.Item.Object_typeDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Object_type404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Object_type422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Object_type500Error">When receiving a 500 status code</exception>
    public async Task<Tag.Item.Object_typeDeleteResponse> DeleteAsObject_typeDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "404", Models.Object_type404Error.CreateFromDiscriminatorValue },
            { "422", Models.Object_type422Error.CreateFromDiscriminatorValue },
            { "500", Models.Object_type500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Tag.Item.Object_typeDeleteResponse>(requestInfo, Tag.Item.Object_typeDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a tag
    /// </summary>
    /// <returns>A <see cref="Tag.Item.Object_typeResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Object_type404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Object_type422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Object_type500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsObject_typeDeleteResponseAsync instead.")]
    public async Task<Tag.Item.Object_typeResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "404", Models.Object_type404Error.CreateFromDiscriminatorValue },
            { "422", Models.Object_type422Error.CreateFromDiscriminatorValue },
            { "500", Models.Object_type500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Tag.Item.Object_typeResponse>(requestInfo, Tag.Item.Object_typeResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="Tag.Item.Object_typeGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Object_type400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Object_type401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Object_type404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Object_type422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Object_type500Error">When receiving a 500 status code</exception>
    public async Task<Tag.Item.Object_typeGetResponse> GetObject_typeGetResponseAsync(Action<RequestConfiguration<Tag.Item.Object_typeItemRequestBuilder.Object_typeItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Object_type400Error.CreateFromDiscriminatorValue },
            { "401", Models.Object_type401Error.CreateFromDiscriminatorValue },
            { "404", Models.Object_type404Error.CreateFromDiscriminatorValue },
            { "422", Models.Object_type422Error.CreateFromDiscriminatorValue },
            { "500", Models.Object_type500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Tag.Item.Object_typeGetResponse>(requestInfo, Tag.Item.Object_typeGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="Tag.Item.Object_typeResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Object_type400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Object_type401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Object_type404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Object_type422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Object_type500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsObject_typeGetResponseAsync instead.")]
    public async Task<Tag.Item.Object_typeResponse> GetAsync(Action<RequestConfiguration<Tag.Item.Object_typeItemRequestBuilder.Object_typeItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Object_type400Error.CreateFromDiscriminatorValue },
            { "401", Models.Object_type401Error.CreateFromDiscriminatorValue },
            { "404", Models.Object_type404Error.CreateFromDiscriminatorValue },
            { "422", Models.Object_type422Error.CreateFromDiscriminatorValue },
            { "500", Models.Object_type500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Tag.Item.Object_typeResponse>(requestInfo, Tag.Item.Object_typeResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Changes a Tag.
    /// </summary>
    /// <returns>A <see cref="Tag.Item.Object_typePutResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Object_type400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Object_type401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Object_type403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Object_type404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Object_type422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Object_type500Error">When receiving a 500 status code</exception>
    public async Task<Tag.Item.Object_typePutResponse> PutAsObject_typePutResponseAsync(Models.TagRestAPI.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Object_type400Error.CreateFromDiscriminatorValue },
            { "401", Models.Object_type401Error.CreateFromDiscriminatorValue },
            { "403", Models.Object_type403Error.CreateFromDiscriminatorValue },
            { "404", Models.Object_type404Error.CreateFromDiscriminatorValue },
            { "422", Models.Object_type422Error.CreateFromDiscriminatorValue },
            { "500", Models.Object_type500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Tag.Item.Object_typePutResponse>(requestInfo, Tag.Item.Object_typePutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Changes a Tag.
    /// </summary>
    /// <returns>A <see cref="Tag.Item.Object_typeResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Object_type400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Object_type401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Object_type403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Object_type404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Object_type422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Object_type500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PutAsObject_typePutResponseAsync instead.")]
    public async Task<Tag.Item.Object_typeResponse> PutAsync(Models.TagRestAPI.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Object_type400Error.CreateFromDiscriminatorValue },
            { "401", Models.Object_type401Error.CreateFromDiscriminatorValue },
            { "403", Models.Object_type403Error.CreateFromDiscriminatorValue },
            { "404", Models.Object_type404Error.CreateFromDiscriminatorValue },
            { "422", Models.Object_type422Error.CreateFromDiscriminatorValue },
            { "500", Models.Object_type500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Tag.Item.Object_typeResponse>(requestInfo, Tag.Item.Object_typeResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a tag
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
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Tag.Item.Object_typeItemRequestBuilder.Object_typeItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Changes a Tag.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPutRequestInformation(Models.TagRestAPI.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Tag.Item.Object_typeItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Object_typeItemRequestBuilder WithUrl(string rawUrl)
    {
        return new Object_typeItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Object_typeItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Object_typeItemRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Object_typeItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Tag.Item.Object_typeItemRequestBuilder.Object_typeItemRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Object_typeItemRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
