
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class CacheInvalidationRequestSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>A list of the data source and database names</summary>
    public List<Models.Datasource> Datasources { get; set; }

    /// <summary>The uid of the dataset/datasource this new chart will use. A complete datasource identification needs `datasource_uid` </summary>
    public List<string> DatasourceUids { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.CacheInvalidationRequestSchema"/> and sets the default values.
    /// </summary>
    public CacheInvalidationRequestSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.CacheInvalidationRequestSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.CacheInvalidationRequestSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.CacheInvalidationRequestSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "datasource_uids", n => { DatasourceUids = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "datasources", n => { Datasources = n.GetCollectionOfObjectValues<Models.Datasource>(Models.Datasource.CreateFromDiscriminatorValue)?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteCollectionOfObjectValues<Models.Datasource>("datasources", Datasources);
        writer.WriteCollectionOfPrimitiveValues<string>("datasource_uids", DatasourceUids);
        writer.WriteAdditionalData(AdditionalData);
    }
}
