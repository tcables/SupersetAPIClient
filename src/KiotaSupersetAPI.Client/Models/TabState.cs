
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class TabState : IAdditionalDataHolder, IParsable
{
    /// <summary>The active property</summary>
    public bool? Active { get; set; }
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The autorun property</summary>
    public bool? Autorun { get; set; }
    /// <summary>The database_id property</summary>
    public int? DatabaseId { get; set; }
    /// <summary>The extra_json property</summary>
    public KClient.Models.TabState_extra_json ExtraJson { get; set; }

    /// <summary>The hide_left_bar property</summary>
    public bool? HideLeftBar { get; set; }
    /// <summary>The id property</summary>
    public string Id { get; set; }

    /// <summary>The label property</summary>
    public string Label { get; set; }

    /// <summary>The latest_query property</summary>
    public KClient.Models.QueryResult LatestQuery { get; set; }

    /// <summary>The query_limit property</summary>
    public int? QueryLimit { get; set; }
    /// <summary>The saved_query property</summary>
    public KClient.Models.TabState_saved_query SavedQuery { get; set; }

    /// <summary>The schema property</summary>
    public string Schema { get; set; }

    /// <summary>The sql property</summary>
    public string Sql { get; set; }

    /// <summary>The table_schemas property</summary>
    public List<KClient.Models.Table> TableSchemas { get; set; }

    /// <summary>The user_id property</summary>
    public int? UserId { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.TabState"/> and sets the default values.
    /// </summary>
    public TabState()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.TabState"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.TabState CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.TabState();
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
            { "autorun", n => { Autorun = n.GetBoolValue(); } },
            { "database_id", n => { DatabaseId = n.GetIntValue(); } },
            { "extra_json", n => { ExtraJson = n.GetObjectValue<KClient.Models.TabState_extra_json>(KClient.Models.TabState_extra_json.CreateFromDiscriminatorValue); } },
            { "hide_left_bar", n => { HideLeftBar = n.GetBoolValue(); } },
            { "id", n => { Id = n.GetStringValue(); } },
            { "label", n => { Label = n.GetStringValue(); } },
            { "latest_query", n => { LatestQuery = n.GetObjectValue<KClient.Models.QueryResult>(KClient.Models.QueryResult.CreateFromDiscriminatorValue); } },
            { "query_limit", n => { QueryLimit = n.GetIntValue(); } },
            { "saved_query", n => { SavedQuery = n.GetObjectValue<KClient.Models.TabState_saved_query>(KClient.Models.TabState_saved_query.CreateFromDiscriminatorValue); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "table_schemas", n => { TableSchemas = n.GetCollectionOfObjectValues<KClient.Models.Table>(KClient.Models.Table.CreateFromDiscriminatorValue)?.ToList(); } },
            { "user_id", n => { UserId = n.GetIntValue(); } },
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
        writer.WriteBoolValue("autorun", Autorun);
        writer.WriteIntValue("database_id", DatabaseId);
        writer.WriteObjectValue<KClient.Models.TabState_extra_json>("extra_json", ExtraJson);
        writer.WriteBoolValue("hide_left_bar", HideLeftBar);
        writer.WriteStringValue("id", Id);
        writer.WriteStringValue("label", Label);
        writer.WriteObjectValue<KClient.Models.QueryResult>("latest_query", LatestQuery);
        writer.WriteIntValue("query_limit", QueryLimit);
        writer.WriteObjectValue<KClient.Models.TabState_saved_query>("saved_query", SavedQuery);
        writer.WriteStringValue("schema", Schema);
        writer.WriteStringValue("sql", Sql);
        writer.WriteCollectionOfObjectValues<KClient.Models.Table>("table_schemas", TableSchemas);
        writer.WriteIntValue("user_id", UserId);
        writer.WriteAdditionalData(AdditionalData);
    }
}
