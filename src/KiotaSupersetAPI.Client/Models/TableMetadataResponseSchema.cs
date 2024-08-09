
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class TableMetadataResponseSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>A list of columns and their metadata</summary>
    public List<Models.TableMetadataColumnsResponse> Columns { get; set; }

    /// <summary>A list of foreign keys and their metadata</summary>
    public List<Models.TableMetadataForeignKeysIndexesResponse> ForeignKeys { get; set; }

    /// <summary>A list of indexes and their metadata</summary>
    public List<Models.TableMetadataForeignKeysIndexesResponse> Indexes { get; set; }

    /// <summary>The name of the table</summary>
    public string Name { get; set; }

    /// <summary>Primary keys metadata</summary>
    public Models.TableMetadataPrimaryKeyResponse PrimaryKey { get; set; }

    /// <summary>SQL select star</summary>
    public string SelectStar { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.TableMetadataResponseSchema"/> and sets the default values.
    /// </summary>
    public TableMetadataResponseSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.TableMetadataResponseSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.TableMetadataResponseSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.TableMetadataResponseSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "columns", n => { Columns = n.GetCollectionOfObjectValues<Models.TableMetadataColumnsResponse>(Models.TableMetadataColumnsResponse.CreateFromDiscriminatorValue)?.ToList(); } },
            { "foreignKeys", n => { ForeignKeys = n.GetCollectionOfObjectValues<Models.TableMetadataForeignKeysIndexesResponse>(Models.TableMetadataForeignKeysIndexesResponse.CreateFromDiscriminatorValue)?.ToList(); } },
            { "indexes", n => { Indexes = n.GetCollectionOfObjectValues<Models.TableMetadataForeignKeysIndexesResponse>(Models.TableMetadataForeignKeysIndexesResponse.CreateFromDiscriminatorValue)?.ToList(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "primaryKey", n => { PrimaryKey = n.GetObjectValue<Models.TableMetadataPrimaryKeyResponse>(Models.TableMetadataPrimaryKeyResponse.CreateFromDiscriminatorValue); } },
            { "selectStar", n => { SelectStar = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteCollectionOfObjectValues<Models.TableMetadataColumnsResponse>("columns", Columns);
        writer.WriteCollectionOfObjectValues<Models.TableMetadataForeignKeysIndexesResponse>("foreignKeys", ForeignKeys);
        writer.WriteCollectionOfObjectValues<Models.TableMetadataForeignKeysIndexesResponse>("indexes", Indexes);
        writer.WriteStringValue("name", Name);
        writer.WriteObjectValue<Models.TableMetadataPrimaryKeyResponse>("primaryKey", PrimaryKey);
        writer.WriteStringValue("selectStar", SelectStar);
        writer.WriteAdditionalData(AdditionalData);
    }
}
