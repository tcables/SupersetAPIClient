using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Thumbnail;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dashboard\{dashboard_-id}\thumbnail
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ThumbnailRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.dashboard.item.thumbnail.item collection</summary>
    /// <param name="position">A hex digest that makes this dashboard unique</param>
    /// <returns>A <see cref="Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder"/></returns>
    public Thumbnail.Item.WithDigestItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("digest", position);
            return new Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Thumbnail.ThumbnailRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ThumbnailRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/thumbnail", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Thumbnail.ThumbnailRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ThumbnailRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/thumbnail", rawUrl)
    {
    }
}
