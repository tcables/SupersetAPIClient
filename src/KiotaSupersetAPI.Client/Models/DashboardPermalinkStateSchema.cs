
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class DashboardPermalinkStateSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Current active dashboard tabs</summary>
    public List<string> ActiveTabs { get; set; }

    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Optional anchor link added to url hash</summary>
    public string Anchor { get; set; }

    /// <summary>Data mask used for native filter state</summary>
    public Models.DashboardPermalinkStateSchema_dataMask DataMask { get; set; }

    /// <summary>URL Parameters</summary>
    public UntypedNode UrlParams { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.DashboardPermalinkStateSchema"/> and sets the default values.
    /// </summary>
    public DashboardPermalinkStateSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.DashboardPermalinkStateSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.DashboardPermalinkStateSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.DashboardPermalinkStateSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "activeTabs", n => { ActiveTabs = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "anchor", n => { Anchor = n.GetStringValue(); } },
            { "dataMask", n => { DataMask = n.GetObjectValue<Models.DashboardPermalinkStateSchema_dataMask>(Models.DashboardPermalinkStateSchema_dataMask.CreateFromDiscriminatorValue); } },
            { "urlParams", n => { UrlParams = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteCollectionOfPrimitiveValues<string>("activeTabs", ActiveTabs);
        writer.WriteStringValue("anchor", Anchor);
        writer.WriteObjectValue<Models.DashboardPermalinkStateSchema_dataMask>("dataMask", DataMask);
        writer.WriteObjectValue<UntypedNode>("urlParams", UrlParams);
        writer.WriteAdditionalData(AdditionalData);
    }
}
