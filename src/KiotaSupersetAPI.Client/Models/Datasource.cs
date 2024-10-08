
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Datasource : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Datasource name</summary>
    public string DatabaseName { get; set; }

    /// <summary>The datasource name.</summary>
    public string DatasourceName { get; set; }

    /// <summary>The type of dataset/datasource identified on `datasource_id`.</summary>
    public Models.Datasource_datasource_type? DatasourceType { get; set; }
    /// <summary>Datasource schema</summary>
    public string Schema { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.Datasource"/> and sets the default values.
    /// </summary>
    public Datasource()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.Datasource"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.Datasource CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.Datasource();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "database_name", n => { DatabaseName = n.GetStringValue(); } },
            { "datasource_name", n => { DatasourceName = n.GetStringValue(); } },
            { "datasource_type", n => { DatasourceType = n.GetEnumValue<Models.Datasource_datasource_type>(); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("database_name", DatabaseName);
        writer.WriteStringValue("datasource_name", DatasourceName);
        writer.WriteEnumValue<Models.Datasource_datasource_type>("datasource_type", DatasourceType);
        writer.WriteStringValue("schema", Schema);
        writer.WriteAdditionalData(AdditionalData);
    }
}
