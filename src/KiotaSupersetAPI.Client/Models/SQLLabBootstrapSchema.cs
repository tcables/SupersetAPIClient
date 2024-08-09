
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class SQLLabBootstrapSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>The active_tab property</summary>
    public Models.TabState ActiveTab { get; set; }

    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The databases property</summary>
    public Models.SQLLabBootstrapSchema_databases Databases { get; set; }

    /// <summary>The queries property</summary>
    public Models.SQLLabBootstrapSchema_queries Queries { get; set; }

    /// <summary>The tab_state_ids property</summary>
    public List<string> TabStateIds { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.SQLLabBootstrapSchema"/> and sets the default values.
    /// </summary>
    public SQLLabBootstrapSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.SQLLabBootstrapSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.SQLLabBootstrapSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.SQLLabBootstrapSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "active_tab", n => { ActiveTab = n.GetObjectValue<Models.TabState>(Models.TabState.CreateFromDiscriminatorValue); } },
            { "databases", n => { Databases = n.GetObjectValue<Models.SQLLabBootstrapSchema_databases>(Models.SQLLabBootstrapSchema_databases.CreateFromDiscriminatorValue); } },
            { "queries", n => { Queries = n.GetObjectValue<Models.SQLLabBootstrapSchema_queries>(Models.SQLLabBootstrapSchema_queries.CreateFromDiscriminatorValue); } },
            { "tab_state_ids", n => { TabStateIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<Models.TabState>("active_tab", ActiveTab);
        writer.WriteObjectValue<Models.SQLLabBootstrapSchema_databases>("databases", Databases);
        writer.WriteObjectValue<Models.SQLLabBootstrapSchema_queries>("queries", Queries);
        writer.WriteCollectionOfPrimitiveValues<string>("tab_state_ids", TabStateIds);
        writer.WriteAdditionalData(AdditionalData);
    }
}
