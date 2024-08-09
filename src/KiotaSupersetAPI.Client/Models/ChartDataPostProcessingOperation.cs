
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class ChartDataPostProcessingOperation : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Post processing operation type</summary>
    public Models.ChartDataPostProcessingOperation_operation? Operation { get; set; }
    /// <summary>Options specifying how to perform the operation. Please refer to the respective post processing operation option schemas. For example, `ChartDataPostProcessingOperationOptions` specifies the required options for the pivot operation.</summary>
    public Models.ChartDataPostProcessingOperation_options Options { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.ChartDataPostProcessingOperation"/> and sets the default values.
    /// </summary>
    public ChartDataPostProcessingOperation()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.ChartDataPostProcessingOperation"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.ChartDataPostProcessingOperation CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.ChartDataPostProcessingOperation();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "operation", n => { Operation = n.GetEnumValue<Models.ChartDataPostProcessingOperation_operation>(); } },
            { "options", n => { Options = n.GetObjectValue<Models.ChartDataPostProcessingOperation_options>(Models.ChartDataPostProcessingOperation_options.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteEnumValue<Models.ChartDataPostProcessingOperation_operation>("operation", Operation);
        writer.WriteObjectValue<Models.ChartDataPostProcessingOperation_options>("options", Options);
        writer.WriteAdditionalData(AdditionalData);
    }
}
