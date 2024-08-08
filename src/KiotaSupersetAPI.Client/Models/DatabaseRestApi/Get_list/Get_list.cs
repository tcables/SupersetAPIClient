
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.DatabaseRestApi.Get_list;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Get_list : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The allow_ctas property</summary>
    public bool? AllowCtas { get; set; }
    /// <summary>The allow_cvas property</summary>
    public bool? AllowCvas { get; set; }
    /// <summary>The allow_dml property</summary>
    public bool? AllowDml { get; set; }
    /// <summary>The allow_file_upload property</summary>
    public bool? AllowFileUpload { get; set; }
    /// <summary>The allow_run_async property</summary>
    public bool? AllowRunAsync { get; set; }
    /// <summary>The allows_cost_estimate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? AllowsCostEstimate { get; private set; }
#nullable restore
#else
    public UntypedNode AllowsCostEstimate { get; private set; }
#endif
    /// <summary>The allows_subquery property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? AllowsSubquery { get; private set; }
#nullable restore
#else
    public UntypedNode AllowsSubquery { get; private set; }
#endif
    /// <summary>The allows_virtual_table_explore property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? AllowsVirtualTableExplore { get; private set; }
#nullable restore
#else
    public UntypedNode AllowsVirtualTableExplore { get; private set; }
#endif
    /// <summary>The backend property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? Backend { get; private set; }
#nullable restore
#else
    public UntypedNode Backend { get; private set; }
#endif
    /// <summary>The changed_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.DatabaseRestApi.Get_list.User? ChangedBy { get; set; }
#nullable restore
#else
    public KClient.Models.DatabaseRestApi.Get_list.User ChangedBy { get; set; }
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
    /// <summary>The created_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.DatabaseRestApi.Get_list.User1? CreatedBy { get; set; }
#nullable restore
#else
    public KClient.Models.DatabaseRestApi.Get_list.User1 CreatedBy { get; set; }
#endif
    /// <summary>The database_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? DatabaseName { get; set; }
#nullable restore
#else
    public string DatabaseName { get; set; }
#endif
    /// <summary>The disable_data_preview property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? DisableDataPreview { get; private set; }
#nullable restore
#else
    public UntypedNode DisableDataPreview { get; private set; }
#endif
    /// <summary>The engine_information property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? EngineInformation { get; private set; }
#nullable restore
#else
    public UntypedNode EngineInformation { get; private set; }
#endif
    /// <summary>The explore_database_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? ExploreDatabaseId { get; private set; }
#nullable restore
#else
    public UntypedNode ExploreDatabaseId { get; private set; }
#endif
    /// <summary>The expose_in_sqllab property</summary>
    public bool? ExposeInSqllab { get; set; }
    /// <summary>The extra property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Extra { get; set; }
#nullable restore
#else
    public string Extra { get; set; }
#endif
    /// <summary>The force_ctas_schema property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ForceCtasSchema { get; set; }
#nullable restore
#else
    public string ForceCtasSchema { get; set; }
#endif
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The uuid property</summary>
    public Guid? Uuid { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DatabaseRestApi.Get_list.Get_list"/> and sets the default values.
    /// </summary>
    public Get_list()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatabaseRestApi.Get_list.Get_list"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DatabaseRestApi.Get_list.Get_list CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DatabaseRestApi.Get_list.Get_list();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "allow_ctas", n => { AllowCtas = n.GetBoolValue(); } },
            { "allow_cvas", n => { AllowCvas = n.GetBoolValue(); } },
            { "allow_dml", n => { AllowDml = n.GetBoolValue(); } },
            { "allow_file_upload", n => { AllowFileUpload = n.GetBoolValue(); } },
            { "allow_run_async", n => { AllowRunAsync = n.GetBoolValue(); } },
            { "allows_cost_estimate", n => { AllowsCostEstimate = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "allows_subquery", n => { AllowsSubquery = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "allows_virtual_table_explore", n => { AllowsVirtualTableExplore = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "backend", n => { Backend = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.DatabaseRestApi.Get_list.User>(KClient.Models.DatabaseRestApi.Get_list.User.CreateFromDiscriminatorValue); } },
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "created_by", n => { CreatedBy = n.GetObjectValue<KClient.Models.DatabaseRestApi.Get_list.User1>(KClient.Models.DatabaseRestApi.Get_list.User1.CreateFromDiscriminatorValue); } },
            { "database_name", n => { DatabaseName = n.GetStringValue(); } },
            { "disable_data_preview", n => { DisableDataPreview = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "engine_information", n => { EngineInformation = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "explore_database_id", n => { ExploreDatabaseId = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "expose_in_sqllab", n => { ExposeInSqllab = n.GetBoolValue(); } },
            { "extra", n => { Extra = n.GetStringValue(); } },
            { "force_ctas_schema", n => { ForceCtasSchema = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "uuid", n => { Uuid = n.GetGuidValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteBoolValue("allow_ctas", AllowCtas);
        writer.WriteBoolValue("allow_cvas", AllowCvas);
        writer.WriteBoolValue("allow_dml", AllowDml);
        writer.WriteBoolValue("allow_file_upload", AllowFileUpload);
        writer.WriteBoolValue("allow_run_async", AllowRunAsync);
        writer.WriteObjectValue<KClient.Models.DatabaseRestApi.Get_list.User>("changed_by", ChangedBy);
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteObjectValue<KClient.Models.DatabaseRestApi.Get_list.User1>("created_by", CreatedBy);
        writer.WriteStringValue("database_name", DatabaseName);
        writer.WriteBoolValue("expose_in_sqllab", ExposeInSqllab);
        writer.WriteStringValue("extra", Extra);
        writer.WriteStringValue("force_ctas_schema", ForceCtasSchema);
        writer.WriteIntValue("id", Id);
        writer.WriteGuidValue("uuid", Uuid);
        writer.WriteAdditionalData(AdditionalData);
    }
}
