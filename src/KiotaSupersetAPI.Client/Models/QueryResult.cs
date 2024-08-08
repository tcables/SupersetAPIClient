
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models
{
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Db { get; set; }
#nullable restore
#else
        public string Db { get; set; }
#endif
        /// <summary>The dbId property</summary>
        public int? DbId { get; set; }
        /// <summary>The endDttm property</summary>
        public double? EndDttm { get; set; }
        /// <summary>The errorMessage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorMessage { get; set; }
#nullable restore
#else
        public string ErrorMessage { get; set; }
#endif
        /// <summary>The executedSql property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExecutedSql { get; set; }
#nullable restore
#else
        public string ExecutedSql { get; set; }
#endif
        /// <summary>The extra property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.QueryResult_extra? Extra { get; set; }
#nullable restore
#else
        public KClient.Models.QueryResult_extra Extra { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The limit property</summary>
        public int? Limit { get; set; }
        /// <summary>The limitingFactor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LimitingFactor { get; set; }
#nullable restore
#else
        public string LimitingFactor { get; set; }
#endif
        /// <summary>The progress property</summary>
        public int? Progress { get; set; }
        /// <summary>The queryId property</summary>
        public int? QueryId { get; set; }
        /// <summary>The resultsKey property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResultsKey { get; set; }
#nullable restore
#else
        public string ResultsKey { get; set; }
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
        /// <summary>The serverId property</summary>
        public int? ServerId { get; set; }
        /// <summary>The sql property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sql { get; set; }
#nullable restore
#else
        public string Sql { get; set; }
#endif
        /// <summary>The sqlEditorId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SqlEditorId { get; set; }
#nullable restore
#else
        public string SqlEditorId { get; set; }
#endif
        /// <summary>The startDttm property</summary>
        public double? StartDttm { get; set; }
        /// <summary>The state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>The tab property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tab { get; set; }
#nullable restore
#else
        public string Tab { get; set; }
#endif
        /// <summary>The tempSchema property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TempSchema { get; set; }
#nullable restore
#else
        public string TempSchema { get; set; }
#endif
        /// <summary>The tempTable property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TempTable { get; set; }
#nullable restore
#else
        public string TempTable { get; set; }
#endif
        /// <summary>The trackingUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrackingUrl { get; set; }
#nullable restore
#else
        public string TrackingUrl { get; set; }
#endif
        /// <summary>The user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? User { get; set; }
#nullable restore
#else
        public string User { get; set; }
#endif
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
}
