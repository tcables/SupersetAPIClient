using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Database.Item.Table_extra.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\{pk}\table_extra\{table_name}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithTable_nameItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.database.item.table_extra.item.item collection</summary>
    /// <param name="position">Table schema</param>
    /// <returns>A <see cref="Database.Item.Table_extra.Item.Item.WithSchema_nameItemRequestBuilder"/></returns>
    public Item.WithSchema_nameItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("schema_name", position);
            return new Item.WithSchema_nameItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Table_extra.Item.WithTable_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithTable_nameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/table_extra/{table_name}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Table_extra.Item.WithTable_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithTable_nameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/table_extra/{table_name}", rawUrl)
    {
    }
}
