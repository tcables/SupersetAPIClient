
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class ValidatorConfigJSON : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The operation to compare with a threshold to apply to the SQL output</summary>
    public Models.ValidatorConfigJSON_op? Op { get; set; }
    /// <summary>The threshold property</summary>
    public double? Threshold { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="Models.ValidatorConfigJSON"/> and sets the default values.
    /// </summary>
    public ValidatorConfigJSON()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.ValidatorConfigJSON"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.ValidatorConfigJSON CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.ValidatorConfigJSON();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "op", n => { Op = n.GetEnumValue<Models.ValidatorConfigJSON_op>(); } },
            { "threshold", n => { Threshold = n.GetDoubleValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteEnumValue<Models.ValidatorConfigJSON_op>("op", Op);
        writer.WriteDoubleValue("threshold", Threshold);
        writer.WriteAdditionalData(AdditionalData);
    }
}
