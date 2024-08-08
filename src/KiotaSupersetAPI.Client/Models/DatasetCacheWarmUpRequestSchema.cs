
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
public partial class DatasetCacheWarmUpRequestSchema : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The ID of the dashboard to get filters for when warming cache</summary>
    public int? DashboardId { get; set; }
    /// <summary>The name of the database where the table is located</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? DbName { get; set; }
#nullable restore
#else
    public string DbName { get; set; }
#endif
    /// <summary>Extra filters to apply when warming up cache</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ExtraFilters { get; set; }
#nullable restore
#else
    public string ExtraFilters { get; set; }
#endif
    /// <summary>The name of the table to warm up cache for</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? TableName { get; set; }
#nullable restore
#else
    public string TableName { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DatasetCacheWarmUpRequestSchema"/> and sets the default values.
    /// </summary>
    public DatasetCacheWarmUpRequestSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatasetCacheWarmUpRequestSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DatasetCacheWarmUpRequestSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DatasetCacheWarmUpRequestSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "dashboard_id", n => { DashboardId = n.GetIntValue(); } },
            { "db_name", n => { DbName = n.GetStringValue(); } },
            { "extra_filters", n => { ExtraFilters = n.GetStringValue(); } },
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
        writer.WriteIntValue("dashboard_id", DashboardId);
        writer.WriteStringValue("db_name", DbName);
        writer.WriteStringValue("extra_filters", ExtraFilters);
        writer.WriteStringValue("table_name", TableName);
        writer.WriteAdditionalData(AdditionalData);
    }
}
