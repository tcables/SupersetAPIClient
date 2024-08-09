
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class DatabaseTablesResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Extra data used to specify column metadata</summary>
    public Models.DatabaseTablesResponse_extra Extra { get; set; }

    /// <summary>table or view</summary>
    public string Type { get; set; }

    /// <summary>The table or view name</summary>
    public string Value { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.DatabaseTablesResponse"/> and sets the default values.
    /// </summary>
    public DatabaseTablesResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.DatabaseTablesResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.DatabaseTablesResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.DatabaseTablesResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "extra", n => { Extra = n.GetObjectValue<Models.DatabaseTablesResponse_extra>(Models.DatabaseTablesResponse_extra.CreateFromDiscriminatorValue); } },
            { "type", n => { Type = n.GetStringValue(); } },
            { "value", n => { Value = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<Models.DatabaseTablesResponse_extra>("extra", Extra);
        writer.WriteStringValue("type", Type);
        writer.WriteStringValue("value", Value);
        writer.WriteAdditionalData(AdditionalData);
    }
}
