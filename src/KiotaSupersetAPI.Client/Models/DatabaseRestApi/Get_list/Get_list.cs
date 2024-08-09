
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.DatabaseRestAPI.Get_list;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Get_list : IAdditionalDataHolder, IParsable
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
    public UntypedNode AllowsCostEstimate { get; private set; }

    /// <summary>The allows_subquery property</summary>
    public UntypedNode AllowsSubquery { get; private set; }

    /// <summary>The allows_virtual_table_explore property</summary>
    public UntypedNode AllowsVirtualTableExplore { get; private set; }

    /// <summary>The backend property</summary>
    public UntypedNode Backend { get; private set; }

    /// <summary>The changed_by property</summary>
    public Models.DatabaseRestAPI.Get_list.User ChangedBy { get; set; }

    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The changed_on_delta_humanized property</summary>
    public UntypedNode ChangedOnDeltaHumanized { get; private set; }

    /// <summary>The created_by property</summary>
    public Models.DatabaseRestAPI.Get_list.User1 CreatedBy { get; set; }

    /// <summary>The database_name property</summary>
    public string DatabaseName { get; set; }

    /// <summary>The disable_data_preview property</summary>
    public UntypedNode DisableDataPreview { get; private set; }

    /// <summary>The engine_information property</summary>
    public UntypedNode EngineInformation { get; private set; }

    /// <summary>The explore_database_id property</summary>
    public UntypedNode ExploreDatabaseId { get; private set; }

    /// <summary>The expose_in_sqllab property</summary>
    public bool? ExposeInSqllab { get; set; }
    /// <summary>The extra property</summary>
    public string Extra { get; set; }

    /// <summary>The force_ctas_schema property</summary>
    public string ForceCtasSchema { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The uuid property</summary>
    public Guid? Uuid { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="Models.DatabaseRestAPI.Get_list.Get_list"/> and sets the default values.
    /// </summary>
    public Get_list()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.DatabaseRestAPI.Get_list.Get_list"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.DatabaseRestAPI.Get_list.Get_list CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.DatabaseRestAPI.Get_list.Get_list();
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
            { "changed_by", n => { ChangedBy = n.GetObjectValue<Models.DatabaseRestAPI.Get_list.User>(Models.DatabaseRestAPI.Get_list.User.CreateFromDiscriminatorValue); } },
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "created_by", n => { CreatedBy = n.GetObjectValue<Models.DatabaseRestAPI.Get_list.User1>(Models.DatabaseRestAPI.Get_list.User1.CreateFromDiscriminatorValue); } },
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
        writer.WriteObjectValue<Models.DatabaseRestAPI.Get_list.User>("changed_by", ChangedBy);
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteObjectValue<Models.DatabaseRestAPI.Get_list.User1>("created_by", CreatedBy);
        writer.WriteStringValue("database_name", DatabaseName);
        writer.WriteBoolValue("expose_in_sqllab", ExposeInSqllab);
        writer.WriteStringValue("extra", Extra);
        writer.WriteStringValue("force_ctas_schema", ForceCtasSchema);
        writer.WriteIntValue("id", Id);
        writer.WriteGuidValue("uuid", Uuid);
        writer.WriteAdditionalData(AdditionalData);
    }
}
