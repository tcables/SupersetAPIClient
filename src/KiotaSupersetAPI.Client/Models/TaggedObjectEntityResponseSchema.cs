
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class TaggedObjectEntityResponseSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The created_by property</summary>
    public KClient.Models.User CreatedBy { get; set; }

    /// <summary>The creator property</summary>
    public string Creator { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The name property</summary>
    public string Name { get; set; }

    /// <summary>The owners property</summary>
    public List<KClient.Models.User1> Owners { get; set; }

    /// <summary>The tags property</summary>
    public List<KClient.Models.TagGetResponseSchema> Tags { get; set; }

    /// <summary>The type property</summary>
    public string Type { get; set; }

    /// <summary>The url property</summary>
    public string Url { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.TaggedObjectEntityResponseSchema"/> and sets the default values.
    /// </summary>
    public TaggedObjectEntityResponseSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.TaggedObjectEntityResponseSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.TaggedObjectEntityResponseSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.TaggedObjectEntityResponseSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "created_by", n => { CreatedBy = n.GetObjectValue<KClient.Models.User>(KClient.Models.User.CreateFromDiscriminatorValue); } },
            { "creator", n => { Creator = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "owners", n => { Owners = n.GetCollectionOfObjectValues<KClient.Models.User1>(KClient.Models.User1.CreateFromDiscriminatorValue)?.ToList(); } },
            { "tags", n => { Tags = n.GetCollectionOfObjectValues<KClient.Models.TagGetResponseSchema>(KClient.Models.TagGetResponseSchema.CreateFromDiscriminatorValue)?.ToList(); } },
            { "type", n => { Type = n.GetStringValue(); } },
            { "url", n => { Url = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteObjectValue<KClient.Models.User>("created_by", CreatedBy);
        writer.WriteStringValue("creator", Creator);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("name", Name);
        writer.WriteCollectionOfObjectValues<KClient.Models.User1>("owners", Owners);
        writer.WriteCollectionOfObjectValues<KClient.Models.TagGetResponseSchema>("tags", Tags);
        writer.WriteStringValue("type", Type);
        writer.WriteStringValue("url", Url);
        writer.WriteAdditionalData(AdditionalData);
    }
}
