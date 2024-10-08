
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.RLSRestAPI;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Get : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>clause_description</summary>
    public string Clause { get; set; }

    /// <summary>description_description</summary>
    public string Description { get; set; }

    /// <summary>filter_type_description</summary>
    public Models.RLSRestAPI.Get_filter_type? FilterType { get; set; }
    /// <summary>group_key_description</summary>
    public string GroupKey { get; set; }

    /// <summary>id_description</summary>
    public int? Id { get; set; }
    /// <summary>name_description</summary>
    public string Name { get; set; }

    /// <summary>The roles property</summary>
    public List<Models.Roles1> Roles { get; set; }

    /// <summary>The tables property</summary>
    public List<Models.Tables> Tables { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.RLSRestAPI.Get"/> and sets the default values.
    /// </summary>
    public Get()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.RLSRestAPI.Get"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.RLSRestAPI.Get CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.RLSRestAPI.Get();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "clause", n => { Clause = n.GetStringValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "filter_type", n => { FilterType = n.GetEnumValue<Models.RLSRestAPI.Get_filter_type>(); } },
            { "group_key", n => { GroupKey = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "roles", n => { Roles = n.GetCollectionOfObjectValues<Models.Roles1>(Models.Roles1.CreateFromDiscriminatorValue)?.ToList(); } },
            { "tables", n => { Tables = n.GetCollectionOfObjectValues<Models.Tables>(Models.Tables.CreateFromDiscriminatorValue)?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("clause", Clause);
        writer.WriteStringValue("description", Description);
        writer.WriteEnumValue<Models.RLSRestAPI.Get_filter_type>("filter_type", FilterType);
        writer.WriteStringValue("group_key", GroupKey);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("name", Name);
        writer.WriteCollectionOfObjectValues<Models.Roles1>("roles", Roles);
        writer.WriteCollectionOfObjectValues<Models.Tables>("tables", Tables);
        writer.WriteAdditionalData(AdditionalData);
    }
}
