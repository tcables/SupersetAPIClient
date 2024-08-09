
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Slice : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Duration (in seconds) of the caching timeout for this chart.</summary>
    public int? CacheTimeout { get; set; }
    /// <summary>Details of the certification.</summary>
    public string CertificationDetails { get; set; }

    /// <summary>Person or group that has certified this dashboard.</summary>
    public string CertifiedBy { get; set; }

    /// <summary>Timestamp of the last modification.</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>Timestamp of the last modification in human readable form.</summary>
    public string ChangedOnHumanized { get; set; }

    /// <summary>Datasource identifier.</summary>
    public string Datasource { get; set; }

    /// <summary>Slice description.</summary>
    public string Description { get; set; }

    /// <summary>Sanitized HTML version of the chart description.</summary>
    public string DescriptionMarkeddown { get; set; }

    /// <summary>The URL for editing the slice.</summary>
    public string EditUrl { get; set; }

    /// <summary>Form data associated with the slice.</summary>
    public Models.Slice_form_data FormData { get; set; }

    /// <summary>If the chart is managed outside externally.</summary>
    public bool? IsManagedExternally { get; set; }
    /// <summary>Last modification in human readable form.</summary>
    public string Modified { get; set; }

    /// <summary>Owners identifiers.</summary>
    public List<int?> Owners { get; set; }

    /// <summary>The context associated with the query.</summary>
    public Models.Slice_query_context QueryContext { get; set; }

    /// <summary>The slice ID.</summary>
    public int? SliceId { get; set; }
    /// <summary>The slice name.</summary>
    public string SliceName { get; set; }

    /// <summary>The slice URL.</summary>
    public string SliceUrl { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.Slice"/> and sets the default values.
    /// </summary>
    public Slice()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.Slice"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.Slice CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.Slice();
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
            { "form_data", n => { FormData = n.GetObjectValue<Models.Slice_form_data>(Models.Slice_form_data.CreateFromDiscriminatorValue); } },
            { "is_managed_externally", n => { IsManagedExternally = n.GetBoolValue(); } },
            { "modified", n => { Modified = n.GetStringValue(); } },
            { "owners", n => { Owners = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            { "query_context", n => { QueryContext = n.GetObjectValue<Models.Slice_query_context>(Models.Slice_query_context.CreateFromDiscriminatorValue); } },
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
        writer.WriteObjectValue<Models.Slice_form_data>("form_data", FormData);
        writer.WriteBoolValue("is_managed_externally", IsManagedExternally);
        writer.WriteStringValue("modified", Modified);
        writer.WriteCollectionOfPrimitiveValues<int?>("owners", Owners);
        writer.WriteObjectValue<Models.Slice_query_context>("query_context", QueryContext);
        writer.WriteIntValue("slice_id", SliceId);
        writer.WriteStringValue("slice_name", SliceName);
        writer.WriteStringValue("slice_url", SliceUrl);
        writer.WriteAdditionalData(AdditionalData);
    }
}
