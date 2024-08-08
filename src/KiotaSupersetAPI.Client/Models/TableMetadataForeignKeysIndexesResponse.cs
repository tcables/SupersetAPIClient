
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
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
    public List<string> ColumnNames { get; set; }

    /// <summary>The name of the foreign key or index</summary>
    public string Name { get; set; }

    /// <summary>The options property</summary>
    public KClient.Models.TableMetadataOptionsResponse Options { get; set; }

    /// <summary>The referred_columns property</summary>
    public List<string> ReferredColumns { get; set; }

    /// <summary>The referred_schema property</summary>
    public string ReferredSchema { get; set; }

    /// <summary>The referred_table property</summary>
    public string ReferredTable { get; set; }

    /// <summary>The type property</summary>
    public string Type { get; set; }

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
