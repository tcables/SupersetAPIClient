
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class ValidateSQLResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The end_column property</summary>
    public int? EndColumn { get; set; }
    /// <summary>The line_number property</summary>
    public int? LineNumber { get; set; }
    /// <summary>The message property</summary>
    public string Message { get; set; }

    /// <summary>The start_column property</summary>
    public int? StartColumn { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="Models.ValidateSQLResponse"/> and sets the default values.
    /// </summary>
    public ValidateSQLResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.ValidateSQLResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.ValidateSQLResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.ValidateSQLResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "end_column", n => { EndColumn = n.GetIntValue(); } },
            { "line_number", n => { LineNumber = n.GetIntValue(); } },
            { "message", n => { Message = n.GetStringValue(); } },
            { "start_column", n => { StartColumn = n.GetIntValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("end_column", EndColumn);
        writer.WriteIntValue("line_number", LineNumber);
        writer.WriteStringValue("message", Message);
        writer.WriteIntValue("start_column", StartColumn);
        writer.WriteAdditionalData(AdditionalData);
    }
}
