using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Cachekey;

/// <summary>
/// Builds and executes requests for operations under \api\v1\cachekey
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class CachekeyRequestBuilder : BaseRequestBuilder
{
    /// <summary>The invalidate property</summary>
    public Invalidate.InvalidateRequestBuilder Invalidate
    {
        get => new Cachekey.Invalidate.InvalidateRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="Cachekey.CachekeyRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public CachekeyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/cachekey", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Cachekey.CachekeyRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public CachekeyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/cachekey", rawUrl)
    {
    }
}
