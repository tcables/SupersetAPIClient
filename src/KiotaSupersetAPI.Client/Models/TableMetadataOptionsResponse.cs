
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class TableMetadataOptionsResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The deferrable property</summary>
    public bool? Deferrable { get; set; }
    /// <summary>The initially property</summary>
    public bool? Initially { get; set; }
    /// <summary>The match property</summary>
    public bool? Match { get; set; }
    /// <summary>The ondelete property</summary>
    public bool? Ondelete { get; set; }
    /// <summary>The onupdate property</summary>
    public bool? Onupdate { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="Models.TableMetadataOptionsResponse"/> and sets the default values.
    /// </summary>
    public TableMetadataOptionsResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.TableMetadataOptionsResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.TableMetadataOptionsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.TableMetadataOptionsResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "deferrable", n => { Deferrable = n.GetBoolValue(); } },
            { "initially", n => { Initially = n.GetBoolValue(); } },
            { "match", n => { Match = n.GetBoolValue(); } },
            { "ondelete", n => { Ondelete = n.GetBoolValue(); } },
            { "onupdate", n => { Onupdate = n.GetBoolValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteBoolValue("deferrable", Deferrable);
        writer.WriteBoolValue("initially", Initially);
        writer.WriteBoolValue("match", Match);
        writer.WriteBoolValue("ondelete", Ondelete);
        writer.WriteBoolValue("onupdate", Onupdate);
        writer.WriteAdditionalData(AdditionalData);
    }
}
