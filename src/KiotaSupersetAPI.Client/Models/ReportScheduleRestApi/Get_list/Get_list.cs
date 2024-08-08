
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.ReportScheduleRestApi.Get_list;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Get_list : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>The active property</summary>
    public bool? Active { get; set; }
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The changed_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.ReportScheduleRestApi.Get_list.User? ChangedBy { get; set; }
#nullable restore
#else
    public KClient.Models.ReportScheduleRestApi.Get_list.User ChangedBy { get; set; }
#endif
    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The changed_on_delta_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? ChangedOnDeltaHumanized { get; private set; }
#nullable restore
#else
    public UntypedNode ChangedOnDeltaHumanized { get; private set; }
#endif
    /// <summary>The chart_id property</summary>
    public int? ChartId { get; set; }
    /// <summary>The created_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.ReportScheduleRestApi.Get_list.User1? CreatedBy { get; set; }
#nullable restore
#else
    public KClient.Models.ReportScheduleRestApi.Get_list.User1 CreatedBy { get; set; }
#endif
    /// <summary>The created_on property</summary>
    public DateTimeOffset? CreatedOn { get; set; }
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
    /// <summary>The crontab_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? CrontabHumanized { get; private set; }
#nullable restore
#else
    public UntypedNode CrontabHumanized { get; private set; }
#endif
    /// <summary>The dashboard_id property</summary>
    public int? DashboardId { get; set; }
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
    public KClient.Models.ReportScheduleRestApi.Get_list.User2? Owners { get; set; }
#nullable restore
#else
    public KClient.Models.ReportScheduleRestApi.Get_list.User2 Owners { get; set; }
#endif
    /// <summary>The recipients property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.ReportScheduleRestApi.Get_list.ReportRecipients? Recipients { get; set; }
#nullable restore
#else
    public KClient.Models.ReportScheduleRestApi.Get_list.ReportRecipients Recipients { get; set; }
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
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.ReportScheduleRestApi.Get_list.Get_list"/> and sets the default values.
    /// </summary>
    public Get_list()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ReportScheduleRestApi.Get_list.Get_list"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.ReportScheduleRestApi.Get_list.Get_list CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.ReportScheduleRestApi.Get_list.Get_list();
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
            { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.ReportScheduleRestApi.Get_list.User>(KClient.Models.ReportScheduleRestApi.Get_list.User.CreateFromDiscriminatorValue); } },
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "chart_id", n => { ChartId = n.GetIntValue(); } },
            { "created_by", n => { CreatedBy = n.GetObjectValue<KClient.Models.ReportScheduleRestApi.Get_list.User1>(KClient.Models.ReportScheduleRestApi.Get_list.User1.CreateFromDiscriminatorValue); } },
            { "created_on", n => { CreatedOn = n.GetDateTimeOffsetValue(); } },
            { "creation_method", n => { CreationMethod = n.GetStringValue(); } },
            { "crontab", n => { Crontab = n.GetStringValue(); } },
            { "crontab_humanized", n => { CrontabHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "dashboard_id", n => { DashboardId = n.GetIntValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "extra", n => { Extra = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "last_eval_dttm", n => { LastEvalDttm = n.GetDateTimeOffsetValue(); } },
            { "last_state", n => { LastState = n.GetStringValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "owners", n => { Owners = n.GetObjectValue<KClient.Models.ReportScheduleRestApi.Get_list.User2>(KClient.Models.ReportScheduleRestApi.Get_list.User2.CreateFromDiscriminatorValue); } },
            { "recipients", n => { Recipients = n.GetObjectValue<KClient.Models.ReportScheduleRestApi.Get_list.ReportRecipients>(KClient.Models.ReportScheduleRestApi.Get_list.ReportRecipients.CreateFromDiscriminatorValue); } },
            { "timezone", n => { Timezone = n.GetStringValue(); } },
            { "type", n => { Type = n.GetStringValue(); } },
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
        writer.WriteObjectValue<KClient.Models.ReportScheduleRestApi.Get_list.User>("changed_by", ChangedBy);
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteIntValue("chart_id", ChartId);
        writer.WriteObjectValue<KClient.Models.ReportScheduleRestApi.Get_list.User1>("created_by", CreatedBy);
        writer.WriteDateTimeOffsetValue("created_on", CreatedOn);
        writer.WriteStringValue("creation_method", CreationMethod);
        writer.WriteStringValue("crontab", Crontab);
        writer.WriteIntValue("dashboard_id", DashboardId);
        writer.WriteStringValue("description", Description);
        writer.WriteIntValue("id", Id);
        writer.WriteDateTimeOffsetValue("last_eval_dttm", LastEvalDttm);
        writer.WriteStringValue("last_state", LastState);
        writer.WriteStringValue("name", Name);
        writer.WriteObjectValue<KClient.Models.ReportScheduleRestApi.Get_list.User2>("owners", Owners);
        writer.WriteObjectValue<KClient.Models.ReportScheduleRestApi.Get_list.ReportRecipients>("recipients", Recipients);
        writer.WriteStringValue("timezone", Timezone);
        writer.WriteStringValue("type", Type);
        writer.WriteAdditionalData(AdditionalData);
    }
}
