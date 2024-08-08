
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.SavedQueryRestApi.Get_list;

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
    public KClient.Models.SavedQueryRestApi.Get_list.User1? ChangedBy { get; set; }
#nullable restore
#else
    public KClient.Models.SavedQueryRestApi.Get_list.User1 ChangedBy { get; set; }
#endif
    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The changed_on_delta_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? ChangedOnDeltaHumanized { get; private set; }
#nullable restore
#else
    public UntypedNode ChangedOnDeltaHumanized { get; private set; }
#endif
    /// <summary>The created_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.SavedQueryRestApi.Get_list.User? CreatedBy { get; set; }
#nullable restore
#else
    public KClient.Models.SavedQueryRestApi.Get_list.User CreatedBy { get; set; }
#endif
    /// <summary>The created_on property</summary>
    public DateTimeOffset? CreatedOn { get; set; }
    /// <summary>The database property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.SavedQueryRestApi.Get_list.Database? Database { get; set; }
#nullable restore
#else
    public KClient.Models.SavedQueryRestApi.Get_list.Database Database { get; set; }
#endif
    /// <summary>The db_id property</summary>
    public int? DbId { get; set; }
    /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Description { get; set; }
#nullable restore
#else
    public string Description { get; set; }
#endif
    /// <summary>The extra property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? Extra { get; private set; }
#nullable restore
#else
    public UntypedNode Extra { get; private set; }
#endif
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The label property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Label { get; set; }
#nullable restore
#else
    public string Label { get; set; }
#endif
    /// <summary>The last_run_delta_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? LastRunDeltaHumanized { get; private set; }
#nullable restore
#else
    public UntypedNode LastRunDeltaHumanized { get; private set; }
#endif
    /// <summary>The rows property</summary>
    public int? Rows { get; set; }
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
    /// <summary>The sql_tables property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? SqlTables { get; private set; }
#nullable restore
#else
    public UntypedNode SqlTables { get; private set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.SavedQueryRestApi.Get_list.Get_list"/> and sets the default values.
    /// </summary>
    public Get_list()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.SavedQueryRestApi.Get_list.Get_list"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.SavedQueryRestApi.Get_list.Get_list CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.SavedQueryRestApi.Get_list.Get_list();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.SavedQueryRestApi.Get_list.User1>(KClient.Models.SavedQueryRestApi.Get_list.User1.CreateFromDiscriminatorValue); } },
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "created_by", n => { CreatedBy = n.GetObjectValue<KClient.Models.SavedQueryRestApi.Get_list.User>(KClient.Models.SavedQueryRestApi.Get_list.User.CreateFromDiscriminatorValue); } },
            { "created_on", n => { CreatedOn = n.GetDateTimeOffsetValue(); } },
            { "database", n => { Database = n.GetObjectValue<KClient.Models.SavedQueryRestApi.Get_list.Database>(KClient.Models.SavedQueryRestApi.Get_list.Database.CreateFromDiscriminatorValue); } },
            { "db_id", n => { DbId = n.GetIntValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "extra", n => { Extra = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "label", n => { Label = n.GetStringValue(); } },
            { "last_run_delta_humanized", n => { LastRunDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "rows", n => { Rows = n.GetIntValue(); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "sql_tables", n => { SqlTables = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KClient.Models.SavedQueryRestApi.Get_list.User1>("changed_by", ChangedBy);
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteObjectValue<KClient.Models.SavedQueryRestApi.Get_list.User>("created_by", CreatedBy);
        writer.WriteDateTimeOffsetValue("created_on", CreatedOn);
        writer.WriteObjectValue<KClient.Models.SavedQueryRestApi.Get_list.Database>("database", Database);
        writer.WriteIntValue("db_id", DbId);
        writer.WriteStringValue("description", Description);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("label", Label);
        writer.WriteIntValue("rows", Rows);
        writer.WriteStringValue("schema", Schema);
        writer.WriteStringValue("sql", Sql);
        writer.WriteAdditionalData(AdditionalData);
    }
}
