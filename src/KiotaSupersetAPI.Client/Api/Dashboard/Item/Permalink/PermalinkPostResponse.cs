
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Permalink;

[GeneratedCode("Kiota", "1.16.0")]
public partial class PermalinkPostResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The key to retrieve the permanent link data.</summary>
    public string Key { get; set; }

    /// <summary>permanent link.</summary>
    public string Url { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Permalink.PermalinkPostResponse"/> and sets the default values.
    /// </summary>
    public PermalinkPostResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Permalink.PermalinkPostResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Dashboard.Item.Permalink.PermalinkPostResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Item.Permalink.PermalinkPostResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "key", n => { Key = n.GetStringValue(); } },
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
        writer.WriteStringValue("key", Key);
        writer.WriteStringValue("url", Url);
        writer.WriteAdditionalData(AdditionalData);
    }
}
