
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class RelatedResultResponse : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The extra metadata for related item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.RelatedResultResponse_extra? Extra { get; set; }
#nullable restore
#else
    public KClient.Models.RelatedResultResponse_extra Extra { get; set; }
#endif
    /// <summary>The related item string representation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Text { get; set; }
#nullable restore
#else
    public string Text { get; set; }
#endif
    /// <summary>The related item identifier</summary>
    public int? Value { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.RelatedResultResponse"/> and sets the default values.
    /// </summary>
    public RelatedResultResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.RelatedResultResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.RelatedResultResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.RelatedResultResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "extra", n => { Extra = n.GetObjectValue<KClient.Models.RelatedResultResponse_extra>(KClient.Models.RelatedResultResponse_extra.CreateFromDiscriminatorValue); } },
            { "text", n => { Text = n.GetStringValue(); } },
            { "value", n => { Value = n.GetIntValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KClient.Models.RelatedResultResponse_extra>("extra", Extra);
        writer.WriteStringValue("text", Text);
        writer.WriteIntValue("value", Value);
        writer.WriteAdditionalData(AdditionalData);
    }
}
