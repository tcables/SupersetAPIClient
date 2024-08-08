
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class GetOrCreateDatasetSchema : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The always_filter_main_dttm property</summary>
    public bool? AlwaysFilterMainDttm { get; set; }
    /// <summary>ID of database table belongs to</summary>
    public int? DatabaseId { get; set; }
    /// <summary>The normalize_columns property</summary>
    public bool? NormalizeColumns { get; set; }
    /// <summary>The schema the table belongs to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Schema { get; set; }
#nullable restore
#else
    public string Schema { get; set; }
#endif
    /// <summary>Name of table</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? TableName { get; set; }
#nullable restore
#else
    public string TableName { get; set; }
#endif
    /// <summary>Template params for the table</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? TemplateParams { get; set; }
#nullable restore
#else
    public string TemplateParams { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.GetOrCreateDatasetSchema"/> and sets the default values.
    /// </summary>
    public GetOrCreateDatasetSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.GetOrCreateDatasetSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.GetOrCreateDatasetSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.GetOrCreateDatasetSchema();
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
            { "database_id", n => { DatabaseId = n.GetIntValue(); } },
            { "normalize_columns", n => { NormalizeColumns = n.GetBoolValue(); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "table_name", n => { TableName = n.GetStringValue(); } },
            { "template_params", n => { TemplateParams = n.GetStringValue(); } },
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
        writer.WriteIntValue("database_id", DatabaseId);
        writer.WriteBoolValue("normalize_columns", NormalizeColumns);
        writer.WriteStringValue("schema", Schema);
        writer.WriteStringValue("table_name", TableName);
        writer.WriteStringValue("template_params", TemplateParams);
        writer.WriteAdditionalData(AdditionalData);
    }
}
