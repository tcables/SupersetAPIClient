
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.ReportScheduleRestApi.Get;

[GeneratedCode("Kiota", "1.16.0")]
public partial class ReportRecipients : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The recipient_config_json property</summary>
    public string RecipientConfigJson { get; set; }

    /// <summary>The type property</summary>
    public string Type { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.ReportScheduleRestApi.Get.ReportRecipients"/> and sets the default values.
    /// </summary>
    public ReportRecipients()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.ReportScheduleRestApi.Get.ReportRecipients"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.ReportScheduleRestApi.Get.ReportRecipients CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.ReportScheduleRestApi.Get.ReportRecipients();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "id", n => { Id = n.GetIntValue(); } },
            { "recipient_config_json", n => { RecipientConfigJson = n.GetStringValue(); } },
            { "type", n => { Type = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("recipient_config_json", RecipientConfigJson);
        writer.WriteStringValue("type", Type);
        writer.WriteAdditionalData(AdditionalData);
    }
}
