
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Database.Item.Tables;

[GeneratedCode("Kiota", "1.16.0")]
public partial class TablesGetResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The count property</summary>
    public int? Count { get; set; }
    /// <summary>A List of tables for given database</summary>
    public List<Models.DatabaseTablesResponse> Result { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Tables.TablesGetResponse"/> and sets the default values.
    /// </summary>
    public TablesGetResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Database.Item.Tables.TablesGetResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Database.Item.Tables.TablesGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Item.Tables.TablesGetResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "count", n => { Count = n.GetIntValue(); } },
            { "result", n => { Result = n.GetCollectionOfObjectValues<Models.DatabaseTablesResponse>(Models.DatabaseTablesResponse.CreateFromDiscriminatorValue)?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("count", Count);
        writer.WriteCollectionOfObjectValues<Models.DatabaseTablesResponse>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
