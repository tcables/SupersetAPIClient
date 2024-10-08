
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.ChartRestAPI.Get_list;

[GeneratedCode("Kiota", "1.16.0")]
public partial class SqlaTable : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The default_endpoint property</summary>
    public string DefaultEndpoint { get; set; }

    /// <summary>The table_name property</summary>
    public string TableName { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.ChartRestAPI.Get_list.SqlaTable"/> and sets the default values.
    /// </summary>
    public SqlaTable()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.ChartRestAPI.Get_list.SqlaTable"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.ChartRestAPI.Get_list.SqlaTable CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.ChartRestAPI.Get_list.SqlaTable();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "default_endpoint", n => { DefaultEndpoint = n.GetStringValue(); } },
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
        writer.WriteStringValue("default_endpoint", DefaultEndpoint);
        writer.WriteStringValue("table_name", TableName);
        writer.WriteAdditionalData(AdditionalData);
    }
}
