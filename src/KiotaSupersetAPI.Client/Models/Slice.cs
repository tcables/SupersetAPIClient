
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
public partial class Slice : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Duration (in seconds) of the caching timeout for this chart.</summary>
    public int? CacheTimeout { get; set; }
    /// <summary>Details of the certification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? CertificationDetails { get; set; }
#nullable restore
#else
    public string CertificationDetails { get; set; }
#endif
    /// <summary>Person or group that has certified this dashboard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? CertifiedBy { get; set; }
#nullable restore
#else
    public string CertifiedBy { get; set; }
#endif
    /// <summary>Timestamp of the last modification.</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>Timestamp of the last modification in human readable form.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ChangedOnHumanized { get; set; }
#nullable restore
#else
    public string ChangedOnHumanized { get; set; }
#endif
    /// <summary>Datasource identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Datasource { get; set; }
#nullable restore
#else
    public string Datasource { get; set; }
#endif
    /// <summary>Slice description.</summary>
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
    /// <summary>The URL for editing the slice.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? EditUrl { get; set; }
#nullable restore
#else
    public string EditUrl { get; set; }
#endif
    /// <summary>Form data associated with the slice.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.Slice_form_data? FormData { get; set; }
#nullable restore
#else
    public KClient.Models.Slice_form_data FormData { get; set; }
#endif
    /// <summary>If the chart is managed outside externally.</summary>
    public bool? IsManagedExternally { get; set; }
    /// <summary>Last modification in human readable form.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Modified { get; set; }
#nullable restore
#else
    public string Modified { get; set; }
#endif
    /// <summary>Owners identifiers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<int?>? Owners { get; set; }
#nullable restore
#else
    public List<int?> Owners { get; set; }
#endif
    /// <summary>The context associated with the query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.Slice_query_context? QueryContext { get; set; }
#nullable restore
#else
    public KClient.Models.Slice_query_context QueryContext { get; set; }
#endif
    /// <summary>The slice ID.</summary>
    public int? SliceId { get; set; }
    /// <summary>The slice name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? SliceName { get; set; }
#nullable restore
#else
    public string SliceName { get; set; }
#endif
    /// <summary>The slice URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? SliceUrl { get; set; }
#nullable restore
#else
    public string SliceUrl { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.Slice"/> and sets the default values.
    /// </summary>
    public Slice()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.Slice"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.Slice CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.Slice();
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
            { "changed_on_humanized", n => { ChangedOnHumanized = n.GetStringValue(); } },
            { "datasource", n => { Datasource = n.GetStringValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "description_markeddown", n => { DescriptionMarkeddown = n.GetStringValue(); } },
            { "edit_url", n => { EditUrl = n.GetStringValue(); } },
            { "form_data", n => { FormData = n.GetObjectValue<KClient.Models.Slice_form_data>(KClient.Models.Slice_form_data.CreateFromDiscriminatorValue); } },
            { "is_managed_externally", n => { IsManagedExternally = n.GetBoolValue(); } },
            { "modified", n => { Modified = n.GetStringValue(); } },
            { "owners", n => { Owners = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            { "query_context", n => { QueryContext = n.GetObjectValue<KClient.Models.Slice_query_context>(KClient.Models.Slice_query_context.CreateFromDiscriminatorValue); } },
            { "slice_id", n => { SliceId = n.GetIntValue(); } },
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
        writer.WriteStringValue("changed_on_humanized", ChangedOnHumanized);
        writer.WriteStringValue("datasource", Datasource);
        writer.WriteStringValue("description", Description);
        writer.WriteStringValue("description_markeddown", DescriptionMarkeddown);
        writer.WriteStringValue("edit_url", EditUrl);
        writer.WriteObjectValue<KClient.Models.Slice_form_data>("form_data", FormData);
        writer.WriteBoolValue("is_managed_externally", IsManagedExternally);
        writer.WriteStringValue("modified", Modified);
        writer.WriteCollectionOfPrimitiveValues<int?>("owners", Owners);
        writer.WriteObjectValue<KClient.Models.Slice_query_context>("query_context", QueryContext);
        writer.WriteIntValue("slice_id", SliceId);
        writer.WriteStringValue("slice_name", SliceName);
        writer.WriteStringValue("slice_url", SliceUrl);
        writer.WriteAdditionalData(AdditionalData);
    }
}
