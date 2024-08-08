
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.QueryRestApi.Get;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Get : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The client_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ClientId { get; set; }
#nullable restore
#else
    public string ClientId { get; set; }
#endif
    /// <summary>The database property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.QueryRestApi.Get.Database? Database { get; set; }
#nullable restore
#else
    public KClient.Models.QueryRestApi.Get.Database Database { get; set; }
#endif
    /// <summary>The end_result_backend_time property</summary>
    public double? EndResultBackendTime { get; set; }
    /// <summary>The end_time property</summary>
    public double? EndTime { get; set; }
    /// <summary>The error_message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ErrorMessage { get; set; }
#nullable restore
#else
    public string ErrorMessage { get; set; }
#endif
    /// <summary>The executed_sql property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ExecutedSql { get; set; }
#nullable restore
#else
    public string ExecutedSql { get; set; }
#endif
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The limit property</summary>
    public int? Limit { get; set; }
    /// <summary>The progress property</summary>
    public int? Progress { get; set; }
    /// <summary>The results_key property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ResultsKey { get; set; }
#nullable restore
#else
    public string ResultsKey { get; set; }
#endif
    /// <summary>The rows property</summary>
    public int? Rows { get; set; }
    /// <summary>The schema property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Schema { get; set; }
#nullable restore
#else
    public string Schema { get; set; }
#endif
    /// <summary>The select_as_cta property</summary>
    public bool? SelectAsCta { get; set; }
    /// <summary>The select_as_cta_used property</summary>
    public bool? SelectAsCtaUsed { get; set; }
    /// <summary>The select_sql property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? SelectSql { get; set; }
#nullable restore
#else
    public string SelectSql { get; set; }
#endif
    /// <summary>The sql property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Sql { get; set; }
#nullable restore
#else
    public string Sql { get; set; }
#endif
    /// <summary>The sql_editor_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? SqlEditorId { get; set; }
#nullable restore
#else
    public string SqlEditorId { get; set; }
#endif
    /// <summary>The start_running_time property</summary>
    public double? StartRunningTime { get; set; }
    /// <summary>The start_time property</summary>
    public double? StartTime { get; set; }
    /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Status { get; set; }
#nullable restore
#else
    public string Status { get; set; }
#endif
    /// <summary>The tab_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? TabName { get; set; }
#nullable restore
#else
    public string TabName { get; set; }
#endif
    /// <summary>The tmp_schema_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? TmpSchemaName { get; set; }
#nullable restore
#else
    public string TmpSchemaName { get; set; }
#endif
    /// <summary>The tmp_table_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? TmpTableName { get; set; }
#nullable restore
#else
    public string TmpTableName { get; set; }
#endif
    /// <summary>The tracking_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? TrackingUrl { get; private set; }
#nullable restore
#else
    public UntypedNode TrackingUrl { get; private set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.QueryRestApi.Get.Get"/> and sets the default values.
    /// </summary>
    public Get()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.QueryRestApi.Get.Get"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.QueryRestApi.Get.Get CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.QueryRestApi.Get.Get();
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
            { "database", n => { Database = n.GetObjectValue<KClient.Models.QueryRestApi.Get.Database>(KClient.Models.QueryRestApi.Get.Database.CreateFromDiscriminatorValue); } },
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
        writer.WriteObjectValue<KClient.Models.QueryRestApi.Get.Database>("database", Database);
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
