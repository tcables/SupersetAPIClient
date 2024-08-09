
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Rowlevelsecurity.Item;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class WithPkDeleteResponse : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The message property</summary>
    public string Message { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KApi.Rowlevelsecurity.Item.WithPkDeleteResponse"/> and sets the default values.
    /// </summary>
    public WithPkDeleteResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Rowlevelsecurity.Item.WithPkDeleteResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.Rowlevelsecurity.Item.WithPkDeleteResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Rowlevelsecurity.Item.WithPkDeleteResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "message", n => { Message = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("message", Message);
        writer.WriteAdditionalData(AdditionalData);
    }
}
