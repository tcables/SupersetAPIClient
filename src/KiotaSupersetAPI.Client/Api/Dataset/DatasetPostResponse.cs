
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dataset;

[GeneratedCode("Kiota", "1.16.0")]
public partial class DatasetPostResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The id property</summary>
    public double? Id { get; set; }
    /// <summary>The result property</summary>
    public Models.DatasetRestAPI.Post Result { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Dataset.DatasetPostResponse"/> and sets the default values.
    /// </summary>
    public DatasetPostResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dataset.DatasetPostResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Dataset.DatasetPostResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new DatasetPostResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "id", n => { Id = n.GetDoubleValue(); } },
            { "result", n => { Result = n.GetObjectValue<Models.DatasetRestAPI.Post>(Models.DatasetRestAPI.Post.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteDoubleValue("id", Id);
        writer.WriteObjectValue<Models.DatasetRestAPI.Post>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
