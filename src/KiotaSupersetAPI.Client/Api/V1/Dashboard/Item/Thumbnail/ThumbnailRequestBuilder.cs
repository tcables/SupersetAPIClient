
using KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Thumbnail.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Thumbnail
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\dashboard\{dashboard_-id}\thumbnail
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ThumbnailRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.dashboard.item.thumbnail.item collection</summary>
        /// <param name="position">A hex digest that makes this dashboard unique</param>
        /// <returns>A <see cref="KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder"/></returns>
        public KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("digest", position);
                return new KApi.Dashboard.Item.Thumbnail.Item.WithDigestItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Dashboard.Item.Thumbnail.ThumbnailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThumbnailRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/thumbnail", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Dashboard.Item.Thumbnail.ThumbnailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThumbnailRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/{dashboard_%2Did}/thumbnail", rawUrl)
        {
        }
    }
}
