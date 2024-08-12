
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Datasource.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\datasource\{datasource_type}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithDatasource_typeItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.datasource.item.item collection</summary>
    /// <param name="position">The id of the datasource</param>
    /// <returns>A <see cref="Datasource.Item.Item.WithDatasource_ItemRequestBuilder"/></returns>
    public Item.WithDatasource_ItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("datasource_id", position);
            return new Item.WithDatasource_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.datasource.item.item collection</summary>
    /// <param name="position">The id of the datasource</param>
    /// <returns>A <see cref="Datasource.Item.Item.WithDatasource_ItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public Item.WithDatasource_ItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("datasource_id", position);
            return new Item.WithDatasource_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Datasource.Item.WithDatasource_typeItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithDatasource_typeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/datasource/{datasource_type}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Datasource.Item.WithDatasource_typeItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithDatasource_typeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/datasource/{datasource_type}", rawUrl)
    {
    }
}
