
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class DatasetColumnsPut : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The advanced_data_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? AdvancedDataType { get; set; }
#nullable restore
#else
    public string AdvancedDataType { get; set; }
#endif
    /// <summary>The column_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ColumnName { get; set; }
#nullable restore
#else
    public string ColumnName { get; set; }
#endif
    /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Description { get; set; }
#nullable restore
#else
    public string Description { get; set; }
#endif
    /// <summary>The expression property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Expression { get; set; }
#nullable restore
#else
    public string Expression { get; set; }
#endif
    /// <summary>The extra property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Extra { get; set; }
#nullable restore
#else
    public string Extra { get; set; }
#endif
    /// <summary>The filterable property</summary>
    public bool? Filterable { get; set; }
    /// <summary>The groupby property</summary>
    public bool? Groupby { get; set; }
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The is_active property</summary>
    public bool? IsActive { get; set; }
    /// <summary>The is_dttm property</summary>
    public bool? IsDttm { get; set; }
    /// <summary>The python_date_format property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? PythonDateFormat { get; set; }
#nullable restore
#else
    public string PythonDateFormat { get; set; }
#endif
    /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Type { get; set; }
#nullable restore
#else
    public string Type { get; set; }
#endif
    /// <summary>The uuid property</summary>
    public Guid? Uuid { get; set; }
    /// <summary>The verbose_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? VerboseName { get; set; }
#nullable restore
#else
    public string VerboseName { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DatasetColumnsPut"/> and sets the default values.
    /// </summary>
    public DatasetColumnsPut()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatasetColumnsPut"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DatasetColumnsPut CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DatasetColumnsPut();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "advanced_data_type", n => { AdvancedDataType = n.GetStringValue(); } },
            { "column_name", n => { ColumnName = n.GetStringValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "expression", n => { Expression = n.GetStringValue(); } },
            { "extra", n => { Extra = n.GetStringValue(); } },
            { "filterable", n => { Filterable = n.GetBoolValue(); } },
            { "groupby", n => { Groupby = n.GetBoolValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "is_active", n => { IsActive = n.GetBoolValue(); } },
            { "is_dttm", n => { IsDttm = n.GetBoolValue(); } },
            { "python_date_format", n => { PythonDateFormat = n.GetStringValue(); } },
            { "type", n => { Type = n.GetStringValue(); } },
            { "uuid", n => { Uuid = n.GetGuidValue(); } },
            { "verbose_name", n => { VerboseName = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("advanced_data_type", AdvancedDataType);
        writer.WriteStringValue("column_name", ColumnName);
        writer.WriteStringValue("description", Description);
        writer.WriteStringValue("expression", Expression);
        writer.WriteStringValue("extra", Extra);
        writer.WriteBoolValue("filterable", Filterable);
        writer.WriteBoolValue("groupby", Groupby);
        writer.WriteIntValue("id", Id);
        writer.WriteBoolValue("is_active", IsActive);
        writer.WriteBoolValue("is_dttm", IsDttm);
        writer.WriteStringValue("python_date_format", PythonDateFormat);
        writer.WriteStringValue("type", Type);
        writer.WriteGuidValue("uuid", Uuid);
        writer.WriteStringValue("verbose_name", VerboseName);
        writer.WriteAdditionalData(AdditionalData);
    }
}
