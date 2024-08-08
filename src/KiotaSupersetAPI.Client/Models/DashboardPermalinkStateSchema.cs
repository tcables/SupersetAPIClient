
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class DashboardPermalinkStateSchema : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Current active dashboard tabs</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<string>? ActiveTabs { get; set; }
#nullable restore
#else
    public List<string> ActiveTabs { get; set; }
#endif
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Optional anchor link added to url hash</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Anchor { get; set; }
#nullable restore
#else
    public string Anchor { get; set; }
#endif
    /// <summary>Data mask used for native filter state</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.DashboardPermalinkStateSchema_dataMask? DataMask { get; set; }
#nullable restore
#else
    public KClient.Models.DashboardPermalinkStateSchema_dataMask DataMask { get; set; }
#endif
    /// <summary>URL Parameters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? UrlParams { get; set; }
#nullable restore
#else
    public UntypedNode UrlParams { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DashboardPermalinkStateSchema"/> and sets the default values.
    /// </summary>
    public DashboardPermalinkStateSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DashboardPermalinkStateSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DashboardPermalinkStateSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DashboardPermalinkStateSchema();
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
            { "dataMask", n => { DataMask = n.GetObjectValue<KClient.Models.DashboardPermalinkStateSchema_dataMask>(KClient.Models.DashboardPermalinkStateSchema_dataMask.CreateFromDiscriminatorValue); } },
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
        writer.WriteObjectValue<KClient.Models.DashboardPermalinkStateSchema_dataMask>("dataMask", DataMask);
        writer.WriteObjectValue<UntypedNode>("urlParams", UrlParams);
        writer.WriteAdditionalData(AdditionalData);
    }
}
