
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KiotaSupersetAPI.Client.Api.V1.Cachekey.Invalidate;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Cachekey;

/// <summary>
/// Builds and executes requests for operations under \api\v1\cachekey
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class CachekeyRequestBuilder : BaseRequestBuilder
{
    /// <summary>The invalidate property</summary>
    public KApi.Cachekey.Invalidate.InvalidateRequestBuilder Invalidate
    {
        get => new KApi.Cachekey.Invalidate.InvalidateRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Cachekey.CachekeyRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public CachekeyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/cachekey", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Cachekey.CachekeyRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public CachekeyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/cachekey", rawUrl)
    {
    }
}
