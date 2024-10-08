
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Tag.Get_objects;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Get_objectsGetResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The result property</summary>
    public List<Models.TaggedObjectEntityResponseSchema> Result { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Tag.Get_objects.Get_objectsGetResponse"/> and sets the default values.
    /// </summary>
    public Get_objectsGetResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Tag.Get_objects.Get_objectsGetResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Tag.Get_objects.Get_objectsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Get_objects.Get_objectsGetResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "result", n => { Result = n.GetCollectionOfObjectValues<Models.TaggedObjectEntityResponseSchema>(Models.TaggedObjectEntityResponseSchema.CreateFromDiscriminatorValue)?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteCollectionOfObjectValues<Models.TaggedObjectEntityResponseSchema>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
