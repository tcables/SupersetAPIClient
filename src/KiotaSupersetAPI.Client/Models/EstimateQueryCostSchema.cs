
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class EstimateQueryCostSchema : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The database id</summary>
    public int? DatabaseId { get; set; }
    /// <summary>The database schema</summary>
    public string Schema { get; set; }

    /// <summary>The SQL query to estimate</summary>
    public string Sql { get; set; }

    /// <summary>The SQL query template params</summary>
    public KClient.Models.EstimateQueryCostSchema_template_params TemplateParams { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.EstimateQueryCostSchema"/> and sets the default values.
    /// </summary>
    public EstimateQueryCostSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.EstimateQueryCostSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.EstimateQueryCostSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.EstimateQueryCostSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "database_id", n => { DatabaseId = n.GetIntValue(); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "template_params", n => { TemplateParams = n.GetObjectValue<KClient.Models.EstimateQueryCostSchema_template_params>(KClient.Models.EstimateQueryCostSchema_template_params.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("database_id", DatabaseId);
        writer.WriteStringValue("schema", Schema);
        writer.WriteStringValue("sql", Sql);
        writer.WriteObjectValue<KClient.Models.EstimateQueryCostSchema_template_params>("template_params", TemplateParams);
        writer.WriteAdditionalData(AdditionalData);
    }
}
