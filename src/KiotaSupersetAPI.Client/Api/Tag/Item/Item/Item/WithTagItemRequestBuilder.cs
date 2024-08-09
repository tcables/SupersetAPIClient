
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Tag.Item.Item.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\tag\{object_type-id}\{object_id}\{tag}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithTagItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Tag.Item.Item.Item.WithTagItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithTagItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag/{object_type%2Did}/{object_id}/{tag}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Tag.Item.Item.Item.WithTagItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithTagItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag/{object_type%2Did}/{object_id}/{tag}", rawUrl)
    {
    }
    /// <summary>
    /// Delete a tagged object
    /// </summary>
    /// <returns>A <see cref="KApi.Tag.Item.Item.Item.WithTagDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithTag401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithTag403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithTag404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithTag422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithTag500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Tag.Item.Item.Item.WithTagDeleteResponse> DeleteAsWithTagDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.WithTag401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithTag403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithTag404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithTag422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithTag500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Tag.Item.Item.Item.WithTagDeleteResponse>(requestInfo, KApi.Tag.Item.Item.Item.WithTagDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a tagged object
    /// </summary>
    /// <returns>A <see cref="KApi.Tag.Item.Item.Item.WithTagResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithTag401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithTag403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithTag404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithTag422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithTag500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsWithTagDeleteResponseAsync instead.")]
    public async Task<KApi.Tag.Item.Item.Item.WithTagResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.WithTag401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithTag403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithTag404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithTag422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithTag500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Tag.Item.Item.Item.WithTagResponse>(requestInfo, KApi.Tag.Item.Item.Item.WithTagResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a tagged object
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
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Tag.Item.Item.Item.WithTagItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Tag.Item.Item.Item.WithTagItemRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Tag.Item.Item.Item.WithTagItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithTagItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
