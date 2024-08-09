
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class DatasetRelatedDashboards : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Dashboard count</summary>
    public int? Count { get; set; }
    /// <summary>A list of dashboards</summary>
    public List<Models.DatasetRelatedDashboard> Result { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.DatasetRelatedDashboards"/> and sets the default values.
    /// </summary>
    public DatasetRelatedDashboards()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.DatasetRelatedDashboards"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.DatasetRelatedDashboards CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.DatasetRelatedDashboards();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "count", n => { Count = n.GetIntValue(); } },
            { "result", n => { Result = n.GetCollectionOfObjectValues<Models.DatasetRelatedDashboard>(Models.DatasetRelatedDashboard.CreateFromDiscriminatorValue)?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("count", Count);
        writer.WriteCollectionOfObjectValues<Models.DatasetRelatedDashboard>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
