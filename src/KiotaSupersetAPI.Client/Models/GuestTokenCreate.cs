
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class GuestTokenCreate : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The resources property</summary>
    public List<KClient.Models.Resource> Resources { get; set; }

    /// <summary>The rls property</summary>
    public List<KClient.Models.RlsRule> Rls { get; set; }

    /// <summary>The user property</summary>
    public KClient.Models.User2 User { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.GuestTokenCreate"/> and sets the default values.
    /// </summary>
    public GuestTokenCreate()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.GuestTokenCreate"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.GuestTokenCreate CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.GuestTokenCreate();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "resources", n => { Resources = n.GetCollectionOfObjectValues<KClient.Models.Resource>(KClient.Models.Resource.CreateFromDiscriminatorValue)?.ToList(); } },
            { "rls", n => { Rls = n.GetCollectionOfObjectValues<KClient.Models.RlsRule>(KClient.Models.RlsRule.CreateFromDiscriminatorValue)?.ToList(); } },
            { "user", n => { User = n.GetObjectValue<KClient.Models.User2>(KClient.Models.User2.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteCollectionOfObjectValues<KClient.Models.Resource>("resources", Resources);
        writer.WriteCollectionOfObjectValues<KClient.Models.RlsRule>("rls", Rls);
        writer.WriteObjectValue<KClient.Models.User2>("user", User);
        writer.WriteAdditionalData(AdditionalData);
    }
}
