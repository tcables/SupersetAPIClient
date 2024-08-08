
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.DatasetRestApi.Get_list;

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
    public KClient.Models.DatasetRestApi.Get_list.User1? ChangedBy { get; set; }
#nullable restore
#else
    public KClient.Models.DatasetRestApi.Get_list.User1 ChangedBy { get; set; }
#endif
    /// <summary>The changed_by_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? ChangedByName { get; private set; }
#nullable restore
#else
    public UntypedNode ChangedByName { get; private set; }
#endif
    /// <summary>The changed_on_delta_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? ChangedOnDeltaHumanized { get; private set; }
#nullable restore
#else
    public UntypedNode ChangedOnDeltaHumanized { get; private set; }
#endif
    /// <summary>The changed_on_utc property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? ChangedOnUtc { get; private set; }
#nullable restore
#else
    public UntypedNode ChangedOnUtc { get; private set; }
#endif
    /// <summary>The database property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.DatasetRestApi.Get_list.Database? Database { get; set; }
#nullable restore
#else
    public KClient.Models.DatasetRestApi.Get_list.Database Database { get; set; }
#endif
    /// <summary>The datasource_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? DatasourceType { get; private set; }
#nullable restore
#else
    public UntypedNode DatasourceType { get; private set; }
#endif
    /// <summary>The default_endpoint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? DefaultEndpoint { get; set; }
#nullable restore
#else
    public string DefaultEndpoint { get; set; }
#endif
    /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Description { get; set; }
#nullable restore
#else
    public string Description { get; set; }
#endif
    /// <summary>The explore_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? ExploreUrl { get; private set; }
#nullable restore
#else
    public UntypedNode ExploreUrl { get; private set; }
#endif
    /// <summary>The extra property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Extra { get; set; }
#nullable restore
#else
    public string Extra { get; set; }
#endif
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The kind property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? Kind { get; private set; }
#nullable restore
#else
    public UntypedNode Kind { get; private set; }
#endif
    /// <summary>The owners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.DatasetRestApi.Get_list.User? Owners { get; set; }
#nullable restore
#else
    public KClient.Models.DatasetRestApi.Get_list.User Owners { get; set; }
#endif
    /// <summary>The schema property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Schema { get; set; }
#nullable restore
#else
    public string Schema { get; set; }
#endif
    /// <summary>The sql property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Sql { get; set; }
#nullable restore
#else
    public string Sql { get; set; }
#endif
    /// <summary>The table_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? TableName { get; set; }
#nullable restore
#else
    public string TableName { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DatasetRestApi.Get_list.Get_list"/> and sets the default values.
    /// </summary>
    public Get_list()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatasetRestApi.Get_list.Get_list"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DatasetRestApi.Get_list.Get_list CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DatasetRestApi.Get_list.Get_list();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.DatasetRestApi.Get_list.User1>(KClient.Models.DatasetRestApi.Get_list.User1.CreateFromDiscriminatorValue); } },
            { "changed_by_name", n => { ChangedByName = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "changed_on_utc", n => { ChangedOnUtc = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "database", n => { Database = n.GetObjectValue<KClient.Models.DatasetRestApi.Get_list.Database>(KClient.Models.DatasetRestApi.Get_list.Database.CreateFromDiscriminatorValue); } },
            { "datasource_type", n => { DatasourceType = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "default_endpoint", n => { DefaultEndpoint = n.GetStringValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "explore_url", n => { ExploreUrl = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "extra", n => { Extra = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "kind", n => { Kind = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "owners", n => { Owners = n.GetObjectValue<KClient.Models.DatasetRestApi.Get_list.User>(KClient.Models.DatasetRestApi.Get_list.User.CreateFromDiscriminatorValue); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "table_name", n => { TableName = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KClient.Models.DatasetRestApi.Get_list.User1>("changed_by", ChangedBy);
        writer.WriteObjectValue<KClient.Models.DatasetRestApi.Get_list.Database>("database", Database);
        writer.WriteStringValue("default_endpoint", DefaultEndpoint);
        writer.WriteStringValue("description", Description);
        writer.WriteStringValue("extra", Extra);
        writer.WriteIntValue("id", Id);
        writer.WriteObjectValue<KClient.Models.DatasetRestApi.Get_list.User>("owners", Owners);
        writer.WriteStringValue("schema", Schema);
        writer.WriteStringValue("sql", Sql);
        writer.WriteStringValue("table_name", TableName);
        writer.WriteAdditionalData(AdditionalData);
    }
}
