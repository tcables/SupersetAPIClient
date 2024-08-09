using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Saved_query.Distinct;

/// <summary>
/// Builds and executes requests for operations under \api\v1\saved_query\distinct
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class DistinctRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.saved_query.distinct.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Saved_query.Distinct.Item.WithColumn_nameItemRequestBuilder"/></returns>
    public KApi.Saved_query.Distinct.Item.WithColumn_nameItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("column_name", position);
            return new KApi.Saved_query.Distinct.Item.WithColumn_nameItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Saved_query.Distinct.DistinctRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DistinctRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/saved_query/distinct", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Saved_query.Distinct.DistinctRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DistinctRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/saved_query/distinct", rawUrl)
    {
    }
}
