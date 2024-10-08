
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Table : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The database_id property</summary>
    public int? DatabaseId { get; set; }
    /// <summary>The description property</summary>
    public string Description { get; set; }

    /// <summary>The expanded property</summary>
    public bool? Expanded { get; set; }
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The schema property</summary>
    public string Schema { get; set; }

    /// <summary>The table property</summary>
    public string TableProp { get; set; }

    /// <summary>The tab_state_id property</summary>
    public int? TabStateId { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="Models.Table"/> and sets the default values.
    /// </summary>
    public Table()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.Table"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.Table CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.Table();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "database_id", n => { DatabaseId = n.GetIntValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "expanded", n => { Expanded = n.GetBoolValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "tab_state_id", n => { TabStateId = n.GetIntValue(); } },
            { "table", n => { TableProp = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("database_id", DatabaseId);
        writer.WriteStringValue("description", Description);
        writer.WriteBoolValue("expanded", Expanded);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("schema", Schema);
        writer.WriteStringValue("table", TableProp);
        writer.WriteIntValue("tab_state_id", TabStateId);
        writer.WriteAdditionalData(AdditionalData);
    }
}
