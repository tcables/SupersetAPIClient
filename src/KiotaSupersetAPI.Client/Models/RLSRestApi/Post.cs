
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.RLSRestApi;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Post : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>clause_description</summary>
    public string Clause { get; set; }

    /// <summary>description_description</summary>
    public string Description { get; set; }

    /// <summary>filter_type_description</summary>
    public Models.RLSRestApi.Post_filter_type? FilterType { get; set; }
    /// <summary>group_key_description</summary>
    public string GroupKey { get; set; }

    /// <summary>name_description</summary>
    public string Name { get; set; }

    /// <summary>roles_description</summary>
    public List<int?> Roles { get; set; }

    /// <summary>tables_description</summary>
    public List<int?> Tables { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.RLSRestApi.Post"/> and sets the default values.
    /// </summary>
    public Post()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.RLSRestApi.Post"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.RLSRestApi.Post CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.RLSRestApi.Post();
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
            { "filter_type", n => { FilterType = n.GetEnumValue<Models.RLSRestApi.Post_filter_type>(); } },
            { "group_key", n => { GroupKey = n.GetStringValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "roles", n => { Roles = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            { "tables", n => { Tables = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
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
        writer.WriteEnumValue<Models.RLSRestApi.Post_filter_type>("filter_type", FilterType);
        writer.WriteStringValue("group_key", GroupKey);
        writer.WriteStringValue("name", Name);
        writer.WriteCollectionOfPrimitiveValues<int?>("roles", Roles);
        writer.WriteCollectionOfPrimitiveValues<int?>("tables", Tables);
        writer.WriteAdditionalData(AdditionalData);
    }
}
