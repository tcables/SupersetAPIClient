using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Datasource.Item.Item.Column.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\datasource\{datasource_type}\{datasource_id}\column\{column_name}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithColumn_nameItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>The values property</summary>
    public KApi.Datasource.Item.Item.Column.Item.Values.ValuesRequestBuilder Values
    {
        get => new KApi.Datasource.Item.Item.Column.Item.Values.ValuesRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Datasource.Item.Item.Column.Item.WithColumn_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithColumn_nameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/datasource/{datasource_type}/{datasource_id}/column/{column_name}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Datasource.Item.Item.Column.Item.WithColumn_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithColumn_nameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/datasource/{datasource_type}/{datasource_id}/column/{column_name}", rawUrl)
    {
    }
}
