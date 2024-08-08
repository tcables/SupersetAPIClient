
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
public partial class TableMetadataForeignKeysIndexesResponse : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The column_names property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<string>? ColumnNames { get; set; }
#nullable restore
#else
    public List<string> ColumnNames { get; set; }
#endif
    /// <summary>The name of the foreign key or index</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Name { get; set; }
#nullable restore
#else
    public string Name { get; set; }
#endif
    /// <summary>The options property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.TableMetadataOptionsResponse? Options { get; set; }
#nullable restore
#else
    public KClient.Models.TableMetadataOptionsResponse Options { get; set; }
#endif
    /// <summary>The referred_columns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<string>? ReferredColumns { get; set; }
#nullable restore
#else
    public List<string> ReferredColumns { get; set; }
#endif
    /// <summary>The referred_schema property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ReferredSchema { get; set; }
#nullable restore
#else
    public string ReferredSchema { get; set; }
#endif
    /// <summary>The referred_table property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ReferredTable { get; set; }
#nullable restore
#else
    public string ReferredTable { get; set; }
#endif
    /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Type { get; set; }
#nullable restore
#else
    public string Type { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.TableMetadataForeignKeysIndexesResponse"/> and sets the default values.
    /// </summary>
    public TableMetadataForeignKeysIndexesResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.TableMetadataForeignKeysIndexesResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.TableMetadataForeignKeysIndexesResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.TableMetadataForeignKeysIndexesResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "column_names", n => { ColumnNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "options", n => { Options = n.GetObjectValue<KClient.Models.TableMetadataOptionsResponse>(KClient.Models.TableMetadataOptionsResponse.CreateFromDiscriminatorValue); } },
            { "referred_columns", n => { ReferredColumns = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "referred_schema", n => { ReferredSchema = n.GetStringValue(); } },
            { "referred_table", n => { ReferredTable = n.GetStringValue(); } },
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
        writer.WriteCollectionOfPrimitiveValues<string>("column_names", ColumnNames);
        writer.WriteStringValue("name", Name);
        writer.WriteObjectValue<KClient.Models.TableMetadataOptionsResponse>("options", Options);
        writer.WriteCollectionOfPrimitiveValues<string>("referred_columns", ReferredColumns);
        writer.WriteStringValue("referred_schema", ReferredSchema);
        writer.WriteStringValue("referred_table", ReferredTable);
        writer.WriteStringValue("type", Type);
        writer.WriteAdditionalData(AdditionalData);
    }
}
