
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;
using KApi = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Dataset.Item.Metric;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dataset\{pk}\metric
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class MetricRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.dataset.item.metric.item collection</summary>
    /// <param name="position">The metric id for this dataset</param>
    /// <returns>A <see cref="KApi.Dataset.Item.Metric.Item.WithMetric_ItemRequestBuilder"/></returns>
    public KApi.Dataset.Item.Metric.Item.WithMetric_ItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("metric_id", position);
            return new KApi.Dataset.Item.Metric.Item.WithMetric_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.dataset.item.metric.item collection</summary>
    /// <param name="position">The metric id for this dataset</param>
    /// <returns>A <see cref="KApi.Dataset.Item.Metric.Item.WithMetric_ItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public KApi.Dataset.Item.Metric.Item.WithMetric_ItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("metric_id", position);
            return new KApi.Dataset.Item.Metric.Item.WithMetric_ItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.Item.Metric.MetricRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public MetricRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/{pk}/metric", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.Item.Metric.MetricRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public MetricRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/{pk}/metric", rawUrl)
    {
    }
}
