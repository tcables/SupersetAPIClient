
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class ExecutePayloadSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The client_id property</summary>
    public string ClientId { get; set; }

    /// <summary>The ctas_method property</summary>
    public string CtasMethod { get; set; }

    /// <summary>The database_id property</summary>
    public int? DatabaseId { get; set; }
    /// <summary>The expand_data property</summary>
    public bool? ExpandData { get; set; }
    /// <summary>The json property</summary>
    public bool? Json { get; set; }
    /// <summary>The queryLimit property</summary>
    public int? QueryLimit { get; set; }
    /// <summary>The runAsync property</summary>
    public bool? RunAsync { get; set; }
    /// <summary>The schema property</summary>
    public string Schema { get; set; }

    /// <summary>The select_as_cta property</summary>
    public bool? SelectAsCta { get; set; }
    /// <summary>The sql property</summary>
    public string Sql { get; set; }

    /// <summary>The sql_editor_id property</summary>
    public string SqlEditorId { get; set; }

    /// <summary>The tab property</summary>
    public string Tab { get; set; }

    /// <summary>The templateParams property</summary>
    public string TemplateParams { get; set; }

    /// <summary>The tmp_table_name property</summary>
    public string TmpTableName { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.ExecutePayloadSchema"/> and sets the default values.
    /// </summary>
    public ExecutePayloadSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.ExecutePayloadSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.ExecutePayloadSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.ExecutePayloadSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "client_id", n => { ClientId = n.GetStringValue(); } },
            { "ctas_method", n => { CtasMethod = n.GetStringValue(); } },
            { "database_id", n => { DatabaseId = n.GetIntValue(); } },
            { "expand_data", n => { ExpandData = n.GetBoolValue(); } },
            { "json", n => { Json = n.GetBoolValue(); } },
            { "queryLimit", n => { QueryLimit = n.GetIntValue(); } },
            { "runAsync", n => { RunAsync = n.GetBoolValue(); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "select_as_cta", n => { SelectAsCta = n.GetBoolValue(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "sql_editor_id", n => { SqlEditorId = n.GetStringValue(); } },
            { "tab", n => { Tab = n.GetStringValue(); } },
            { "templateParams", n => { TemplateParams = n.GetStringValue(); } },
            { "tmp_table_name", n => { TmpTableName = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("client_id", ClientId);
        writer.WriteStringValue("ctas_method", CtasMethod);
        writer.WriteIntValue("database_id", DatabaseId);
        writer.WriteBoolValue("expand_data", ExpandData);
        writer.WriteBoolValue("json", Json);
        writer.WriteIntValue("queryLimit", QueryLimit);
        writer.WriteBoolValue("runAsync", RunAsync);
        writer.WriteStringValue("schema", Schema);
        writer.WriteBoolValue("select_as_cta", SelectAsCta);
        writer.WriteStringValue("sql", Sql);
        writer.WriteStringValue("sql_editor_id", SqlEditorId);
        writer.WriteStringValue("tab", Tab);
        writer.WriteStringValue("templateParams", TemplateParams);
        writer.WriteStringValue("tmp_table_name", TmpTableName);
        writer.WriteAdditionalData(AdditionalData);
    }
}
