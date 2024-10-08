
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.QueryRestAPI.Get;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Get : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The client_id property</summary>
    public string ClientId { get; set; }

    /// <summary>The database property</summary>
    public Models.QueryRestAPI.Get.Database Database { get; set; }

    /// <summary>The end_result_backend_time property</summary>
    public double? EndResultBackendTime { get; set; }
    /// <summary>The end_time property</summary>
    public double? EndTime { get; set; }
    /// <summary>The error_message property</summary>
    public string ErrorMessage { get; set; }

    /// <summary>The executed_sql property</summary>
    public string ExecutedSql { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The limit property</summary>
    public int? Limit { get; set; }
    /// <summary>The progress property</summary>
    public int? Progress { get; set; }
    /// <summary>The results_key property</summary>
    public string ResultsKey { get; set; }

    /// <summary>The rows property</summary>
    public int? Rows { get; set; }
    /// <summary>The schema property</summary>
    public string Schema { get; set; }

    /// <summary>The select_as_cta property</summary>
    public bool? SelectAsCta { get; set; }
    /// <summary>The select_as_cta_used property</summary>
    public bool? SelectAsCtaUsed { get; set; }
    /// <summary>The select_sql property</summary>
    public string SelectSql { get; set; }

    /// <summary>The sql property</summary>
    public string Sql { get; set; }

    /// <summary>The sql_editor_id property</summary>
    public string SqlEditorId { get; set; }

    /// <summary>The start_running_time property</summary>
    public double? StartRunningTime { get; set; }
    /// <summary>The start_time property</summary>
    public double? StartTime { get; set; }
    /// <summary>The status property</summary>
    public string Status { get; set; }

    /// <summary>The tab_name property</summary>
    public string TabName { get; set; }

    /// <summary>The tmp_schema_name property</summary>
    public string TmpSchemaName { get; set; }

    /// <summary>The tmp_table_name property</summary>
    public string TmpTableName { get; set; }

    /// <summary>The tracking_url property</summary>
    public UntypedNode TrackingUrl { get; private set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.QueryRestAPI.Get.Get"/> and sets the default values.
    /// </summary>
    public Get()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.QueryRestAPI.Get.Get"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.QueryRestAPI.Get.Get CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.QueryRestAPI.Get.Get();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "client_id", n => { ClientId = n.GetStringValue(); } },
            { "database", n => { Database = n.GetObjectValue<Models.QueryRestAPI.Get.Database>(Models.QueryRestAPI.Get.Database.CreateFromDiscriminatorValue); } },
            { "end_result_backend_time", n => { EndResultBackendTime = n.GetDoubleValue(); } },
            { "end_time", n => { EndTime = n.GetDoubleValue(); } },
            { "error_message", n => { ErrorMessage = n.GetStringValue(); } },
            { "executed_sql", n => { ExecutedSql = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "limit", n => { Limit = n.GetIntValue(); } },
            { "progress", n => { Progress = n.GetIntValue(); } },
            { "results_key", n => { ResultsKey = n.GetStringValue(); } },
            { "rows", n => { Rows = n.GetIntValue(); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "select_as_cta", n => { SelectAsCta = n.GetBoolValue(); } },
            { "select_as_cta_used", n => { SelectAsCtaUsed = n.GetBoolValue(); } },
            { "select_sql", n => { SelectSql = n.GetStringValue(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "sql_editor_id", n => { SqlEditorId = n.GetStringValue(); } },
            { "start_running_time", n => { StartRunningTime = n.GetDoubleValue(); } },
            { "start_time", n => { StartTime = n.GetDoubleValue(); } },
            { "status", n => { Status = n.GetStringValue(); } },
            { "tab_name", n => { TabName = n.GetStringValue(); } },
            { "tmp_schema_name", n => { TmpSchemaName = n.GetStringValue(); } },
            { "tmp_table_name", n => { TmpTableName = n.GetStringValue(); } },
            { "tracking_url", n => { TrackingUrl = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteStringValue("client_id", ClientId);
        writer.WriteObjectValue<Models.QueryRestAPI.Get.Database>("database", Database);
        writer.WriteDoubleValue("end_result_backend_time", EndResultBackendTime);
        writer.WriteDoubleValue("end_time", EndTime);
        writer.WriteStringValue("error_message", ErrorMessage);
        writer.WriteStringValue("executed_sql", ExecutedSql);
        writer.WriteIntValue("id", Id);
        writer.WriteIntValue("limit", Limit);
        writer.WriteIntValue("progress", Progress);
        writer.WriteStringValue("results_key", ResultsKey);
        writer.WriteIntValue("rows", Rows);
        writer.WriteStringValue("schema", Schema);
        writer.WriteBoolValue("select_as_cta", SelectAsCta);
        writer.WriteBoolValue("select_as_cta_used", SelectAsCtaUsed);
        writer.WriteStringValue("select_sql", SelectSql);
        writer.WriteStringValue("sql", Sql);
        writer.WriteStringValue("sql_editor_id", SqlEditorId);
        writer.WriteDoubleValue("start_running_time", StartRunningTime);
        writer.WriteDoubleValue("start_time", StartTime);
        writer.WriteStringValue("status", Status);
        writer.WriteStringValue("tab_name", TabName);
        writer.WriteStringValue("tmp_schema_name", TmpSchemaName);
        writer.WriteStringValue("tmp_table_name", TmpTableName);
        writer.WriteAdditionalData(AdditionalData);
    }
}
