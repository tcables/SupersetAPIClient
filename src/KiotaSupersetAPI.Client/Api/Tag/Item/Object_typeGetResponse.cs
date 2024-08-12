
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Tag.Item;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Object_typeGetResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The description_columns property</summary>
    public Object_typeGetResponse_description_columns DescriptionColumns { get; set; }

    /// <summary>The item id</summary>
    public string Id { get; set; }

    /// <summary>The label_columns property</summary>
    public Object_typeGetResponse_label_columns LabelColumns { get; set; }

    /// <summary>The result property</summary>
    public Models.TagRestAPI.Get.Get Result { get; set; }

    /// <summary>A list of columns</summary>
    public List<string> ShowColumns { get; set; }

    /// <summary>A title to render. Will be translated by babel</summary>
    public string ShowTitle { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Tag.Item.Object_typeGetResponse"/> and sets the default values.
    /// </summary>
    public Object_typeGetResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Tag.Item.Object_typeGetResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Object_typeGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Object_typeGetResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "description_columns", n => { DescriptionColumns = n.GetObjectValue<Tag.Item.Object_typeGetResponse_description_columns>(Tag.Item.Object_typeGetResponse_description_columns.CreateFromDiscriminatorValue); } },
            { "id", n => { Id = n.GetStringValue(); } },
            { "label_columns", n => { LabelColumns = n.GetObjectValue<Tag.Item.Object_typeGetResponse_label_columns>(Tag.Item.Object_typeGetResponse_label_columns.CreateFromDiscriminatorValue); } },
            { "result", n => { Result = n.GetObjectValue<Models.TagRestAPI.Get.Get>(Models.TagRestAPI.Get.Get.CreateFromDiscriminatorValue); } },
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
        writer.WriteObjectValue<Tag.Item.Object_typeGetResponse_description_columns>("description_columns", DescriptionColumns);
        writer.WriteStringValue("id", Id);
        writer.WriteObjectValue<Tag.Item.Object_typeGetResponse_label_columns>("label_columns", LabelColumns);
        writer.WriteObjectValue<Models.TagRestAPI.Get.Get>("result", Result);
        writer.WriteCollectionOfPrimitiveValues<string>("show_columns", ShowColumns);
        writer.WriteStringValue("show_title", ShowTitle);
        writer.WriteAdditionalData(AdditionalData);
    }
}
