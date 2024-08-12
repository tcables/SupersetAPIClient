
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Dataset.Item.Column;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dataset\{pk}\column
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ColumnRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.dataset.item.column.item collection</summary>
    /// <param name="position">The column id for this dataset</param>
    /// <returns>A <see cref="Dataset.Item.Column.Item.WithColumn_ItemRequestBuilder"/></returns>
    public Column.Item.WithColumn_ItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("column_id", position);
            return new Column.Item.WithColumn_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.dataset.item.column.item collection</summary>
    /// <param name="position">The column id for this dataset</param>
    /// <returns>A <see cref="Dataset.Item.Column.Item.WithColumn_ItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public Column.Item.WithColumn_ItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("column_id", position);
            return new Column.Item.WithColumn_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Dataset.Item.Column.ColumnRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ColumnRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/{pk}/column", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dataset.Item.Column.ColumnRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ColumnRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/{pk}/column", rawUrl)
    {
    }
}
