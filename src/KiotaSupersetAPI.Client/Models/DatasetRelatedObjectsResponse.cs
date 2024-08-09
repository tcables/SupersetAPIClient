
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class DatasetRelatedObjectsResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The charts property</summary>
    public Models.DatasetRelatedCharts Charts { get; set; }

    /// <summary>The dashboards property</summary>
    public Models.DatasetRelatedDashboards Dashboards { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.DatasetRelatedObjectsResponse"/> and sets the default values.
    /// </summary>
    public DatasetRelatedObjectsResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.DatasetRelatedObjectsResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.DatasetRelatedObjectsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.DatasetRelatedObjectsResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "charts", n => { Charts = n.GetObjectValue<Models.DatasetRelatedCharts>(Models.DatasetRelatedCharts.CreateFromDiscriminatorValue); } },
            { "dashboards", n => { Dashboards = n.GetObjectValue<Models.DatasetRelatedDashboards>(Models.DatasetRelatedDashboards.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<Models.DatasetRelatedCharts>("charts", Charts);
        writer.WriteObjectValue<Models.DatasetRelatedDashboards>("dashboards", Dashboards);
        writer.WriteAdditionalData(AdditionalData);
    }
}
