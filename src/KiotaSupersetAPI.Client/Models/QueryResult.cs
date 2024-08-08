
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class QueryResult : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The ctas property</summary>
    public bool? Ctas { get; set; }
    /// <summary>The db property</summary>
    public string Db { get; set; }

    /// <summary>The dbId property</summary>
    public int? DbId { get; set; }
    /// <summary>The endDttm property</summary>
    public double? EndDttm { get; set; }
    /// <summary>The errorMessage property</summary>
    public string ErrorMessage { get; set; }

    /// <summary>The executedSql property</summary>
    public string ExecutedSql { get; set; }

    /// <summary>The extra property</summary>
    public KClient.Models.QueryResult_extra Extra { get; set; }

    /// <summary>The id property</summary>
    public string Id { get; set; }

    /// <summary>The limit property</summary>
    public int? Limit { get; set; }
    /// <summary>The limitingFactor property</summary>
    public string LimitingFactor { get; set; }

    /// <summary>The progress property</summary>
    public int? Progress { get; set; }
    /// <summary>The queryId property</summary>
    public int? QueryId { get; set; }
    /// <summary>The resultsKey property</summary>
    public string ResultsKey { get; set; }

    /// <summary>The rows property</summary>
    public int? Rows { get; set; }
    /// <summary>The schema property</summary>
    public string Schema { get; set; }

    /// <summary>The serverId property</summary>
    public int? ServerId { get; set; }
    /// <summary>The sql property</summary>
    public string Sql { get; set; }

    /// <summary>The sqlEditorId property</summary>
    public string SqlEditorId { get; set; }

    /// <summary>The startDttm property</summary>
    public double? StartDttm { get; set; }
    /// <summary>The state property</summary>
    public string State { get; set; }

    /// <summary>The tab property</summary>
    public string Tab { get; set; }

    /// <summary>The tempSchema property</summary>
    public string TempSchema { get; set; }

    /// <summary>The tempTable property</summary>
    public string TempTable { get; set; }

    /// <summary>The trackingUrl property</summary>
    public string TrackingUrl { get; set; }

    /// <summary>The user property</summary>
    public string User { get; set; }

    /// <summary>The userId property</summary>
    public int? UserId { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.QueryResult"/> and sets the default values.
    /// </summary>
    public QueryResult()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.QueryResult"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.QueryResult CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.QueryResult();
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
            { "ctas", n => { Ctas = n.GetBoolValue(); } },
            { "db", n => { Db = n.GetStringValue(); } },
            { "dbId", n => { DbId = n.GetIntValue(); } },
            { "endDttm", n => { EndDttm = n.GetDoubleValue(); } },
            { "errorMessage", n => { ErrorMessage = n.GetStringValue(); } },
            { "executedSql", n => { ExecutedSql = n.GetStringValue(); } },
            { "extra", n => { Extra = n.GetObjectValue<KClient.Models.QueryResult_extra>(KClient.Models.QueryResult_extra.CreateFromDiscriminatorValue); } },
            { "id", n => { Id = n.GetStringValue(); } },
            { "limit", n => { Limit = n.GetIntValue(); } },
            { "limitingFactor", n => { LimitingFactor = n.GetStringValue(); } },
            { "progress", n => { Progress = n.GetIntValue(); } },
            { "queryId", n => { QueryId = n.GetIntValue(); } },
            { "resultsKey", n => { ResultsKey = n.GetStringValue(); } },
            { "rows", n => { Rows = n.GetIntValue(); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "serverId", n => { ServerId = n.GetIntValue(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "sqlEditorId", n => { SqlEditorId = n.GetStringValue(); } },
            { "startDttm", n => { StartDttm = n.GetDoubleValue(); } },
            { "state", n => { State = n.GetStringValue(); } },
            { "tab", n => { Tab = n.GetStringValue(); } },
            { "tempSchema", n => { TempSchema = n.GetStringValue(); } },
            { "tempTable", n => { TempTable = n.GetStringValue(); } },
            { "trackingUrl", n => { TrackingUrl = n.GetStringValue(); } },
            { "user", n => { User = n.GetStringValue(); } },
            { "userId", n => { UserId = n.GetIntValue(); } },
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
        writer.WriteBoolValue("ctas", Ctas);
        writer.WriteStringValue("db", Db);
        writer.WriteIntValue("dbId", DbId);
        writer.WriteDoubleValue("endDttm", EndDttm);
        writer.WriteStringValue("errorMessage", ErrorMessage);
        writer.WriteStringValue("executedSql", ExecutedSql);
        writer.WriteObjectValue<KClient.Models.QueryResult_extra>("extra", Extra);
        writer.WriteStringValue("id", Id);
        writer.WriteIntValue("limit", Limit);
        writer.WriteStringValue("limitingFactor", LimitingFactor);
        writer.WriteIntValue("progress", Progress);
        writer.WriteIntValue("queryId", QueryId);
        writer.WriteStringValue("resultsKey", ResultsKey);
        writer.WriteIntValue("rows", Rows);
        writer.WriteStringValue("schema", Schema);
        writer.WriteIntValue("serverId", ServerId);
        writer.WriteStringValue("sql", Sql);
        writer.WriteStringValue("sqlEditorId", SqlEditorId);
        writer.WriteDoubleValue("startDttm", StartDttm);
        writer.WriteStringValue("state", State);
        writer.WriteStringValue("tab", Tab);
        writer.WriteStringValue("tempSchema", TempSchema);
        writer.WriteStringValue("tempTable", TempTable);
        writer.WriteStringValue("trackingUrl", TrackingUrl);
        writer.WriteStringValue("user", User);
        writer.WriteIntValue("userId", UserId);
        writer.WriteAdditionalData(AdditionalData);
    }
}
