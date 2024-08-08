
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Annotation400Error : ApiException, IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The primary error message.</summary>
    public override string Message { get => base.Message; }
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.Annotation400Error"/> and sets the default values.
    /// </summary>
    public Annotation400Error()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.Annotation400Error"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.Annotation400Error CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.Annotation400Error();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteAdditionalData(AdditionalData);
    }
}
