using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Dashboard.Permalink;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dashboard\permalink
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class PermalinkRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.dashboard.permalink.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="Dashboard.Permalink.Item.WithKeyItemRequestBuilder"/></returns>
    public Dashboard.Permalink.Item.WithKeyItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("key", position);
            return new Dashboard.Permalink.Item.WithKeyItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Permalink.PermalinkRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public PermalinkRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/permalink", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Permalink.PermalinkRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public PermalinkRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/permalink", rawUrl)
    {
    }
}
