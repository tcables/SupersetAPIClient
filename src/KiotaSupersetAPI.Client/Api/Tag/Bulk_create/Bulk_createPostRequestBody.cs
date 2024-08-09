
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Tag.Bulk_create;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Bulk_createPostRequestBody : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>list of object names to add to object</summary>
    public List<UntypedNode> ObjectsToTag { get; set; }

    /// <summary>list of tag names to add to object</summary>
    public List<string> Tags { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Tag.Bulk_create.Bulk_createPostRequestBody"/> and sets the default values.
    /// </summary>
    public Bulk_createPostRequestBody()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Tag.Bulk_create.Bulk_createPostRequestBody"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Tag.Bulk_create.Bulk_createPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Tag.Bulk_create.Bulk_createPostRequestBody();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "objects_to_tag", n => { ObjectsToTag = n.GetCollectionOfPrimitiveValues<UntypedNode>()?.ToList(); } },
            { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteCollectionOfPrimitiveValues<UntypedNode>("objects_to_tag", ObjectsToTag);
        writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
        writer.WriteAdditionalData(AdditionalData);
    }
}
