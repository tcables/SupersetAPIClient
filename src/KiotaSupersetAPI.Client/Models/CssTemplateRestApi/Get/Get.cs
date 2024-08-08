
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.CssTemplateRestApi.Get;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Get : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The changed_by property</summary>
    public KClient.Models.CssTemplateRestApi.Get.User1 ChangedBy { get; set; }

    /// <summary>The changed_on_delta_humanized property</summary>
    public UntypedNode ChangedOnDeltaHumanized { get; private set; }

    /// <summary>The created_by property</summary>
    public KClient.Models.CssTemplateRestApi.Get.User CreatedBy { get; set; }

    /// <summary>The css property</summary>
    public string Css { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The template_name property</summary>
    public string TemplateName { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.CssTemplateRestApi.Get.Get"/> and sets the default values.
    /// </summary>
    public Get()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.CssTemplateRestApi.Get.Get"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.CssTemplateRestApi.Get.Get CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.CssTemplateRestApi.Get.Get();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.CssTemplateRestApi.Get.User1>(KClient.Models.CssTemplateRestApi.Get.User1.CreateFromDiscriminatorValue); } },
            { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "created_by", n => { CreatedBy = n.GetObjectValue<KClient.Models.CssTemplateRestApi.Get.User>(KClient.Models.CssTemplateRestApi.Get.User.CreateFromDiscriminatorValue); } },
            { "css", n => { Css = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "template_name", n => { TemplateName = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KClient.Models.CssTemplateRestApi.Get.User1>("changed_by", ChangedBy);
        writer.WriteObjectValue<KClient.Models.CssTemplateRestApi.Get.User>("created_by", CreatedBy);
        writer.WriteStringValue("css", Css);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("template_name", TemplateName);
        writer.WriteAdditionalData(AdditionalData);
    }
}
