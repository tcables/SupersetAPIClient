
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.TagRestAPI;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Put : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The description property</summary>
    public string Description { get; set; }

    /// <summary>The name property</summary>
    public string Name { get; set; }

    /// <summary>The objects_to_tag property</summary>
    public UntypedNode ObjectsToTag { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.TagRestAPI.Put"/> and sets the default values.
    /// </summary>
    public Put()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.TagRestAPI.Put"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.TagRestAPI.Put CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.TagRestAPI.Put();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "description", n => { Description = n.GetStringValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "objects_to_tag", n => { ObjectsToTag = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("description", Description);
        writer.WriteStringValue("name", Name);
        writer.WriteObjectValue<UntypedNode>("objects_to_tag", ObjectsToTag);
        writer.WriteAdditionalData(AdditionalData);
    }
}
