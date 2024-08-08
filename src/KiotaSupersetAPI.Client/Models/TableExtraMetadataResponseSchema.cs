
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class TableExtraMetadataResponseSchema : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The clustering property</summary>
    public KClient.Models.TableExtraMetadataResponseSchema_clustering Clustering { get; set; }

    /// <summary>The metadata property</summary>
    public KClient.Models.TableExtraMetadataResponseSchema_metadata Metadata { get; set; }

    /// <summary>The partitions property</summary>
    public KClient.Models.TableExtraMetadataResponseSchema_partitions Partitions { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.TableExtraMetadataResponseSchema"/> and sets the default values.
    /// </summary>
    public TableExtraMetadataResponseSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.TableExtraMetadataResponseSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.TableExtraMetadataResponseSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.TableExtraMetadataResponseSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "clustering", n => { Clustering = n.GetObjectValue<KClient.Models.TableExtraMetadataResponseSchema_clustering>(KClient.Models.TableExtraMetadataResponseSchema_clustering.CreateFromDiscriminatorValue); } },
            { "metadata", n => { Metadata = n.GetObjectValue<KClient.Models.TableExtraMetadataResponseSchema_metadata>(KClient.Models.TableExtraMetadataResponseSchema_metadata.CreateFromDiscriminatorValue); } },
            { "partitions", n => { Partitions = n.GetObjectValue<KClient.Models.TableExtraMetadataResponseSchema_partitions>(KClient.Models.TableExtraMetadataResponseSchema_partitions.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KClient.Models.TableExtraMetadataResponseSchema_clustering>("clustering", Clustering);
        writer.WriteObjectValue<KClient.Models.TableExtraMetadataResponseSchema_metadata>("metadata", Metadata);
        writer.WriteObjectValue<KClient.Models.TableExtraMetadataResponseSchema_partitions>("partitions", Partitions);
        writer.WriteAdditionalData(AdditionalData);
    }
}
