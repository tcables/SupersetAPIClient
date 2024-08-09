using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Database.Item.Table_extra;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\{pk}\table_extra
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Table_extraRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.database.item.table_extra.item collection</summary>
    /// <param name="position">Table name</param>
    /// <returns>A <see cref="KApi.Database.Item.Table_extra.Item.WithTable_nameItemRequestBuilder"/></returns>
    public KApi.Database.Item.Table_extra.Item.WithTable_nameItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("table_name", position);
            return new KApi.Database.Item.Table_extra.Item.WithTable_nameItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Database.Item.Table_extra.Table_extraRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Table_extraRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/table_extra", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Database.Item.Table_extra.Table_extraRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Table_extraRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/table_extra", rawUrl)
    {
    }
}
