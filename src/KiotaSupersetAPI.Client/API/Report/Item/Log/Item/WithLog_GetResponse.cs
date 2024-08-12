
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Report.Item.Log.Item;

[GeneratedCode("Kiota", "1.16.0")]
public partial class WithLog_GetResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The log id</summary>

    public string Id { get; set; }

    /// <summary>The result property</summary>

    public Models.ReportExecutionLogRestAPI.Get Result { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="API.Report.Item.Log.Item.WithLog_GetResponse"/> and sets the default values.
    /// </summary>
    public WithLog_GetResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="API.Report.Item.Log.Item.WithLog_GetResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Report.Item.Log.Item.WithLog_GetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Report.Item.Log.Item.WithLog_GetResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "id", n => { Id = n.GetStringValue(); } },
            { "result", n => { Result = n.GetObjectValue<Models.ReportExecutionLogRestAPI.Get>(Models.ReportExecutionLogRestAPI.Get.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("id", Id);
        writer.WriteObjectValue<Models.ReportExecutionLogRestAPI.Get>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
