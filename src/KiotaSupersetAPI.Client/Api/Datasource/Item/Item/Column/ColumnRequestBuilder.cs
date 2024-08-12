using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Datasource.Item.Item.Column;

/// <summary>
/// Builds and executes requests for operations under \api\v1\datasource\{datasource_type}\{datasource_id}\column
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ColumnRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.datasource.item.item.column.item collection</summary>
    /// <param name="position">The name of the column to get values for</param>
    /// <returns>A <see cref="Datasource.Item.Item.Column.Item.WithColumn_nameItemRequestBuilder"/></returns>
    public Column.Item.WithColumn_nameItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("column_name", position);
            return new Column.Item.WithColumn_nameItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Datasource.Item.Item.Column.ColumnRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ColumnRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/datasource/{datasource_type}/{datasource_id}/column", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Datasource.Item.Item.Column.ColumnRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ColumnRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/datasource/{datasource_type}/{datasource_id}/column", rawUrl)
    {
    }
}
