
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.RLSRestApi;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Put : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>clause_description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Clause { get; set; }
#nullable restore
#else
    public string Clause { get; set; }
#endif
    /// <summary>description_description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Description { get; set; }
#nullable restore
#else
    public string Description { get; set; }
#endif
    /// <summary>filter_type_description</summary>
    public KClient.Models.RLSRestApi.Put_filter_type? FilterType { get; set; }
    /// <summary>group_key_description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? GroupKey { get; set; }
#nullable restore
#else
    public string GroupKey { get; set; }
#endif
    /// <summary>name_description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Name { get; set; }
#nullable restore
#else
    public string Name { get; set; }
#endif
    /// <summary>roles_description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<int?>? Roles { get; set; }
#nullable restore
#else
    public List<int?> Roles { get; set; }
#endif
    /// <summary>tables_description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<int?>? Tables { get; set; }
#nullable restore
#else
    public List<int?> Tables { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.RLSRestApi.Put"/> and sets the default values.
    /// </summary>
    public Put()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.RLSRestApi.Put"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.RLSRestApi.Put CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.RLSRestApi.Put();
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
            { "filter_type", n => { FilterType = n.GetEnumValue<KClient.Models.RLSRestApi.Put_filter_type>(); } },
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
        writer.WriteEnumValue<KClient.Models.RLSRestApi.Put_filter_type>("filter_type", FilterType);
        writer.WriteStringValue("group_key", GroupKey);
        writer.WriteStringValue("name", Name);
        writer.WriteCollectionOfPrimitiveValues<int?>("roles", Roles);
        writer.WriteCollectionOfPrimitiveValues<int?>("tables", Tables);
        writer.WriteAdditionalData(AdditionalData);
    }
}
