
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.CssTemplateRestApi.Get.User1? ChangedBy { get; set; }
#nullable restore
#else
    public KClient.Models.CssTemplateRestApi.Get.User1 ChangedBy { get; set; }
#endif
    /// <summary>The changed_on_delta_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? ChangedOnDeltaHumanized { get; private set; }
#nullable restore
#else
    public UntypedNode ChangedOnDeltaHumanized { get; private set; }
#endif
    /// <summary>The created_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.CssTemplateRestApi.Get.User? CreatedBy { get; set; }
#nullable restore
#else
    public KClient.Models.CssTemplateRestApi.Get.User CreatedBy { get; set; }
#endif
    /// <summary>The css property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Css { get; set; }
#nullable restore
#else
    public string Css { get; set; }
#endif
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The template_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? TemplateName { get; set; }
#nullable restore
#else
    public string TemplateName { get; set; }
#endif
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
