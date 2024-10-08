
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Report.Item;

[GeneratedCode("Kiota", "1.16.0")]
public partial class WithPkGetResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The description_columns property</summary>
    public WithPkGetResponse_description_columns DescriptionColumns { get; set; }

    /// <summary>The item id</summary>
    public string Id { get; set; }

    /// <summary>The label_columns property</summary>
    public WithPkGetResponse_label_columns LabelColumns { get; set; }

    /// <summary>The result property</summary>
    public Models.ReportScheduleRestAPI.Get.Get Result { get; set; }

    /// <summary>A list of columns</summary>
    public List<string> ShowColumns { get; set; }

    /// <summary>A title to render. Will be translated by babel</summary>
    public string ShowTitle { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Report.Item.WithPkGetResponse"/> and sets the default values.
    /// </summary>
    public WithPkGetResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Report.Item.WithPkGetResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Report.Item.WithPkGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Item.WithPkGetResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "description_columns", n => { DescriptionColumns = n.GetObjectValue<Report.Item.WithPkGetResponse_description_columns>(Report.Item.WithPkGetResponse_description_columns.CreateFromDiscriminatorValue); } },
            { "id", n => { Id = n.GetStringValue(); } },
            { "label_columns", n => { LabelColumns = n.GetObjectValue<Report.Item.WithPkGetResponse_label_columns>(Report.Item.WithPkGetResponse_label_columns.CreateFromDiscriminatorValue); } },
            { "result", n => { Result = n.GetObjectValue<Models.ReportScheduleRestAPI.Get.Get>(Models.ReportScheduleRestAPI.Get.Get.CreateFromDiscriminatorValue); } },
            { "show_columns", n => { ShowColumns = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "show_title", n => { ShowTitle = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<Report.Item.WithPkGetResponse_description_columns>("description_columns", DescriptionColumns);
        writer.WriteStringValue("id", Id);
        writer.WriteObjectValue<Report.Item.WithPkGetResponse_label_columns>("label_columns", LabelColumns);
        writer.WriteObjectValue<Models.ReportScheduleRestAPI.Get.Get>("result", Result);
        writer.WriteCollectionOfPrimitiveValues<string>("show_columns", ShowColumns);
        writer.WriteStringValue("show_title", ShowTitle);
        writer.WriteAdditionalData(AdditionalData);
    }
}
