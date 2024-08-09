using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Assets;

/// <summary>
/// Builds and executes requests for operations under \api\v1\assets
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class AssetsRequestBuilder : BaseRequestBuilder
{
    /// <summary>The export property</summary>
    public Assets.Export.ExportRequestBuilder Export
    {
        get => new Assets.Export.ExportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The import property</summary>
    public Assets.Import.ImportRequestBuilder Import
    {
        get => new Assets.Import.ImportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="Assets.AssetsRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public AssetsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/assets", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Assets.AssetsRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public AssetsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/assets", rawUrl)
    {
    }
}
