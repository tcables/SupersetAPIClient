
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class FormDataPutSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The chart ID</summary>
    public int? ChartId { get; set; }
    /// <summary>The datasource ID</summary>
    public int? DatasourceId { get; set; }
    /// <summary>The datasource type</summary>
    public KClient.Models.FormDataPutSchema_datasource_type? DatasourceType { get; set; }
    /// <summary>Any type of JSON supported text.</summary>
    public string FormData { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.FormDataPutSchema"/> and sets the default values.
    /// </summary>
    public FormDataPutSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.FormDataPutSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.FormDataPutSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.FormDataPutSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "chart_id", n => { ChartId = n.GetIntValue(); } },
            { "datasource_id", n => { DatasourceId = n.GetIntValue(); } },
            { "datasource_type", n => { DatasourceType = n.GetEnumValue<KClient.Models.FormDataPutSchema_datasource_type>(); } },
            { "form_data", n => { FormData = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("chart_id", ChartId);
        writer.WriteIntValue("datasource_id", DatasourceId);
        writer.WriteEnumValue<KClient.Models.FormDataPutSchema_datasource_type>("datasource_type", DatasourceType);
        writer.WriteStringValue("form_data", FormData);
        writer.WriteAdditionalData(AdditionalData);
    }
}
