
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.AnnotationRestApi;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Put : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The annotation end date time</summary>
    public DateTimeOffset? EndDttm { get; set; }
    /// <summary>JSON metadata</summary>
    public string JsonMetadata { get; set; }

    /// <summary>A long description</summary>
    public string LongDescr { get; set; }

    /// <summary>A short description</summary>
    public string ShortDescr { get; set; }

    /// <summary>The annotation start date time</summary>
    public DateTimeOffset? StartDttm { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.AnnotationRestApi.Put"/> and sets the default values.
    /// </summary>
    public Put()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.AnnotationRestApi.Put"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.AnnotationRestApi.Put CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.AnnotationRestApi.Put();
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
            { "json_metadata", n => { JsonMetadata = n.GetStringValue(); } },
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
        writer.WriteStringValue("json_metadata", JsonMetadata);
        writer.WriteStringValue("long_descr", LongDescr);
        writer.WriteStringValue("short_descr", ShortDescr);
        writer.WriteDateTimeOffsetValue("start_dttm", StartDttm);
        writer.WriteAdditionalData(AdditionalData);
    }
}
