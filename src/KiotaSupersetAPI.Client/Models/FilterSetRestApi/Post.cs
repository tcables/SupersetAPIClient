
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.FilterSetRestApi;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Post : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The description property</summary>
    public string Description { get; set; }

    /// <summary>The json_metadata property</summary>
    public string JsonMetadata { get; set; }

    /// <summary>The name property</summary>
    public string Name { get; set; }

    /// <summary>The owner_id property</summary>
    public int? OwnerId { get; set; }
    /// <summary>The owner_type property</summary>
    public Models.FilterSetRestApi.Post_owner_type? OwnerType { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="Models.FilterSetRestApi.Post"/> and sets the default values.
    /// </summary>
    public Post()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.FilterSetRestApi.Post"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.FilterSetRestApi.Post CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.FilterSetRestApi.Post();
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
            { "json_metadata", n => { JsonMetadata = n.GetStringValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "owner_id", n => { OwnerId = n.GetIntValue(); } },
            { "owner_type", n => { OwnerType = n.GetEnumValue<Models.FilterSetRestApi.Post_owner_type>(); } },
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
        writer.WriteStringValue("json_metadata", JsonMetadata);
        writer.WriteStringValue("name", Name);
        writer.WriteIntValue("owner_id", OwnerId);
        writer.WriteEnumValue<Models.FilterSetRestApi.Post_owner_type>("owner_type", OwnerType);
        writer.WriteAdditionalData(AdditionalData);
    }
}
