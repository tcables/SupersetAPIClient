
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class DashboardCopySchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Override CSS for the dashboard.</summary>
    public string Css { get; set; }

    /// <summary>A title for the dashboard.</summary>
    public string DashboardTitle { get; set; }

    /// <summary>Whether or not to also copy all charts on the dashboard</summary>
    public bool? DuplicateSlices { get; set; }
    /// <summary>This JSON object is generated dynamically when clicking the save or overwrite button in the dashboard view. It is exposed here for reference and for power users who may want to alter  specific parameters.</summary>
    public string JsonMetadata { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.DashboardCopySchema"/> and sets the default values.
    /// </summary>
    public DashboardCopySchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.DashboardCopySchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.DashboardCopySchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.DashboardCopySchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "css", n => { Css = n.GetStringValue(); } },
            { "dashboard_title", n => { DashboardTitle = n.GetStringValue(); } },
            { "duplicate_slices", n => { DuplicateSlices = n.GetBoolValue(); } },
            { "json_metadata", n => { JsonMetadata = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("css", Css);
        writer.WriteStringValue("dashboard_title", DashboardTitle);
        writer.WriteBoolValue("duplicate_slices", DuplicateSlices);
        writer.WriteStringValue("json_metadata", JsonMetadata);
        writer.WriteAdditionalData(AdditionalData);
    }
}
