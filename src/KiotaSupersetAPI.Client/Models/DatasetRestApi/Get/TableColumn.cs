
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.DatasetRestApi.Get;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class TableColumn : IAdditionalDataHolder, IParsable
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
    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The column_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ColumnName { get; set; }
#nullable restore
#else
    public string ColumnName { get; set; }
#endif
    /// <summary>The created_on property</summary>
    public DateTimeOffset? CreatedOn { get; set; }
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
    /// <summary>The type_generic property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? TypeGeneric { get; private set; }
#nullable restore
#else
    public UntypedNode TypeGeneric { get; private set; }
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
    /// Instantiates a new <see cref="KClient.Models.DatasetRestApi.Get.TableColumn"/> and sets the default values.
    /// </summary>
    public TableColumn()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatasetRestApi.Get.TableColumn"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DatasetRestApi.Get.TableColumn CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DatasetRestApi.Get.TableColumn();
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
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "column_name", n => { ColumnName = n.GetStringValue(); } },
            { "created_on", n => { CreatedOn = n.GetDateTimeOffsetValue(); } },
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
            { "type_generic", n => { TypeGeneric = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
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
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteStringValue("column_name", ColumnName);
        writer.WriteDateTimeOffsetValue("created_on", CreatedOn);
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
