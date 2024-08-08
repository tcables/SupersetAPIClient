
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models
{
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class ChartDataQueryObject : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Annotation layers to apply to chart</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KClient.Models.AnnotationLayer>? AnnotationLayers { get; set; }
#nullable restore
#else
        public List<KClient.Models.AnnotationLayer> AnnotationLayers { get; set; }
#endif
        /// <summary>A mapping of temporal extras that have been applied to the query</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.ChartDataQueryObject_applied_time_extras? AppliedTimeExtras { get; set; }
#nullable restore
#else
        public KClient.Models.ChartDataQueryObject_applied_time_extras AppliedTimeExtras { get; set; }
#endif
        /// <summary>Add fetch values predicate (where clause) to query if defined in datasource</summary>
        public bool? ApplyFetchValuesPredicate { get; set; }
        /// <summary>Columns which to select in the query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Columns { get; set; }
#nullable restore
#else
        public UntypedNode Columns { get; set; }
#endif
        /// <summary>The datasource property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.ChartDataDatasource? Datasource { get; set; }
#nullable restore
#else
        public KClient.Models.ChartDataDatasource Datasource { get; set; }
#endif
        /// <summary>Extra parameters to add to the query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.ChartDataExtras? Extras { get; set; }
#nullable restore
#else
        public KClient.Models.ChartDataExtras Extras { get; set; }
#endif
        /// <summary>The filters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KClient.Models.ChartDataFilter>? Filters { get; set; }
#nullable restore
#else
        public List<KClient.Models.ChartDataFilter> Filters { get; set; }
#endif
        /// <summary>Name of temporal column used for time filtering. </summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Granularity { get; set; }
#nullable restore
#else
        public string Granularity { get; set; }
#endif
        /// <summary>Name of temporal column used for time filtering for SQL datasources. This field is deprecated, use `granularity` instead.</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GranularitySqla { get; set; }
#nullable restore
#else
        public string GranularitySqla { get; set; }
#endif
        /// <summary>Columns by which to group the query. This field is deprecated, use `columns` instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Groupby { get; set; }
#nullable restore
#else
        public UntypedNode Groupby { get; set; }
#endif
        /// <summary>HAVING clause to be added to aggregate queries using AND operator. This field is deprecated and should be passed to `extras`.</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Having { get; set; }
#nullable restore
#else
        public string Having { get; set; }
#endif
        /// <summary>Should the rowcount of the actual query be returned</summary>
        public bool? IsRowcount { get; set; }
        /// <summary>Is the `query_object` a timeseries.</summary>
        public bool? IsTimeseries { get; set; }
        /// <summary>Aggregate expressions. Metrics can be passed as both references to datasource metrics (strings), or ad-hoc metricswhich are defined only within the query object. See `ChartDataAdhocMetricSchema` for the structure of ad-hoc metrics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Metrics { get; set; }
#nullable restore
#else
        public UntypedNode Metrics { get; set; }
#endif
        /// <summary>Expects a list of lists where the first element is the column name which to sort by, and the second element is a boolean.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Orderby { get; set; }
#nullable restore
#else
        public UntypedNode Orderby { get; set; }
#endif
        /// <summary>Reverse order. Default: `false`</summary>
        public bool? OrderDesc { get; set; }
        /// <summary>Post processing operations to be applied to the result set. Operations are applied to the result set in sequential order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KClient.Models.ChartDataPostProcessingOperation>? PostProcessing { get; set; }
#nullable restore
#else
        public List<KClient.Models.ChartDataPostProcessingOperation> PostProcessing { get; set; }
#endif
        /// <summary>The result_type property</summary>
        public KClient.Models.ChartDataQueryObject_result_type? ResultType { get; set; }
        /// <summary>Maximum row count (0=disabled). Default: `config[&quot;ROW_LIMIT&quot;]`</summary>
        public int? RowLimit { get; set; }
        /// <summary>Number of rows to skip. Default: `0`</summary>
        public int? RowOffset { get; set; }
        /// <summary>Columns to use when limiting series count. All columns must be present in the `columns` property. Requires `series_limit` and `series_limit_metric` to be set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? SeriesColumns { get; set; }
#nullable restore
#else
        public UntypedNode SeriesColumns { get; set; }
#endif
        /// <summary>Maximum number of series. Requires `series` and `series_limit_metric` to be set.</summary>
        public int? SeriesLimit { get; set; }
        /// <summary>Metric used to limit timeseries queries by. Requires `series` and `series_limit` to be set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? SeriesLimitMetric { get; set; }
#nullable restore
#else
        public UntypedNode SeriesLimitMetric { get; set; }
#endif
        /// <summary>The time_offsets property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TimeOffsets { get; set; }
#nullable restore
#else
        public List<string> TimeOffsets { get; set; }
#endif
        /// <summary>A time rage, either expressed as a colon separated string `since : until` or human readable freeform. Valid formats for `since` and `until` are: - ISO 8601- X days/years/hours/day/year/weeks- X days/years/hours/day/year/weeks ago- X days/years/hours/day/year/weeks from nowAdditionally, the following freeform can be used:- Last day- Last week- Last month- Last quarter- Last year- No filter- Last X seconds/minutes/hours/days/weeks/months/years- Next X seconds/minutes/hours/days/weeks/months/years</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeRange { get; set; }
#nullable restore
#else
        public string TimeRange { get; set; }
#endif
        /// <summary>Maximum row count for timeseries queries. This field is deprecated, use `series_limit` instead.Default: `0`</summary>
        public int? TimeseriesLimit { get; set; }
        /// <summary>Metric used to limit timeseries queries by. This field is deprecated, use `series_limit_metric` instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? TimeseriesLimitMetric { get; set; }
#nullable restore
#else
        public UntypedNode TimeseriesLimitMetric { get; set; }
#endif
        /// <summary>A human-readable date/time string. Please refer to [parsdatetime](https://github.com/bear/parsedatetime) documentation for details on valid values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeShift { get; set; }
#nullable restore
#else
        public string TimeShift { get; set; }
#endif
        /// <summary>Optional query parameters passed to a dashboard or Explore  view</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.ChartDataQueryObject_url_params? UrlParams { get; set; }
#nullable restore
#else
        public KClient.Models.ChartDataQueryObject_url_params UrlParams { get; set; }
#endif
        /// <summary>WHERE clause to be added to queries using AND operator.This field is deprecated and should be passed to `extras`.</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Where { get; set; }
#nullable restore
#else
        public string Where { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KClient.Models.ChartDataQueryObject"/> and sets the default values.
        /// </summary>
        public ChartDataQueryObject()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KClient.Models.ChartDataQueryObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KClient.Models.ChartDataQueryObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KClient.Models.ChartDataQueryObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "annotation_layers", n => { AnnotationLayers = n.GetCollectionOfObjectValues<KClient.Models.AnnotationLayer>(KClient.Models.AnnotationLayer.CreateFromDiscriminatorValue)?.ToList(); } },
                { "applied_time_extras", n => { AppliedTimeExtras = n.GetObjectValue<KClient.Models.ChartDataQueryObject_applied_time_extras>(KClient.Models.ChartDataQueryObject_applied_time_extras.CreateFromDiscriminatorValue); } },
                { "apply_fetch_values_predicate", n => { ApplyFetchValuesPredicate = n.GetBoolValue(); } },
                { "columns", n => { Columns = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "datasource", n => { Datasource = n.GetObjectValue<KClient.Models.ChartDataDatasource>(KClient.Models.ChartDataDatasource.CreateFromDiscriminatorValue); } },
                { "extras", n => { Extras = n.GetObjectValue<KClient.Models.ChartDataExtras>(KClient.Models.ChartDataExtras.CreateFromDiscriminatorValue); } },
                { "filters", n => { Filters = n.GetCollectionOfObjectValues<KClient.Models.ChartDataFilter>(KClient.Models.ChartDataFilter.CreateFromDiscriminatorValue)?.ToList(); } },
                { "granularity", n => { Granularity = n.GetStringValue(); } },
                { "granularity_sqla", n => { GranularitySqla = n.GetStringValue(); } },
                { "groupby", n => { Groupby = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "having", n => { Having = n.GetStringValue(); } },
                { "is_rowcount", n => { IsRowcount = n.GetBoolValue(); } },
                { "is_timeseries", n => { IsTimeseries = n.GetBoolValue(); } },
                { "metrics", n => { Metrics = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "order_desc", n => { OrderDesc = n.GetBoolValue(); } },
                { "orderby", n => { Orderby = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "post_processing", n => { PostProcessing = n.GetCollectionOfObjectValues<KClient.Models.ChartDataPostProcessingOperation>(KClient.Models.ChartDataPostProcessingOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                { "result_type", n => { ResultType = n.GetEnumValue<KClient.Models.ChartDataQueryObject_result_type>(); } },
                { "row_limit", n => { RowLimit = n.GetIntValue(); } },
                { "row_offset", n => { RowOffset = n.GetIntValue(); } },
                { "series_columns", n => { SeriesColumns = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "series_limit", n => { SeriesLimit = n.GetIntValue(); } },
                { "series_limit_metric", n => { SeriesLimitMetric = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "time_offsets", n => { TimeOffsets = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "time_range", n => { TimeRange = n.GetStringValue(); } },
                { "time_shift", n => { TimeShift = n.GetStringValue(); } },
                { "timeseries_limit", n => { TimeseriesLimit = n.GetIntValue(); } },
                { "timeseries_limit_metric", n => { TimeseriesLimitMetric = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "url_params", n => { UrlParams = n.GetObjectValue<KClient.Models.ChartDataQueryObject_url_params>(KClient.Models.ChartDataQueryObject_url_params.CreateFromDiscriminatorValue); } },
                { "where", n => { Where = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<KClient.Models.AnnotationLayer>("annotation_layers", AnnotationLayers);
            writer.WriteObjectValue<KClient.Models.ChartDataQueryObject_applied_time_extras>("applied_time_extras", AppliedTimeExtras);
            writer.WriteBoolValue("apply_fetch_values_predicate", ApplyFetchValuesPredicate);
            writer.WriteObjectValue<UntypedNode>("columns", Columns);
            writer.WriteObjectValue<KClient.Models.ChartDataDatasource>("datasource", Datasource);
            writer.WriteObjectValue<KClient.Models.ChartDataExtras>("extras", Extras);
            writer.WriteCollectionOfObjectValues<KClient.Models.ChartDataFilter>("filters", Filters);
            writer.WriteStringValue("granularity", Granularity);
            writer.WriteStringValue("granularity_sqla", GranularitySqla);
            writer.WriteObjectValue<UntypedNode>("groupby", Groupby);
            writer.WriteStringValue("having", Having);
            writer.WriteBoolValue("is_rowcount", IsRowcount);
            writer.WriteBoolValue("is_timeseries", IsTimeseries);
            writer.WriteObjectValue<UntypedNode>("metrics", Metrics);
            writer.WriteObjectValue<UntypedNode>("orderby", Orderby);
            writer.WriteBoolValue("order_desc", OrderDesc);
            writer.WriteCollectionOfObjectValues<KClient.Models.ChartDataPostProcessingOperation>("post_processing", PostProcessing);
            writer.WriteEnumValue<KClient.Models.ChartDataQueryObject_result_type>("result_type", ResultType);
            writer.WriteIntValue("row_limit", RowLimit);
            writer.WriteIntValue("row_offset", RowOffset);
            writer.WriteObjectValue<UntypedNode>("series_columns", SeriesColumns);
            writer.WriteIntValue("series_limit", SeriesLimit);
            writer.WriteObjectValue<UntypedNode>("series_limit_metric", SeriesLimitMetric);
            writer.WriteCollectionOfPrimitiveValues<string>("time_offsets", TimeOffsets);
            writer.WriteStringValue("time_range", TimeRange);
            writer.WriteIntValue("timeseries_limit", TimeseriesLimit);
            writer.WriteObjectValue<UntypedNode>("timeseries_limit_metric", TimeseriesLimitMetric);
            writer.WriteStringValue("time_shift", TimeShift);
            writer.WriteObjectValue<KClient.Models.ChartDataQueryObject_url_params>("url_params", UrlParams);
            writer.WriteStringValue("where", Where);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
