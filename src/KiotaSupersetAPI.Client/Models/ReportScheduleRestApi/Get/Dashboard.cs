
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.ReportScheduleRestAPI.Get;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Dashboard : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The dashboard_title property</summary>
    public string DashboardTitle { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="Models.ReportScheduleRestAPI.Get.Dashboard"/> and sets the default values.
    /// </summary>
    public Dashboard()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.ReportScheduleRestAPI.Get.Dashboard"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.ReportScheduleRestAPI.Get.Dashboard CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.ReportScheduleRestAPI.Get.Dashboard();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "dashboard_title", n => { DashboardTitle = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("dashboard_title", DashboardTitle);
        writer.WriteIntValue("id", Id);
        writer.WriteAdditionalData(AdditionalData);
    }
}
