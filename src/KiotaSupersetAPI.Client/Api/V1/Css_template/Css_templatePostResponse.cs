
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using KiotaSupersetAPI.Client.Models.CssTemplateRestApi;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Css_template;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Css_templatePostResponse : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Id { get; set; }
#nullable restore
#else
    public string Id { get; set; }
#endif
    /// <summary>The result property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.CssTemplateRestApi.Post? Result { get; set; }
#nullable restore
#else
    public KClient.Models.CssTemplateRestApi.Post Result { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KApi.Css_template.Css_templatePostResponse"/> and sets the default values.
    /// </summary>
    public Css_templatePostResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Css_template.Css_templatePostResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.Css_template.Css_templatePostResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Css_template.Css_templatePostResponse();
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
            { "result", n => { Result = n.GetObjectValue<KClient.Models.CssTemplateRestApi.Post>(KClient.Models.CssTemplateRestApi.Post.CreateFromDiscriminatorValue); } },
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
        writer.WriteObjectValue<KClient.Models.CssTemplateRestApi.Post>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
