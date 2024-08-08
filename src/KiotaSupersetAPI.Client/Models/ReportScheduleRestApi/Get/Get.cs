
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.ReportScheduleRestApi.Get;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Get : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>The active property</summary>
    public bool? Active { get; set; }
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The chart property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.ReportScheduleRestApi.Get.Slice? Chart { get; set; }
#nullable restore
#else
    public KClient.Models.ReportScheduleRestApi.Get.Slice Chart { get; set; }
#endif
    /// <summary>The context_markdown property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ContextMarkdown { get; set; }
#nullable restore
#else
    public string ContextMarkdown { get; set; }
#endif
    /// <summary>The creation_method property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? CreationMethod { get; set; }
#nullable restore
#else
    public string CreationMethod { get; set; }
#endif
    /// <summary>The crontab property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Crontab { get; set; }
#nullable restore
#else
    public string Crontab { get; set; }
#endif
    /// <summary>The custom_width property</summary>
    public int? CustomWidth { get; set; }
    /// <summary>The dashboard property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.ReportScheduleRestApi.Get.Dashboard? Dashboard { get; set; }
#nullable restore
#else
    public KClient.Models.ReportScheduleRestApi.Get.Dashboard Dashboard { get; set; }
#endif
    /// <summary>The database property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.ReportScheduleRestApi.Get.Database? Database { get; set; }
#nullable restore
#else
    public KClient.Models.ReportScheduleRestApi.Get.Database Database { get; set; }
#endif
    /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Description { get; set; }
#nullable restore
#else
    public string Description { get; set; }
#endif
    /// <summary>The extra property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? Extra { get; private set; }
#nullable restore
#else
    public UntypedNode Extra { get; private set; }
#endif
    /// <summary>The force_screenshot property</summary>
    public bool? ForceScreenshot { get; set; }
    /// <summary>The grace_period property</summary>
    public int? GracePeriod { get; set; }
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The last_eval_dttm property</summary>
    public DateTimeOffset? LastEvalDttm { get; set; }
    /// <summary>The last_state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? LastState { get; set; }
#nullable restore
#else
    public string LastState { get; set; }
#endif
    /// <summary>The last_value property</summary>
    public double? LastValue { get; set; }
    /// <summary>The last_value_row_json property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? LastValueRowJson { get; set; }
#nullable restore
#else
    public string LastValueRowJson { get; set; }
#endif
    /// <summary>The log_retention property</summary>
    public int? LogRetention { get; set; }
    /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Name { get; set; }
#nullable restore
#else
    public string Name { get; set; }
#endif
    /// <summary>The owners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.ReportScheduleRestApi.Get.User? Owners { get; set; }
#nullable restore
#else
    public KClient.Models.ReportScheduleRestApi.Get.User Owners { get; set; }
#endif
    /// <summary>The recipients property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.ReportScheduleRestApi.Get.ReportRecipients? Recipients { get; set; }
#nullable restore
#else
    public KClient.Models.ReportScheduleRestApi.Get.ReportRecipients Recipients { get; set; }
#endif
    /// <summary>The report_format property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ReportFormat { get; set; }
#nullable restore
#else
    public string ReportFormat { get; set; }
#endif
    /// <summary>The sql property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Sql { get; set; }
#nullable restore
#else
    public string Sql { get; set; }
#endif
    /// <summary>The timezone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Timezone { get; set; }
#nullable restore
#else
    public string Timezone { get; set; }
#endif
    /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Type { get; set; }
#nullable restore
#else
    public string Type { get; set; }
#endif
    /// <summary>The validator_config_json property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ValidatorConfigJson { get; set; }
#nullable restore
#else
    public string ValidatorConfigJson { get; set; }
#endif
    /// <summary>The validator_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ValidatorType { get; set; }
#nullable restore
#else
    public string ValidatorType { get; set; }
#endif
    /// <summary>The working_timeout property</summary>
    public int? WorkingTimeout { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.ReportScheduleRestApi.Get.Get"/> and sets the default values.
    /// </summary>
    public Get()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ReportScheduleRestApi.Get.Get"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.ReportScheduleRestApi.Get.Get CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.ReportScheduleRestApi.Get.Get();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "active", n => { Active = n.GetBoolValue(); } },
            { "chart", n => { Chart = n.GetObjectValue<KClient.Models.ReportScheduleRestApi.Get.Slice>(KClient.Models.ReportScheduleRestApi.Get.Slice.CreateFromDiscriminatorValue); } },
            { "context_markdown", n => { ContextMarkdown = n.GetStringValue(); } },
            { "creation_method", n => { CreationMethod = n.GetStringValue(); } },
            { "crontab", n => { Crontab = n.GetStringValue(); } },
            { "custom_width", n => { CustomWidth = n.GetIntValue(); } },
            { "dashboard", n => { Dashboard = n.GetObjectValue<KClient.Models.ReportScheduleRestApi.Get.Dashboard>(KClient.Models.ReportScheduleRestApi.Get.Dashboard.CreateFromDiscriminatorValue); } },
            { "database", n => { Database = n.GetObjectValue<KClient.Models.ReportScheduleRestApi.Get.Database>(KClient.Models.ReportScheduleRestApi.Get.Database.CreateFromDiscriminatorValue); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "extra", n => { Extra = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "force_screenshot", n => { ForceScreenshot = n.GetBoolValue(); } },
            { "grace_period", n => { GracePeriod = n.GetIntValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "last_eval_dttm", n => { LastEvalDttm = n.GetDateTimeOffsetValue(); } },
            { "last_state", n => { LastState = n.GetStringValue(); } },
            { "last_value", n => { LastValue = n.GetDoubleValue(); } },
            { "last_value_row_json", n => { LastValueRowJson = n.GetStringValue(); } },
            { "log_retention", n => { LogRetention = n.GetIntValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "owners", n => { Owners = n.GetObjectValue<KClient.Models.ReportScheduleRestApi.Get.User>(KClient.Models.ReportScheduleRestApi.Get.User.CreateFromDiscriminatorValue); } },
            { "recipients", n => { Recipients = n.GetObjectValue<KClient.Models.ReportScheduleRestApi.Get.ReportRecipients>(KClient.Models.ReportScheduleRestApi.Get.ReportRecipients.CreateFromDiscriminatorValue); } },
            { "report_format", n => { ReportFormat = n.GetStringValue(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "timezone", n => { Timezone = n.GetStringValue(); } },
            { "type", n => { Type = n.GetStringValue(); } },
            { "validator_config_json", n => { ValidatorConfigJson = n.GetStringValue(); } },
            { "validator_type", n => { ValidatorType = n.GetStringValue(); } },
            { "working_timeout", n => { WorkingTimeout = n.GetIntValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteBoolValue("active", Active);
        writer.WriteObjectValue<KClient.Models.ReportScheduleRestApi.Get.Slice>("chart", Chart);
        writer.WriteStringValue("context_markdown", ContextMarkdown);
        writer.WriteStringValue("creation_method", CreationMethod);
        writer.WriteStringValue("crontab", Crontab);
        writer.WriteIntValue("custom_width", CustomWidth);
        writer.WriteObjectValue<KClient.Models.ReportScheduleRestApi.Get.Dashboard>("dashboard", Dashboard);
        writer.WriteObjectValue<KClient.Models.ReportScheduleRestApi.Get.Database>("database", Database);
        writer.WriteStringValue("description", Description);
        writer.WriteBoolValue("force_screenshot", ForceScreenshot);
        writer.WriteIntValue("grace_period", GracePeriod);
        writer.WriteIntValue("id", Id);
        writer.WriteDateTimeOffsetValue("last_eval_dttm", LastEvalDttm);
        writer.WriteStringValue("last_state", LastState);
        writer.WriteDoubleValue("last_value", LastValue);
        writer.WriteStringValue("last_value_row_json", LastValueRowJson);
        writer.WriteIntValue("log_retention", LogRetention);
        writer.WriteStringValue("name", Name);
        writer.WriteObjectValue<KClient.Models.ReportScheduleRestApi.Get.User>("owners", Owners);
        writer.WriteObjectValue<KClient.Models.ReportScheduleRestApi.Get.ReportRecipients>("recipients", Recipients);
        writer.WriteStringValue("report_format", ReportFormat);
        writer.WriteStringValue("sql", Sql);
        writer.WriteStringValue("timezone", Timezone);
        writer.WriteStringValue("type", Type);
        writer.WriteStringValue("validator_config_json", ValidatorConfigJson);
        writer.WriteStringValue("validator_type", ValidatorType);
        writer.WriteIntValue("working_timeout", WorkingTimeout);
        writer.WriteAdditionalData(AdditionalData);
    }
}
