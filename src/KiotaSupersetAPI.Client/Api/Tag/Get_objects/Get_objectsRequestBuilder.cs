
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Tag.Get_objects;

/// <summary>
/// Builds and executes requests for operations under \api\v1\tag\get_objects
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Get_objectsRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Tag.Get_objects.Get_objectsRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Get_objectsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag/get_objects", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Tag.Get_objects.Get_objectsRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Get_objectsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag/get_objects", rawUrl)
    {
    }
    /// <summary>
    /// Get all objects associated with a tag
    /// </summary>
    /// <returns>A <see cref="KApi.Tag.Get_objects.Get_objectsGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Get_objects400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Get_objects401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Get_objects404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Get_objects500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Tag.Get_objects.Get_objectsGetResponse> GetGet_objectsGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Get_objects400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Get_objects401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Get_objects404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Get_objects500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Tag.Get_objects.Get_objectsGetResponse>(requestInfo, KApi.Tag.Get_objects.Get_objectsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get all objects associated with a tag
    /// </summary>
    /// <returns>A <see cref="KApi.Tag.Get_objects.Get_objectsResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Get_objects400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Get_objects401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Get_objects404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Get_objects500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsGet_objectsGetResponseAsync instead.")]
    public async Task<KApi.Tag.Get_objects.Get_objectsResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Get_objects400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Get_objects401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Get_objects404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Get_objects500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Tag.Get_objects.Get_objectsResponse>(requestInfo, KApi.Tag.Get_objects.Get_objectsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get all objects associated with a tag
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Tag.Get_objects.Get_objectsRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Tag.Get_objects.Get_objectsRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Tag.Get_objects.Get_objectsRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Get_objectsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
