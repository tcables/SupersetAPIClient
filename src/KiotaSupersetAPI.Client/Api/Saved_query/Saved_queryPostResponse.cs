
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Saved_query;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Saved_queryPostResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The id property</summary>
    public string Id { get; set; }

    /// <summary>The result property</summary>
    public KClient.Models.SavedQueryRestApi.Post Result { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Saved_query.Saved_queryPostResponse"/> and sets the default values.
    /// </summary>
    public Saved_queryPostResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Saved_query.Saved_queryPostResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Saved_query.Saved_queryPostResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Saved_query.Saved_queryPostResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "id", n => { Id = n.GetStringValue(); } },
            { "result", n => { Result = n.GetObjectValue<KClient.Models.SavedQueryRestApi.Post>(KClient.Models.SavedQueryRestApi.Post.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("id", Id);
        writer.WriteObjectValue<KClient.Models.SavedQueryRestApi.Post>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
