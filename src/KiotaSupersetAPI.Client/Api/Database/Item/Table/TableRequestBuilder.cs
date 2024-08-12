using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Database.Item.Table;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\{pk}\table
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class TableRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.database.item.table.item collection</summary>
    /// <param name="position">Table name</param>
    /// <returns>A <see cref="Database.Item.Table.Item.WithTable_nameItemRequestBuilder"/></returns>
    public Item.WithTable_nameItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("table_name", position);
            return new Item.WithTable_nameItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Table.TableRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public TableRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/table", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Table.TableRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public TableRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/table", rawUrl)
    {
    }
}
