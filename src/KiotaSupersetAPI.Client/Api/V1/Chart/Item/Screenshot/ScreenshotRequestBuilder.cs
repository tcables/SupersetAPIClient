
using KiotaSupersetAPI.Client.Api.V1.Chart.Item.Screenshot.Item;
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

namespace KiotaSupersetAPI.Client.Api.V1.Chart.Item.Screenshot
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\chart\{pk}\screenshot
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ScreenshotRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.chart.item.screenshot.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="KApi.Chart.Item.Screenshot.Item.WithDigestItemRequestBuilder"/></returns>
        public KApi.Chart.Item.Screenshot.Item.WithDigestItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("digest", position);
                return new KApi.Chart.Item.Screenshot.Item.WithDigestItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Chart.Item.Screenshot.ScreenshotRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScreenshotRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/{pk}/screenshot", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Chart.Item.Screenshot.ScreenshotRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScreenshotRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/{pk}/screenshot", rawUrl)
        {
        }
    }
}
