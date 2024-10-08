using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Chart.Item.Thumbnail;

/// <summary>
/// Builds and executes requests for operations under \api\v1\chart\{pk}\thumbnail
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ThumbnailRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.chart.item.thumbnail.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="Chart.Item.Thumbnail.Item.WithDigestItemRequestBuilder"/></returns>
    public Item.WithDigestItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("digest", position);
            return new Item.WithDigestItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Chart.Item.Thumbnail.ThumbnailRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ThumbnailRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/{pk}/thumbnail", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Chart.Item.Thumbnail.ThumbnailRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ThumbnailRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/{pk}/thumbnail", rawUrl)
    {
    }
}
