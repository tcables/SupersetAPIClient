
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.TagRestApi.Get_list;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Get_list : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The changed_by property</summary>
    public KClient.Models.TagRestApi.Get_list.User1 ChangedBy { get; set; }

    /// <summary>The changed_on_delta_humanized property</summary>
    public UntypedNode ChangedOnDeltaHumanized { get; private set; }

    /// <summary>The created_by property</summary>
    public KClient.Models.TagRestApi.Get_list.User CreatedBy { get; set; }

    /// <summary>The created_on_delta_humanized property</summary>
    public UntypedNode CreatedOnDeltaHumanized { get; private set; }

    /// <summary>The description property</summary>
    public string Description { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The name property</summary>
    public string Name { get; set; }

    /// <summary>The type property</summary>
    public UntypedNode Type { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.TagRestApi.Get_list.Get_list"/> and sets the default values.
    /// </summary>
    public Get_list()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.TagRestApi.Get_list.Get_list"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.TagRestApi.Get_list.Get_list CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.TagRestApi.Get_list.Get_list();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.TagRestApi.Get_list.User1>(KClient.Models.TagRestApi.Get_list.User1.CreateFromDiscriminatorValue); } },
            { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "created_by", n => { CreatedBy = n.GetObjectValue<KClient.Models.TagRestApi.Get_list.User>(KClient.Models.TagRestApi.Get_list.User.CreateFromDiscriminatorValue); } },
            { "created_on_delta_humanized", n => { CreatedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "type", n => { Type = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KClient.Models.TagRestApi.Get_list.User1>("changed_by", ChangedBy);
        writer.WriteObjectValue<KClient.Models.TagRestApi.Get_list.User>("created_by", CreatedBy);
        writer.WriteStringValue("description", Description);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("name", Name);
        writer.WriteObjectValue<UntypedNode>("type", Type);
        writer.WriteAdditionalData(AdditionalData);
    }
}
