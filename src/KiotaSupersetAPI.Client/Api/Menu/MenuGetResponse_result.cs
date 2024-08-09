
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Menu;

[GeneratedCode("Kiota", "1.16.0")]
public partial class MenuGetResponse_result : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The childs property</summary>
    public List<KApi.Menu.MenuGetResponse_result_childs> Childs { get; set; }

    /// <summary>Icon name to show for this menu item</summary>
    public string Icon { get; set; }

    /// <summary>Pretty name for the menu item</summary>
    public string Label { get; set; }

    /// <summary>The internal menu item name, maps to permission_name</summary>
    public string Name { get; set; }

    /// <summary>The URL for the menu item</summary>
    public string Url { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KApi.Menu.MenuGetResponse_result"/> and sets the default values.
    /// </summary>
    public MenuGetResponse_result()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Menu.MenuGetResponse_result"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.Menu.MenuGetResponse_result CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Menu.MenuGetResponse_result();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "childs", n => { Childs = n.GetCollectionOfObjectValues<KApi.Menu.MenuGetResponse_result_childs>(KApi.Menu.MenuGetResponse_result_childs.CreateFromDiscriminatorValue)?.ToList(); } },
            { "icon", n => { Icon = n.GetStringValue(); } },
            { "label", n => { Label = n.GetStringValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "url", n => { Url = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteCollectionOfObjectValues<KApi.Menu.MenuGetResponse_result_childs>("childs", Childs);
        writer.WriteStringValue("icon", Icon);
        writer.WriteStringValue("label", Label);
        writer.WriteStringValue("name", Name);
        writer.WriteStringValue("url", Url);
        writer.WriteAdditionalData(AdditionalData);
    }
}
