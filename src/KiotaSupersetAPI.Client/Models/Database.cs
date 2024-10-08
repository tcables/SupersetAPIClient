
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Database : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The allows_cost_estimate property</summary>
    public bool? AllowsCostEstimate { get; set; }
    /// <summary>The allows_subquery property</summary>
    public bool? AllowsSubquery { get; set; }
    /// <summary>The allows_virtual_table_explore property</summary>
    public bool? AllowsVirtualTableExplore { get; set; }
    /// <summary>The backend property</summary>
    public string Backend { get; set; }

    /// <summary>The disable_data_preview property</summary>
    public bool? DisableDataPreview { get; set; }
    /// <summary>The explore_database_id property</summary>
    public int? ExploreDatabaseId { get; set; }
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The name property</summary>
    public string Name { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.Database"/> and sets the default values.
    /// </summary>
    public Database()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.Database"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.Database CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.Database();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "allows_cost_estimate", n => { AllowsCostEstimate = n.GetBoolValue(); } },
            { "allows_subquery", n => { AllowsSubquery = n.GetBoolValue(); } },
            { "allows_virtual_table_explore", n => { AllowsVirtualTableExplore = n.GetBoolValue(); } },
            { "backend", n => { Backend = n.GetStringValue(); } },
            { "disable_data_preview", n => { DisableDataPreview = n.GetBoolValue(); } },
            { "explore_database_id", n => { ExploreDatabaseId = n.GetIntValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteBoolValue("allows_cost_estimate", AllowsCostEstimate);
        writer.WriteBoolValue("allows_subquery", AllowsSubquery);
        writer.WriteBoolValue("allows_virtual_table_explore", AllowsVirtualTableExplore);
        writer.WriteStringValue("backend", Backend);
        writer.WriteBoolValue("disable_data_preview", DisableDataPreview);
        writer.WriteIntValue("explore_database_id", ExploreDatabaseId);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("name", Name);
        writer.WriteAdditionalData(AdditionalData);
    }
}
