
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.AnnotationRestAPI.Get;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Get : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The end_dttm property</summary>
    public DateTimeOffset? EndDttm { get; set; }
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The json_metadata property</summary>
    public string JsonMetadata { get; set; }

    /// <summary>The layer property</summary>
    public Models.AnnotationRestAPI.Get.AnnotationLayer Layer { get; set; }

    /// <summary>The long_descr property</summary>
    public string LongDescr { get; set; }

    /// <summary>The short_descr property</summary>
    public string ShortDescr { get; set; }

    /// <summary>The start_dttm property</summary>
    public DateTimeOffset? StartDttm { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="Models.AnnotationRestAPI.Get.Get"/> and sets the default values.
    /// </summary>
    public Get()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.AnnotationRestAPI.Get.Get"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.AnnotationRestAPI.Get.Get CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.AnnotationRestAPI.Get.Get();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "end_dttm", n => { EndDttm = n.GetDateTimeOffsetValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "json_metadata", n => { JsonMetadata = n.GetStringValue(); } },
            { "layer", n => { Layer = n.GetObjectValue<Models.AnnotationRestAPI.Get.AnnotationLayer>(Models.AnnotationRestAPI.Get.AnnotationLayer.CreateFromDiscriminatorValue); } },
            { "long_descr", n => { LongDescr = n.GetStringValue(); } },
            { "short_descr", n => { ShortDescr = n.GetStringValue(); } },
            { "start_dttm", n => { StartDttm = n.GetDateTimeOffsetValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteDateTimeOffsetValue("end_dttm", EndDttm);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("json_metadata", JsonMetadata);
        writer.WriteObjectValue<Models.AnnotationRestAPI.Get.AnnotationLayer>("layer", Layer);
        writer.WriteStringValue("long_descr", LongDescr);
        writer.WriteStringValue("short_descr", ShortDescr);
        writer.WriteDateTimeOffsetValue("start_dttm", StartDttm);
        writer.WriteAdditionalData(AdditionalData);
    }
}
