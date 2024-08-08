
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KiotaSupersetAPI.Client.Api.V1.Sqllab.Export.Item;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Sqllab.Export;

/// <summary>
/// Builds and executes requests for operations under \api\v1\sqllab\export
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ExportRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.sqllab.export.item collection</summary>
    /// <param name="position">The SQL query result identifier</param>
    /// <returns>A <see cref="KApi.Sqllab.Export.Item.WithClient_ItemRequestBuilder"/></returns>
    public KApi.Sqllab.Export.Item.WithClient_ItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("client_id", position);
            return new KApi.Sqllab.Export.Item.WithClient_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.sqllab.export.item collection</summary>
    /// <param name="position">The SQL query result identifier</param>
    /// <returns>A <see cref="KApi.Sqllab.Export.Item.WithClient_ItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public KApi.Sqllab.Export.Item.WithClient_ItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("client_id", position);
            return new KApi.Sqllab.Export.Item.WithClient_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Sqllab.Export.ExportRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ExportRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/sqllab/export", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Sqllab.Export.ExportRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ExportRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/sqllab/export", rawUrl)
    {
    }
}
