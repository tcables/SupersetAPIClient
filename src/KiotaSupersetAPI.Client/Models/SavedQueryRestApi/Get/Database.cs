
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.SavedQueryRestAPI.Get;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Database : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The database_name property</summary>
    public string DatabaseName { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="Models.SavedQueryRestAPI.Get.Database"/> and sets the default values.
    /// </summary>
    public Database()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.SavedQueryRestAPI.Get.Database"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.SavedQueryRestAPI.Get.Database CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.SavedQueryRestAPI.Get.Database();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "database_name", n => { DatabaseName = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("database_name", DatabaseName);
        writer.WriteIntValue("id", Id);
        writer.WriteAdditionalData(AdditionalData);
    }
}
