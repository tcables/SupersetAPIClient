
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Report.Item.Log;

[GeneratedCode("Kiota", "1.16.0")]
public partial class LogGetResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The total record count on the backend</summary>
    public double? Count { get; set; }
    /// <summary>A list of log ids</summary>

    public List<string> Ids { get; set; }

    /// <summary>The result from the get list query</summary>

    public List<Models.ReportExecutionLogRestAPI.Get_list> Result { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="API.Report.Item.Log.LogGetResponse"/> and sets the default values.
    /// </summary>
    public LogGetResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="API.Report.Item.Log.LogGetResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Report.Item.Log.LogGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Report.Item.Log.LogGetResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "count", n => { Count = n.GetDoubleValue(); } },
            { "ids", n => { Ids = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "result", n => { Result = n.GetCollectionOfObjectValues<Models.ReportExecutionLogRestAPI.Get_list>(Models.ReportExecutionLogRestAPI.Get_list.CreateFromDiscriminatorValue)?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteDoubleValue("count", Count);
        writer.WriteCollectionOfPrimitiveValues<string>("ids", Ids);
        writer.WriteCollectionOfObjectValues<Models.ReportExecutionLogRestAPI.Get_list>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
