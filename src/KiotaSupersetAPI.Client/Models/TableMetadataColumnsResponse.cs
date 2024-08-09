
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class TableMetadataColumnsResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The duplicates_constraint property</summary>
    public string DuplicatesConstraint { get; set; }

    /// <summary>The keys property</summary>
    public List<string> Keys { get; set; }

    /// <summary>The actual backend long type for the column</summary>
    public string LongType { get; set; }

    /// <summary>The column name</summary>
    public string Name { get; set; }

    /// <summary>The column type</summary>
    public string Type { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.TableMetadataColumnsResponse"/> and sets the default values.
    /// </summary>
    public TableMetadataColumnsResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.TableMetadataColumnsResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.TableMetadataColumnsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.TableMetadataColumnsResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "duplicates_constraint", n => { DuplicatesConstraint = n.GetStringValue(); } },
            { "keys", n => { Keys = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "longType", n => { LongType = n.GetStringValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
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
        writer.WriteStringValue("duplicates_constraint", DuplicatesConstraint);
        writer.WriteCollectionOfPrimitiveValues<string>("keys", Keys);
        writer.WriteStringValue("longType", LongType);
        writer.WriteStringValue("name", Name);
        writer.WriteStringValue("type", Type);
        writer.WriteAdditionalData(AdditionalData);
    }
}
