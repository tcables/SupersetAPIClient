
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.SavedQueryRestApi.Get;

[GeneratedCode("Kiota", "1.16.0")]
public partial class User : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The first_name property</summary>
    public string FirstName { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The last_name property</summary>
    public string LastName { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.SavedQueryRestApi.Get.User"/> and sets the default values.
    /// </summary>
    public User()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.SavedQueryRestApi.Get.User"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.SavedQueryRestApi.Get.User CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.SavedQueryRestApi.Get.User();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "first_name", n => { FirstName = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "last_name", n => { LastName = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("first_name", FirstName);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("last_name", LastName);
        writer.WriteAdditionalData(AdditionalData);
    }
}
