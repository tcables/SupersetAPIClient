
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.AnnotationRestApi;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Post : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The annotation end date time</summary>
    public DateTimeOffset? EndDttm { get; set; }
    /// <summary>JSON metadata</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? JsonMetadata { get; set; }
#nullable restore
#else
    public string JsonMetadata { get; set; }
#endif
    /// <summary>A long description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? LongDescr { get; set; }
#nullable restore
#else
    public string LongDescr { get; set; }
#endif
    /// <summary>A short description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ShortDescr { get; set; }
#nullable restore
#else
    public string ShortDescr { get; set; }
#endif
    /// <summary>The annotation start date time</summary>
    public DateTimeOffset? StartDttm { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.AnnotationRestApi.Post"/> and sets the default values.
    /// </summary>
    public Post()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.AnnotationRestApi.Post"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.AnnotationRestApi.Post CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.AnnotationRestApi.Post();
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
