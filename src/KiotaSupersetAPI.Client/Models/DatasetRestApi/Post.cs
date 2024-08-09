
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.DatasetRestApi;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Post : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The always_filter_main_dttm property</summary>
    public bool? AlwaysFilterMainDttm { get; set; }
    /// <summary>The database property</summary>
    public int? Database { get; set; }
    /// <summary>The external_url property</summary>
    public string ExternalUrl { get; set; }

    /// <summary>The is_managed_externally property</summary>
    public bool? IsManagedExternally { get; set; }
    /// <summary>The normalize_columns property</summary>
    public bool? NormalizeColumns { get; set; }
    /// <summary>The owners property</summary>
    public List<int?> Owners { get; set; }

    /// <summary>The schema property</summary>
    public string Schema { get; set; }

    /// <summary>The sql property</summary>
    public string Sql { get; set; }

    /// <summary>The table_name property</summary>
    public string TableName { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.DatasetRestApi.Post"/> and sets the default values.
    /// </summary>
    public Post()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.DatasetRestApi.Post"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.DatasetRestApi.Post CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.DatasetRestApi.Post();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "always_filter_main_dttm", n => { AlwaysFilterMainDttm = n.GetBoolValue(); } },
            { "database", n => { Database = n.GetIntValue(); } },
            { "external_url", n => { ExternalUrl = n.GetStringValue(); } },
            { "is_managed_externally", n => { IsManagedExternally = n.GetBoolValue(); } },
            { "normalize_columns", n => { NormalizeColumns = n.GetBoolValue(); } },
            { "owners", n => { Owners = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
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
        writer.WriteBoolValue("always_filter_main_dttm", AlwaysFilterMainDttm);
        writer.WriteIntValue("database", Database);
        writer.WriteStringValue("external_url", ExternalUrl);
        writer.WriteBoolValue("is_managed_externally", IsManagedExternally);
        writer.WriteBoolValue("normalize_columns", NormalizeColumns);
        writer.WriteCollectionOfPrimitiveValues<int?>("owners", Owners);
        writer.WriteStringValue("schema", Schema);
        writer.WriteStringValue("sql", Sql);
        writer.WriteStringValue("table_name", TableName);
        writer.WriteAdditionalData(AdditionalData);
    }
}
