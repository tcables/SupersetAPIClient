
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class QueryExecutionResponseSchema410Error_errors : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The error_type property</summary>
    public KClient.Models.QueryExecutionResponseSchema410Error_errors_error_type? ErrorType { get; set; }
    /// <summary>The extra property</summary>
    public KClient.Models.QueryExecutionResponseSchema410Error_errors_extra Extra { get; set; }

    /// <summary>The level property</summary>
    public KClient.Models.QueryExecutionResponseSchema410Error_errors_level? Level { get; set; }
    /// <summary>The message property</summary>
    public string Message { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.QueryExecutionResponseSchema410Error_errors"/> and sets the default values.
    /// </summary>
    public QueryExecutionResponseSchema410Error_errors()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.QueryExecutionResponseSchema410Error_errors"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.QueryExecutionResponseSchema410Error_errors CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.QueryExecutionResponseSchema410Error_errors();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "error_type", n => { ErrorType = n.GetEnumValue<KClient.Models.QueryExecutionResponseSchema410Error_errors_error_type>(); } },
            { "extra", n => { Extra = n.GetObjectValue<KClient.Models.QueryExecutionResponseSchema410Error_errors_extra>(KClient.Models.QueryExecutionResponseSchema410Error_errors_extra.CreateFromDiscriminatorValue); } },
            { "level", n => { Level = n.GetEnumValue<KClient.Models.QueryExecutionResponseSchema410Error_errors_level>(); } },
            { "message", n => { Message = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteEnumValue<KClient.Models.QueryExecutionResponseSchema410Error_errors_error_type>("error_type", ErrorType);
        writer.WriteObjectValue<KClient.Models.QueryExecutionResponseSchema410Error_errors_extra>("extra", Extra);
        writer.WriteEnumValue<KClient.Models.QueryExecutionResponseSchema410Error_errors_level>("level", Level);
        writer.WriteStringValue("message", Message);
        writer.WriteAdditionalData(AdditionalData);
    }
}
