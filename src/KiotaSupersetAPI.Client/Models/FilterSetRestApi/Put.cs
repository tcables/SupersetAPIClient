
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.FilterSetRestApi;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Put : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The description property</summary>
    public string Description { get; set; }

    /// <summary>The json_metadata property</summary>
    public string JsonMetadata { get; set; }

    /// <summary>The name property</summary>
    public string Name { get; set; }

    /// <summary>The owner_type property</summary>
    public KClient.Models.FilterSetRestApi.Put_owner_type? OwnerType { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.FilterSetRestApi.Put"/> and sets the default values.
    /// </summary>
    public Put()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.FilterSetRestApi.Put"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.FilterSetRestApi.Put CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.FilterSetRestApi.Put();
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
            { "owner_type", n => { OwnerType = n.GetEnumValue<KClient.Models.FilterSetRestApi.Put_owner_type>(); } },
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
        writer.WriteEnumValue<KClient.Models.FilterSetRestApi.Put_owner_type>("owner_type", OwnerType);
        writer.WriteAdditionalData(AdditionalData);
    }
}
