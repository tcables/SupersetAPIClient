
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class DatabaseRelatedObjectsResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The charts property</summary>
    public Models.DatabaseRelatedCharts Charts { get; set; }

    /// <summary>The dashboards property</summary>
    public Models.DatabaseRelatedDashboards Dashboards { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.DatabaseRelatedObjectsResponse"/> and sets the default values.
    /// </summary>
    public DatabaseRelatedObjectsResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.DatabaseRelatedObjectsResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.DatabaseRelatedObjectsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.DatabaseRelatedObjectsResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "charts", n => { Charts = n.GetObjectValue<Models.DatabaseRelatedCharts>(Models.DatabaseRelatedCharts.CreateFromDiscriminatorValue); } },
            { "dashboards", n => { Dashboards = n.GetObjectValue<Models.DatabaseRelatedDashboards>(Models.DatabaseRelatedDashboards.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<Models.DatabaseRelatedCharts>("charts", Charts);
        writer.WriteObjectValue<Models.DatabaseRelatedDashboards>("dashboards", Dashboards);
        writer.WriteAdditionalData(AdditionalData);
    }
}
