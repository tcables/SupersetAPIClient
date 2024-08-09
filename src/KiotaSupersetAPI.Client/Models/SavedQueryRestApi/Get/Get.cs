
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.SavedQueryRestApi.Get;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Get : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The changed_by property</summary>
    public Models.SavedQueryRestApi.Get.User1 ChangedBy { get; set; }

    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The changed_on_delta_humanized property</summary>
    public UntypedNode ChangedOnDeltaHumanized { get; private set; }

    /// <summary>The created_by property</summary>
    public Models.SavedQueryRestApi.Get.User CreatedBy { get; set; }

    /// <summary>The database property</summary>
    public Models.SavedQueryRestApi.Get.Database Database { get; set; }

    /// <summary>The description property</summary>
    public string Description { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The label property</summary>
    public string Label { get; set; }

    /// <summary>The schema property</summary>
    public string Schema { get; set; }

    /// <summary>The sql property</summary>
    public string Sql { get; set; }

    /// <summary>The sql_tables property</summary>
    public UntypedNode SqlTables { get; private set; }

    /// <summary>The template_parameters property</summary>
    public string TemplateParameters { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.SavedQueryRestApi.Get.Get"/> and sets the default values.
    /// </summary>
    public Get()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.SavedQueryRestApi.Get.Get"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.SavedQueryRestApi.Get.Get CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.SavedQueryRestApi.Get.Get();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "changed_by", n => { ChangedBy = n.GetObjectValue<Models.SavedQueryRestApi.Get.User1>(Models.SavedQueryRestApi.Get.User1.CreateFromDiscriminatorValue); } },
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "created_by", n => { CreatedBy = n.GetObjectValue<Models.SavedQueryRestApi.Get.User>(Models.SavedQueryRestApi.Get.User.CreateFromDiscriminatorValue); } },
            { "database", n => { Database = n.GetObjectValue<Models.SavedQueryRestApi.Get.Database>(Models.SavedQueryRestApi.Get.Database.CreateFromDiscriminatorValue); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "label", n => { Label = n.GetStringValue(); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "sql_tables", n => { SqlTables = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "template_parameters", n => { TemplateParameters = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<Models.SavedQueryRestApi.Get.User1>("changed_by", ChangedBy);
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteObjectValue<Models.SavedQueryRestApi.Get.User>("created_by", CreatedBy);
        writer.WriteObjectValue<Models.SavedQueryRestApi.Get.Database>("database", Database);
        writer.WriteStringValue("description", Description);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("label", Label);
        writer.WriteStringValue("schema", Schema);
        writer.WriteStringValue("sql", Sql);
        writer.WriteStringValue("template_parameters", TemplateParameters);
        writer.WriteAdditionalData(AdditionalData);
    }
}
