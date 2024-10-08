
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.ReportScheduleRestAPI;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Put : IAdditionalDataHolder, IParsable
{
    /// <summary>The active property</summary>
    public bool? Active { get; set; }
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The chart property</summary>
    public int? Chart { get; set; }
    /// <summary>Markdown description</summary>
    public string ContextMarkdown { get; set; }

    /// <summary>Creation method is used to inform the frontend whether the report/alert was created in the dashboard, chart, or alerts and reports UI.</summary>
    public Models.ReportScheduleRestAPI.Put_creation_method? CreationMethod { get; set; }
    /// <summary>A CRON expression.[Crontab Guru](https://crontab.guru/) is a helpful resource that can help you craft a CRON expression.</summary>
    public string Crontab { get; set; }

    /// <summary>Custom width of the screenshot in pixels</summary>
    public int? CustomWidth { get; set; }
    /// <summary>The dashboard property</summary>
    public int? Dashboard { get; set; }
    /// <summary>The database property</summary>
    public int? Database { get; set; }
    /// <summary>Use a nice description to give context to this Alert/Report</summary>
    public string Description { get; set; }

    /// <summary>The extra property</summary>
    public Models.ReportScheduleRestAPI.Put_extra Extra { get; set; }

    /// <summary>The force_screenshot property</summary>
    public bool? ForceScreenshot { get; set; }
    /// <summary>Once an alert is triggered, how long, in seconds, before Superset nags you again. (in seconds)</summary>
    public int? GracePeriod { get; set; }
    /// <summary>How long to keep the logs around for this report (in days)</summary>
    public int? LogRetention { get; set; }
    /// <summary>The report schedule name.</summary>
    public string Name { get; set; }

    /// <summary>The owners property</summary>
    public List<int?> Owners { get; set; }

    /// <summary>The recipients property</summary>
    public List<Models.ReportRecipient> Recipients { get; set; }

    /// <summary>The report_format property</summary>
    public Models.ReportScheduleRestAPI.Put_report_format? ReportFormat { get; set; }
    /// <summary>A SQL statement that defines whether the alert should get triggered or not. The query is expected to return either NULL or a number value.</summary>
    public string Sql { get; set; }

    /// <summary>A timezone string that represents the location of the timezone.</summary>
    public Models.ReportScheduleRestAPI.Put_timezone? Timezone { get; set; }
    /// <summary>The report schedule type</summary>
    public Models.ReportScheduleRestAPI.Put_type? Type { get; set; }
    /// <summary>The validator_config_json property</summary>
    public Models.ValidatorConfigJSON ValidatorConfigJson { get; set; }

    /// <summary>Determines when to trigger alert based off value from alert query. Alerts will be triggered with these validator types:- Not Null - When the return value is Not NULL, Empty, or 0- Operator - When `sql_return_value comparison_operator threshold` is True e.g. `50 &lt;= 75`&lt;br&gt;Supports the comparison operators &lt;, &lt;=, &gt;, &gt;=, ==, and !=</summary>
    public Models.ReportScheduleRestAPI.Put_validator_type? ValidatorType { get; set; }
    /// <summary>If an alert is staled at a working state, how long until it&apos;s state is reset to error</summary>
    public int? WorkingTimeout { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="Models.ReportScheduleRestAPI.Put"/> and sets the default values.
    /// </summary>
    public Put()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.ReportScheduleRestAPI.Put"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.ReportScheduleRestAPI.Put CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.ReportScheduleRestAPI.Put();
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
            { "chart", n => { Chart = n.GetIntValue(); } },
            { "context_markdown", n => { ContextMarkdown = n.GetStringValue(); } },
            { "creation_method", n => { CreationMethod = n.GetEnumValue<Models.ReportScheduleRestAPI.Put_creation_method>(); } },
            { "crontab", n => { Crontab = n.GetStringValue(); } },
            { "custom_width", n => { CustomWidth = n.GetIntValue(); } },
            { "dashboard", n => { Dashboard = n.GetIntValue(); } },
            { "database", n => { Database = n.GetIntValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "extra", n => { Extra = n.GetObjectValue<Models.ReportScheduleRestAPI.Put_extra>(Models.ReportScheduleRestAPI.Put_extra.CreateFromDiscriminatorValue); } },
            { "force_screenshot", n => { ForceScreenshot = n.GetBoolValue(); } },
            { "grace_period", n => { GracePeriod = n.GetIntValue(); } },
            { "log_retention", n => { LogRetention = n.GetIntValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "owners", n => { Owners = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            { "recipients", n => { Recipients = n.GetCollectionOfObjectValues<Models.ReportRecipient>(Models.ReportRecipient.CreateFromDiscriminatorValue)?.ToList(); } },
            { "report_format", n => { ReportFormat = n.GetEnumValue<Models.ReportScheduleRestAPI.Put_report_format>(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "timezone", n => { Timezone = n.GetEnumValue<Models.ReportScheduleRestAPI.Put_timezone>(); } },
            { "type", n => { Type = n.GetEnumValue<Models.ReportScheduleRestAPI.Put_type>(); } },
            { "validator_config_json", n => { ValidatorConfigJson = n.GetObjectValue<Models.ValidatorConfigJSON>(Models.ValidatorConfigJSON.CreateFromDiscriminatorValue); } },
            { "validator_type", n => { ValidatorType = n.GetEnumValue<Models.ReportScheduleRestAPI.Put_validator_type>(); } },
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
        writer.WriteIntValue("chart", Chart);
        writer.WriteStringValue("context_markdown", ContextMarkdown);
        writer.WriteEnumValue<Models.ReportScheduleRestAPI.Put_creation_method>("creation_method", CreationMethod);
        writer.WriteStringValue("crontab", Crontab);
        writer.WriteIntValue("custom_width", CustomWidth);
        writer.WriteIntValue("dashboard", Dashboard);
        writer.WriteIntValue("database", Database);
        writer.WriteStringValue("description", Description);
        writer.WriteObjectValue<Models.ReportScheduleRestAPI.Put_extra>("extra", Extra);
        writer.WriteBoolValue("force_screenshot", ForceScreenshot);
        writer.WriteIntValue("grace_period", GracePeriod);
        writer.WriteIntValue("log_retention", LogRetention);
        writer.WriteStringValue("name", Name);
        writer.WriteCollectionOfPrimitiveValues<int?>("owners", Owners);
        writer.WriteCollectionOfObjectValues<Models.ReportRecipient>("recipients", Recipients);
        writer.WriteEnumValue<Models.ReportScheduleRestAPI.Put_report_format>("report_format", ReportFormat);
        writer.WriteStringValue("sql", Sql);
        writer.WriteEnumValue<Models.ReportScheduleRestAPI.Put_timezone>("timezone", Timezone);
        writer.WriteEnumValue<Models.ReportScheduleRestAPI.Put_type>("type", Type);
        writer.WriteObjectValue<Models.ValidatorConfigJSON>("validator_config_json", ValidatorConfigJson);
        writer.WriteEnumValue<Models.ReportScheduleRestAPI.Put_validator_type>("validator_type", ValidatorType);
        writer.WriteIntValue("working_timeout", WorkingTimeout);
        writer.WriteAdditionalData(AdditionalData);
    }
}
