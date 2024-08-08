using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;
using KApi = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Database.Item.Table.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\{pk}\table\{table_name}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithTable_nameItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.database.item.table.item.item collection</summary>
    /// <param name="position">Table schema</param>
    /// <returns>A <see cref="KApi.Database.Item.Table.Item.Item.WithSchema_nameItemRequestBuilder"/></returns>
    public KApi.Database.Item.Table.Item.Item.WithSchema_nameItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("schema_name", position);
            return new KApi.Database.Item.Table.Item.Item.WithSchema_nameItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Database.Item.Table.Item.WithTable_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithTable_nameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/table/{table_name}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Database.Item.Table.Item.WithTable_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithTable_nameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/table/{table_name}", rawUrl)
    {
    }
}
