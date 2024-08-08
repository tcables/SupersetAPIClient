
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
public partial class RecentActivity : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Action taken describing type of activity</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Action { get; set; }
#nullable restore
#else
    public string Action { get; set; }
#endif
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Title of item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ItemTitle { get; set; }
#nullable restore
#else
    public string ItemTitle { get; set; }
#endif
    /// <summary>Type of item, e.g. slice or dashboard</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ItemType { get; set; }
#nullable restore
#else
    public string ItemType { get; set; }
#endif
    /// <summary>URL to item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ItemUrl { get; set; }
#nullable restore
#else
    public string ItemUrl { get; set; }
#endif
    /// <summary>Time of activity, in epoch milliseconds</summary>
    public double? Time { get; set; }
    /// <summary>Human-readable description of how long ago activity took place.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? TimeDeltaHumanized { get; set; }
#nullable restore
#else
    public string TimeDeltaHumanized { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.RecentActivity"/> and sets the default values.
    /// </summary>
    public RecentActivity()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.RecentActivity"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.RecentActivity CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.RecentActivity();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "action", n => { Action = n.GetStringValue(); } },
            { "item_title", n => { ItemTitle = n.GetStringValue(); } },
            { "item_type", n => { ItemType = n.GetStringValue(); } },
            { "item_url", n => { ItemUrl = n.GetStringValue(); } },
            { "time", n => { Time = n.GetDoubleValue(); } },
            { "time_delta_humanized", n => { TimeDeltaHumanized = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("action", Action);
        writer.WriteStringValue("item_title", ItemTitle);
        writer.WriteStringValue("item_type", ItemType);
        writer.WriteStringValue("item_url", ItemUrl);
        writer.WriteDoubleValue("time", Time);
        writer.WriteStringValue("time_delta_humanized", TimeDeltaHumanized);
        writer.WriteAdditionalData(AdditionalData);
    }
}
