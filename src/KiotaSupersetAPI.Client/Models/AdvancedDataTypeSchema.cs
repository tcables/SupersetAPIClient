
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class AdvancedDataTypeSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The string representation of the parsed values</summary>
    public string DisplayValue { get; set; }

    /// <summary>The error_message property</summary>
    public string ErrorMessage { get; set; }

    /// <summary>The valid_filter_operators property</summary>
    public List<string> ValidFilterOperators { get; set; }

    /// <summary>The values property</summary>
    public List<string> Values { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.AdvancedDataTypeSchema"/> and sets the default values.
    /// </summary>
    public AdvancedDataTypeSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.AdvancedDataTypeSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.AdvancedDataTypeSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.AdvancedDataTypeSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "display_value", n => { DisplayValue = n.GetStringValue(); } },
            { "error_message", n => { ErrorMessage = n.GetStringValue(); } },
            { "valid_filter_operators", n => { ValidFilterOperators = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "values", n => { Values = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("display_value", DisplayValue);
        writer.WriteStringValue("error_message", ErrorMessage);
        writer.WriteCollectionOfPrimitiveValues<string>("valid_filter_operators", ValidFilterOperators);
        writer.WriteCollectionOfPrimitiveValues<string>("values", Values);
        writer.WriteAdditionalData(AdditionalData);
    }
}
