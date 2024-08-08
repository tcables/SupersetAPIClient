
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class DatabaseRelatedDashboards : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Dashboard count</summary>
    public int? Count { get; set; }
    /// <summary>A list of dashboards</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<KClient.Models.DatabaseRelatedDashboard>? Result { get; set; }
#nullable restore
#else
    public List<KClient.Models.DatabaseRelatedDashboard> Result { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DatabaseRelatedDashboards"/> and sets the default values.
    /// </summary>
    public DatabaseRelatedDashboards()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatabaseRelatedDashboards"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DatabaseRelatedDashboards CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DatabaseRelatedDashboards();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "count", n => { Count = n.GetIntValue(); } },
            { "result", n => { Result = n.GetCollectionOfObjectValues<KClient.Models.DatabaseRelatedDashboard>(KClient.Models.DatabaseRelatedDashboard.CreateFromDiscriminatorValue)?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("count", Count);
        writer.WriteCollectionOfObjectValues<KClient.Models.DatabaseRelatedDashboard>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
