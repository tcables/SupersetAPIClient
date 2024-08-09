using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Dataset.Distinct;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dataset\distinct
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class DistinctRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.dataset.distinct.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Dataset.Distinct.Item.WithColumn_nameItemRequestBuilder"/></returns>
    public KApi.Dataset.Distinct.Item.WithColumn_nameItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("column_name", position);
            return new KApi.Dataset.Distinct.Item.WithColumn_nameItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.Distinct.DistinctRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DistinctRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/distinct", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.Distinct.DistinctRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DistinctRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/distinct", rawUrl)
    {
    }
}
