using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.Api.Item;

/// <summary>
/// Builds and executes requests for operations under \api\{version}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithVersionItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>The _openapi property</summary>
    public Api.Item._openapi._openapiRequestBuilder _openapi
    {
        get => new Api.Item._openapi._openapiRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="Api.Item.WithVersionItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithVersionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/{version}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Api.Item.WithVersionItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithVersionItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/{version}", rawUrl)
    {
    }
}
