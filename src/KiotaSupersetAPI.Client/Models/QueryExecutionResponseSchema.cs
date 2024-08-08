
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class QueryExecutionResponseSchema : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The columns property</summary>
    public List<KClient.Models.QueryExecutionResponseSchema_columns> Columns { get; set; }

    /// <summary>The data property</summary>
    public List<KClient.Models.QueryExecutionResponseSchema_data> Data { get; set; }

    /// <summary>The expanded_columns property</summary>
    public List<KClient.Models.QueryExecutionResponseSchema_expanded_columns> ExpandedColumns { get; set; }

    /// <summary>The query property</summary>
    public KClient.Models.QueryResult Query { get; set; }

    /// <summary>The query_id property</summary>
    public int? QueryId { get; set; }
    /// <summary>The selected_columns property</summary>
    public List<KClient.Models.QueryExecutionResponseSchema_selected_columns> SelectedColumns { get; set; }

    /// <summary>The status property</summary>
    public string Status { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.QueryExecutionResponseSchema"/> and sets the default values.
    /// </summary>
    public QueryExecutionResponseSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.QueryExecutionResponseSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.QueryExecutionResponseSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.QueryExecutionResponseSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "columns", n => { Columns = n.GetCollectionOfObjectValues<KClient.Models.QueryExecutionResponseSchema_columns>(KClient.Models.QueryExecutionResponseSchema_columns.CreateFromDiscriminatorValue)?.ToList(); } },
            { "data", n => { Data = n.GetCollectionOfObjectValues<KClient.Models.QueryExecutionResponseSchema_data>(KClient.Models.QueryExecutionResponseSchema_data.CreateFromDiscriminatorValue)?.ToList(); } },
            { "expanded_columns", n => { ExpandedColumns = n.GetCollectionOfObjectValues<KClient.Models.QueryExecutionResponseSchema_expanded_columns>(KClient.Models.QueryExecutionResponseSchema_expanded_columns.CreateFromDiscriminatorValue)?.ToList(); } },
            { "query", n => { Query = n.GetObjectValue<KClient.Models.QueryResult>(KClient.Models.QueryResult.CreateFromDiscriminatorValue); } },
            { "query_id", n => { QueryId = n.GetIntValue(); } },
            { "selected_columns", n => { SelectedColumns = n.GetCollectionOfObjectValues<KClient.Models.QueryExecutionResponseSchema_selected_columns>(KClient.Models.QueryExecutionResponseSchema_selected_columns.CreateFromDiscriminatorValue)?.ToList(); } },
            { "status", n => { Status = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteCollectionOfObjectValues<KClient.Models.QueryExecutionResponseSchema_columns>("columns", Columns);
        writer.WriteCollectionOfObjectValues<KClient.Models.QueryExecutionResponseSchema_data>("data", Data);
        writer.WriteCollectionOfObjectValues<KClient.Models.QueryExecutionResponseSchema_expanded_columns>("expanded_columns", ExpandedColumns);
        writer.WriteObjectValue<KClient.Models.QueryResult>("query", Query);
        writer.WriteIntValue("query_id", QueryId);
        writer.WriteCollectionOfObjectValues<KClient.Models.QueryExecutionResponseSchema_selected_columns>("selected_columns", SelectedColumns);
        writer.WriteStringValue("status", Status);
        writer.WriteAdditionalData(AdditionalData);
    }
}
