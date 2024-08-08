
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class ChartEntityResponseSchema : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Duration (in seconds) of the caching timeout for this chart. Note this defaults to the datasource/table timeout if undefined.</summary>
    public int? CacheTimeout { get; set; }
    /// <summary>Details of the certification</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? CertificationDetails { get; set; }
#nullable restore
#else
    public string CertificationDetails { get; set; }
#endif
    /// <summary>Person or group that has certified this chart</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? CertifiedBy { get; set; }
#nullable restore
#else
    public string CertifiedBy { get; set; }
#endif
    /// <summary>The ISO date that the chart was last changed.</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>A description of the chart propose.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Description { get; set; }
#nullable restore
#else
    public string Description { get; set; }
#endif
    /// <summary>Sanitized HTML version of the chart description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? DescriptionMarkeddown { get; set; }
#nullable restore
#else
    public string DescriptionMarkeddown { get; set; }
#endif
    /// <summary>Form data from the Explore controls used to form the chart&apos;s data query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.ChartEntityResponseSchema_form_data? FormData { get; set; }
#nullable restore
#else
    public KClient.Models.ChartEntityResponseSchema_form_data FormData { get; set; }
#endif
    /// <summary>The id of the chart.</summary>
    public int? Id { get; set; }
    /// <summary>The name of the chart.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? SliceName { get; set; }
#nullable restore
#else
    public string SliceName { get; set; }
#endif
    /// <summary>The URL of the chart.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? SliceUrl { get; set; }
#nullable restore
#else
    public string SliceUrl { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.ChartEntityResponseSchema"/> and sets the default values.
    /// </summary>
    public ChartEntityResponseSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ChartEntityResponseSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.ChartEntityResponseSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.ChartEntityResponseSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "cache_timeout", n => { CacheTimeout = n.GetIntValue(); } },
            { "certification_details", n => { CertificationDetails = n.GetStringValue(); } },
            { "certified_by", n => { CertifiedBy = n.GetStringValue(); } },
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "description_markeddown", n => { DescriptionMarkeddown = n.GetStringValue(); } },
            { "form_data", n => { FormData = n.GetObjectValue<KClient.Models.ChartEntityResponseSchema_form_data>(KClient.Models.ChartEntityResponseSchema_form_data.CreateFromDiscriminatorValue); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "slice_name", n => { SliceName = n.GetStringValue(); } },
            { "slice_url", n => { SliceUrl = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("cache_timeout", CacheTimeout);
        writer.WriteStringValue("certification_details", CertificationDetails);
        writer.WriteStringValue("certified_by", CertifiedBy);
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteStringValue("description", Description);
        writer.WriteStringValue("description_markeddown", DescriptionMarkeddown);
        writer.WriteObjectValue<KClient.Models.ChartEntityResponseSchema_form_data>("form_data", FormData);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("slice_name", SliceName);
        writer.WriteStringValue("slice_url", SliceUrl);
        writer.WriteAdditionalData(AdditionalData);
    }
}
