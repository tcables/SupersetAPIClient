using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Embedded_dashboard;

/// <summary>
/// Builds and executes requests for operations under \api\v1\embedded_dashboard
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Embedded_dashboardRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.embedded_dashboard.item collection</summary>
    /// <param name="position">The embedded configuration uuid</param>
    /// <returns>A <see cref="Embedded_dashboard.Item.WithUuItemRequestBuilder"/></returns>
    public Embedded_dashboard.Item.WithUuItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("uuid", position);
            return new Embedded_dashboard.Item.WithUuItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Embedded_dashboard.Embedded_dashboardRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Embedded_dashboardRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/embedded_dashboard", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Embedded_dashboard.Embedded_dashboardRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Embedded_dashboardRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/embedded_dashboard", rawUrl)
    {
    }
}
