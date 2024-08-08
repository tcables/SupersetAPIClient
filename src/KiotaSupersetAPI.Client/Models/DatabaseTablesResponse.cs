
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class DatabaseTablesResponse : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Extra data used to specify column metadata</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.DatabaseTablesResponse_extra? Extra { get; set; }
#nullable restore
#else
    public KClient.Models.DatabaseTablesResponse_extra Extra { get; set; }
#endif
    /// <summary>table or view</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Type { get; set; }
#nullable restore
#else
    public string Type { get; set; }
#endif
    /// <summary>The table or view name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Value { get; set; }
#nullable restore
#else
    public string Value { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DatabaseTablesResponse"/> and sets the default values.
    /// </summary>
    public DatabaseTablesResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatabaseTablesResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DatabaseTablesResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DatabaseTablesResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "extra", n => { Extra = n.GetObjectValue<KClient.Models.DatabaseTablesResponse_extra>(KClient.Models.DatabaseTablesResponse_extra.CreateFromDiscriminatorValue); } },
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
        writer.WriteObjectValue<KClient.Models.DatabaseTablesResponse_extra>("extra", Extra);
        writer.WriteStringValue("type", Type);
        writer.WriteStringValue("value", Value);
        writer.WriteAdditionalData(AdditionalData);
    }
}
