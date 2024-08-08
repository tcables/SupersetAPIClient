
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.RLSRestApi;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Get_list : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The changed_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.User? ChangedBy { get; set; }
#nullable restore
#else
    public KClient.Models.User ChangedBy { get; set; }
#endif
    /// <summary>The changed_on_delta_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? ChangedOnDeltaHumanized { get; private set; }
#nullable restore
#else
    public UntypedNode ChangedOnDeltaHumanized { get; private set; }
#endif
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
    public KClient.Models.RLSRestApi.Get_list_filter_type? FilterType { get; set; }
    /// <summary>group_key_description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? GroupKey { get; set; }
#nullable restore
#else
    public string GroupKey { get; set; }
#endif
    /// <summary>id_description</summary>
    public int? Id { get; set; }
    /// <summary>name_description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Name { get; set; }
#nullable restore
#else
    public string Name { get; set; }
#endif
    /// <summary>The roles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<KClient.Models.Roles1>? Roles { get; set; }
#nullable restore
#else
    public List<KClient.Models.Roles1> Roles { get; set; }
#endif
    /// <summary>The tables property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<KClient.Models.Tables>? Tables { get; set; }
#nullable restore
#else
    public List<KClient.Models.Tables> Tables { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.RLSRestApi.Get_list"/> and sets the default values.
    /// </summary>
    public Get_list()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.RLSRestApi.Get_list"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.RLSRestApi.Get_list CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.RLSRestApi.Get_list();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.User>(KClient.Models.User.CreateFromDiscriminatorValue); } },
            { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "clause", n => { Clause = n.GetStringValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "filter_type", n => { FilterType = n.GetEnumValue<KClient.Models.RLSRestApi.Get_list_filter_type>(); } },
            { "group_key", n => { GroupKey = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "roles", n => { Roles = n.GetCollectionOfObjectValues<KClient.Models.Roles1>(KClient.Models.Roles1.CreateFromDiscriminatorValue)?.ToList(); } },
            { "tables", n => { Tables = n.GetCollectionOfObjectValues<KClient.Models.Tables>(KClient.Models.Tables.CreateFromDiscriminatorValue)?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KClient.Models.User>("changed_by", ChangedBy);
        writer.WriteStringValue("clause", Clause);
        writer.WriteStringValue("description", Description);
        writer.WriteEnumValue<KClient.Models.RLSRestApi.Get_list_filter_type>("filter_type", FilterType);
        writer.WriteStringValue("group_key", GroupKey);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("name", Name);
        writer.WriteCollectionOfObjectValues<KClient.Models.Roles1>("roles", Roles);
        writer.WriteCollectionOfObjectValues<KClient.Models.Tables>("tables", Tables);
        writer.WriteAdditionalData(AdditionalData);
    }
}
