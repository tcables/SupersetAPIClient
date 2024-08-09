
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Permalink.Item;

[GeneratedCode("Kiota", "1.16.0")]
public partial class WithKeyGetResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The stored state</summary>
    public Dashboard.Permalink.Item.WithKeyGetResponse_state State { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Permalink.Item.WithKeyGetResponse"/> and sets the default values.
    /// </summary>
    public WithKeyGetResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Permalink.Item.WithKeyGetResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Dashboard.Permalink.Item.WithKeyGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Dashboard.Permalink.Item.WithKeyGetResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "state", n => { State = n.GetObjectValue<Dashboard.Permalink.Item.WithKeyGetResponse_state>(Dashboard.Permalink.Item.WithKeyGetResponse_state.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<Dashboard.Permalink.Item.WithKeyGetResponse_state>("state", State);
        writer.WriteAdditionalData(AdditionalData);
    }
}
