
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.AnnotationLayerRestAPI;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Put : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Give a description for this annotation layer</summary>
    public string Descr { get; set; }

    /// <summary>The annotation layer name</summary>
    public string Name { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.AnnotationLayerRestAPI.Put"/> and sets the default values.
    /// </summary>
    public Put()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.AnnotationLayerRestAPI.Put"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.AnnotationLayerRestAPI.Put CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.AnnotationLayerRestAPI.Put();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "descr", n => { Descr = n.GetStringValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("descr", Descr);
        writer.WriteStringValue("name", Name);
        writer.WriteAdditionalData(AdditionalData);
    }
}
