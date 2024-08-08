
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.QueryRestApi;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Get_list : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The database property</summary>
    public KClient.Models.Database1 Database { get; set; }

    /// <summary>The end_time property</summary>
    public double? EndTime { get; set; }
    /// <summary>The executed_sql property</summary>
    public string ExecutedSql { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The rows property</summary>
    public int? Rows { get; set; }
    /// <summary>The schema property</summary>
    public string Schema { get; set; }

    /// <summary>The sql property</summary>
    public string Sql { get; set; }

    /// <summary>The sql_tables property</summary>
    public UntypedNode SqlTables { get; private set; }

    /// <summary>The start_time property</summary>
    public double? StartTime { get; set; }
    /// <summary>The status property</summary>
    public string Status { get; set; }

    /// <summary>The tab_name property</summary>
    public string TabName { get; set; }

    /// <summary>The tmp_table_name property</summary>
    public string TmpTableName { get; set; }

    /// <summary>The tracking_url property</summary>
    public string TrackingUrl { get; set; }

    /// <summary>The user property</summary>
    public KClient.Models.User User { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.QueryRestApi.Get_list"/> and sets the default values.
    /// </summary>
    public Get_list()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.QueryRestApi.Get_list"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.QueryRestApi.Get_list CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.QueryRestApi.Get_list();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "database", n => { Database = n.GetObjectValue<KClient.Models.Database1>(KClient.Models.Database1.CreateFromDiscriminatorValue); } },
            { "end_time", n => { EndTime = n.GetDoubleValue(); } },
            { "executed_sql", n => { ExecutedSql = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "rows", n => { Rows = n.GetIntValue(); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "sql_tables", n => { SqlTables = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "start_time", n => { StartTime = n.GetDoubleValue(); } },
            { "status", n => { Status = n.GetStringValue(); } },
            { "tab_name", n => { TabName = n.GetStringValue(); } },
            { "tmp_table_name", n => { TmpTableName = n.GetStringValue(); } },
            { "tracking_url", n => { TrackingUrl = n.GetStringValue(); } },
            { "user", n => { User = n.GetObjectValue<KClient.Models.User>(KClient.Models.User.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteObjectValue<KClient.Models.Database1>("database", Database);
        writer.WriteDoubleValue("end_time", EndTime);
        writer.WriteStringValue("executed_sql", ExecutedSql);
        writer.WriteIntValue("id", Id);
        writer.WriteIntValue("rows", Rows);
        writer.WriteStringValue("schema", Schema);
        writer.WriteStringValue("sql", Sql);
        writer.WriteDoubleValue("start_time", StartTime);
        writer.WriteStringValue("status", Status);
        writer.WriteStringValue("tab_name", TabName);
        writer.WriteStringValue("tmp_table_name", TmpTableName);
        writer.WriteStringValue("tracking_url", TrackingUrl);
        writer.WriteObjectValue<KClient.Models.User>("user", User);
        writer.WriteAdditionalData(AdditionalData);
    }
}
