using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Rowlevelsecurity.Related;

/// <summary>
/// Builds and executes requests for operations under \api\v1\rowlevelsecurity\related
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class RelatedRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.rowlevelsecurity.related.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="Rowlevelsecurity.Related.Item.WithColumn_nameItemRequestBuilder"/></returns>
    public Rowlevelsecurity.Related.Item.WithColumn_nameItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("column_name", position);
            return new Rowlevelsecurity.Related.Item.WithColumn_nameItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Rowlevelsecurity.Related.RelatedRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public RelatedRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/rowlevelsecurity/related", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Rowlevelsecurity.Related.RelatedRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public RelatedRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/rowlevelsecurity/related", rawUrl)
    {
    }
}
