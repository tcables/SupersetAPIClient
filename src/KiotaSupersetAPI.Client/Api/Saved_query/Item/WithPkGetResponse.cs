
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Saved_query.Item;

[GeneratedCode("Kiota", "1.16.0")]
public partial class WithPkGetResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The description_columns property</summary>
    public Saved_query.Item.WithPkGetResponse_description_columns DescriptionColumns { get; set; }

    /// <summary>The item id</summary>
    public string Id { get; set; }

    /// <summary>The label_columns property</summary>
    public Saved_query.Item.WithPkGetResponse_label_columns LabelColumns { get; set; }

    /// <summary>The result property</summary>
    public Models.SavedQueryRestAPI.Get.Get Result { get; set; }

    /// <summary>A list of columns</summary>
    public List<string> ShowColumns { get; set; }

    /// <summary>A title to render. Will be translated by babel</summary>
    public string ShowTitle { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Saved_query.Item.WithPkGetResponse"/> and sets the default values.
    /// </summary>
    public WithPkGetResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Saved_query.Item.WithPkGetResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Saved_query.Item.WithPkGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Saved_query.Item.WithPkGetResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "description_columns", n => { DescriptionColumns = n.GetObjectValue<Saved_query.Item.WithPkGetResponse_description_columns>(Saved_query.Item.WithPkGetResponse_description_columns.CreateFromDiscriminatorValue); } },
            { "id", n => { Id = n.GetStringValue(); } },
            { "label_columns", n => { LabelColumns = n.GetObjectValue<Saved_query.Item.WithPkGetResponse_label_columns>(Saved_query.Item.WithPkGetResponse_label_columns.CreateFromDiscriminatorValue); } },
            { "result", n => { Result = n.GetObjectValue<Models.SavedQueryRestAPI.Get.Get>(Models.SavedQueryRestAPI.Get.Get.CreateFromDiscriminatorValue); } },
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
        writer.WriteObjectValue<Saved_query.Item.WithPkGetResponse_description_columns>("description_columns", DescriptionColumns);
        writer.WriteStringValue("id", Id);
        writer.WriteObjectValue<Saved_query.Item.WithPkGetResponse_label_columns>("label_columns", LabelColumns);
        writer.WriteObjectValue<Models.SavedQueryRestAPI.Get.Get>("result", Result);
        writer.WriteCollectionOfPrimitiveValues<string>("show_columns", ShowColumns);
        writer.WriteStringValue("show_title", ShowTitle);
        writer.WriteAdditionalData(AdditionalData);
    }
}
