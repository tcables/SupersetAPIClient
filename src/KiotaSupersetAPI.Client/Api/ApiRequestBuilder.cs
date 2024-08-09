using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API;

/// <summary>
/// Builds and executes requests for operations under \api
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class APIRequestBuilder : BaseRequestBuilder
{
    /// <summary>The v1 property</summary>
    public SwaggerV1RequestBuilder V1
    {
        get => new SwaggerV1RequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="API.Item.WithVersionItemRequestBuilder"/></returns>
    public API.Item.WithVersionItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("version", position);
            return new API.Item.WithVersionItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="API.APIRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public APIRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="API.ApiRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public APIRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api", rawUrl)
    {
    }
}
