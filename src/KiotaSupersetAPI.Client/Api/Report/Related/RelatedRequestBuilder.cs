using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Report.Related;

/// <summary>
/// Builds and executes requests for operations under \api\v1\report\related
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class RelatedRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.report.related.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="Report.Related.Item.WithColumn_nameItemRequestBuilder"/></returns>
    public Item.WithColumn_nameItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("column_name", position);
            return new Related.Item.WithColumn_nameItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Report.Related.RelatedRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public RelatedRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/report/related", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Report.Related.RelatedRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public RelatedRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/report/related", rawUrl)
    {
    }
}
