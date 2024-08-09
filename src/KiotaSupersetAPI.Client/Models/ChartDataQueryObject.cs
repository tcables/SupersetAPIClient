
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class ChartDataQueryObject : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Annotation layers to apply to chart</summary>
    public List<KClient.Models.AnnotationLayer> AnnotationLayers { get; set; }

    /// <summary>A mapping of temporal extras that have been applied to the query</summary>
    public KClient.Models.ChartDataQueryObject_applied_time_extras AppliedTimeExtras { get; set; }

    /// <summary>Add fetch values predicate (where clause) to query if defined in datasource</summary>
    public bool? ApplyFetchValuesPredicate { get; set; }
    /// <summary>Columns which to select in the query.</summary>
    public UntypedNode Columns { get; set; }

    /// <summary>The datasource property</summary>
    public KClient.Models.ChartDataDatasource Datasource { get; set; }

    /// <summary>Extra parameters to add to the query.</summary>
    public KClient.Models.ChartDataExtras Extras { get; set; }

    /// <summary>The filters property</summary>
    public List<KClient.Models.ChartDataFilter> Filters { get; set; }

    /// <summary>Name of temporal column used for time filtering. </summary>
    public string Granularity { get; set; }

    /// <summary>Name of temporal column used for time filtering for SQL datasources. This field is deprecated, use `granularity` instead.</summary>
    [Obsolete("")]
    public string GranularitySqla { get; set; }

    /// <summary>Columns by which to group the query. This field is deprecated, use `columns` instead.</summary>
    public UntypedNode Groupby { get; set; }

    /// <summary>HAVING clause to be added to aggregate queries using AND operator. This field is deprecated and should be passed to `extras`.</summary>
    [Obsolete("")]
    public string Having { get; set; }

    /// <summary>Should the rowcount of the actual query be returned</summary>
    public bool? IsRowcount { get; set; }
    /// <summary>Is the `query_object` a timeseries.</summary>
    public bool? IsTimeseries { get; set; }
    /// <summary>Aggregate expressions. Metrics can be passed as both references to datasource metrics (strings), or ad-hoc metricswhich are defined only within the query object. See `ChartDataAdhocMetricSchema` for the structure of ad-hoc metrics.</summary>
    public UntypedNode Metrics { get; set; }

    /// <summary>Expects a list of lists where the first element is the column name which to sort by, and the second element is a boolean.</summary>
    public UntypedNode Orderby { get; set; }

    /// <summary>Reverse order. Default: `false`</summary>
    public bool? OrderDesc { get; set; }
    /// <summary>Post processing operations to be applied to the result set. Operations are applied to the result set in sequential order.</summary>
    public List<KClient.Models.ChartDataPostProcessingOperation> PostProcessing { get; set; }

    /// <summary>The result_type property</summary>
    public KClient.Models.ChartDataQueryObject_result_type? ResultType { get; set; }
    /// <summary>Maximum row count (0=disabled). Default: `config[&quot;ROW_LIMIT&quot;]`</summary>
    public int? RowLimit { get; set; }
    /// <summary>Number of rows to skip. Default: `0`</summary>
    public int? RowOffset { get; set; }
    /// <summary>Columns to use when limiting series count. All columns must be present in the `columns` property. Requires `series_limit` and `series_limit_metric` to be set.</summary>
    public UntypedNode SeriesColumns { get; set; }

    /// <summary>Maximum number of series. Requires `series` and `series_limit_metric` to be set.</summary>
    public int? SeriesLimit { get; set; }
    /// <summary>Metric used to limit timeseries queries by. Requires `series` and `series_limit` to be set.</summary>
    public UntypedNode SeriesLimitMetric { get; set; }

    /// <summary>The time_offsets property</summary>
    public List<string> TimeOffsets { get; set; }

    /// <summary>A time rage, either expressed as a colon separated string `since : until` or human readable freeform. Valid formats for `since` and `until` are: - ISO 8601- X days/years/hours/day/year/weeks- X days/years/hours/day/year/weeks ago- X days/years/hours/day/year/weeks from nowAdditionally, the following freeform can be used:- Last day- Last week- Last month- Last quarter- Last year- No filter- Last X seconds/minutes/hours/days/weeks/months/years- Next X seconds/minutes/hours/days/weeks/months/years</summary>
    public string TimeRange { get; set; }

    /// <summary>Maximum row count for timeseries queries. This field is deprecated, use `series_limit` instead.Default: `0`</summary>
    public int? TimeseriesLimit { get; set; }
    /// <summary>Metric used to limit timeseries queries by. This field is deprecated, use `series_limit_metric` instead.</summary>
    public UntypedNode TimeseriesLimitMetric { get; set; }

    /// <summary>A human-readable date/time string. Please refer to [parsdatetime](https://github.com/bear/parsedatetime) documentation for details on valid values.</summary>
    public string TimeShift { get; set; }

    /// <summary>Optional query parameters passed to a dashboard or Explore  view</summary>
    public KClient.Models.ChartDataQueryObject_url_params UrlParams { get; set; }

    /// <summary>WHERE clause to be added to queries using AND operator.This field is deprecated and should be passed to `extras`.</summary>
    [Obsolete("")]
    public string Where { get; set; }

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
