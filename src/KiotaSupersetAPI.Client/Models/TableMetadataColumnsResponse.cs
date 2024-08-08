
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
public partial class TableMetadataColumnsResponse : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The duplicates_constraint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? DuplicatesConstraint { get; set; }
#nullable restore
#else
    public string DuplicatesConstraint { get; set; }
#endif
    /// <summary>The keys property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<string>? Keys { get; set; }
#nullable restore
#else
    public List<string> Keys { get; set; }
#endif
    /// <summary>The actual backend long type for the column</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? LongType { get; set; }
#nullable restore
#else
    public string LongType { get; set; }
#endif
    /// <summary>The column name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Name { get; set; }
#nullable restore
#else
    public string Name { get; set; }
#endif
    /// <summary>The column type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Type { get; set; }
#nullable restore
#else
    public string Type { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.TableMetadataColumnsResponse"/> and sets the default values.
    /// </summary>
    public TableMetadataColumnsResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.TableMetadataColumnsResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.TableMetadataColumnsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.TableMetadataColumnsResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "duplicates_constraint", n => { DuplicatesConstraint = n.GetStringValue(); } },
            { "keys", n => { Keys = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "longType", n => { LongType = n.GetStringValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "type", n => { Type = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("duplicates_constraint", DuplicatesConstraint);
        writer.WriteCollectionOfPrimitiveValues<string>("keys", Keys);
        writer.WriteStringValue("longType", LongType);
        writer.WriteStringValue("name", Name);
        writer.WriteStringValue("type", Type);
        writer.WriteAdditionalData(AdditionalData);
    }
}
