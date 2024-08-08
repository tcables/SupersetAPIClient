
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.SavedQueryRestApi.Get;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Get : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The changed_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.SavedQueryRestApi.Get.User1? ChangedBy { get; set; }
#nullable restore
#else
    public KClient.Models.SavedQueryRestApi.Get.User1 ChangedBy { get; set; }
#endif
    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The changed_on_delta_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? ChangedOnDeltaHumanized { get; private set; }
#nullable restore
#else
    public UntypedNode ChangedOnDeltaHumanized { get; private set; }
#endif
    /// <summary>The created_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.SavedQueryRestApi.Get.User? CreatedBy { get; set; }
#nullable restore
#else
    public KClient.Models.SavedQueryRestApi.Get.User CreatedBy { get; set; }
#endif
    /// <summary>The database property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.SavedQueryRestApi.Get.Database? Database { get; set; }
#nullable restore
#else
    public KClient.Models.SavedQueryRestApi.Get.Database Database { get; set; }
#endif
    /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Description { get; set; }
#nullable restore
#else
    public string Description { get; set; }
#endif
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The label property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Label { get; set; }
#nullable restore
#else
    public string Label { get; set; }
#endif
    /// <summary>The schema property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Schema { get; set; }
#nullable restore
#else
    public string Schema { get; set; }
#endif
    /// <summary>The sql property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Sql { get; set; }
#nullable restore
#else
    public string Sql { get; set; }
#endif
    /// <summary>The sql_tables property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? SqlTables { get; private set; }
#nullable restore
#else
    public UntypedNode SqlTables { get; private set; }
#endif
    /// <summary>The template_parameters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? TemplateParameters { get; set; }
#nullable restore
#else
    public string TemplateParameters { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.SavedQueryRestApi.Get.Get"/> and sets the default values.
    /// </summary>
    public Get()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.SavedQueryRestApi.Get.Get"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.SavedQueryRestApi.Get.Get CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.SavedQueryRestApi.Get.Get();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.SavedQueryRestApi.Get.User1>(KClient.Models.SavedQueryRestApi.Get.User1.CreateFromDiscriminatorValue); } },
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "created_by", n => { CreatedBy = n.GetObjectValue<KClient.Models.SavedQueryRestApi.Get.User>(KClient.Models.SavedQueryRestApi.Get.User.CreateFromDiscriminatorValue); } },
            { "database", n => { Database = n.GetObjectValue<KClient.Models.SavedQueryRestApi.Get.Database>(KClient.Models.SavedQueryRestApi.Get.Database.CreateFromDiscriminatorValue); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "label", n => { Label = n.GetStringValue(); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "sql_tables", n => { SqlTables = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "template_parameters", n => { TemplateParameters = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KClient.Models.SavedQueryRestApi.Get.User1>("changed_by", ChangedBy);
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteObjectValue<KClient.Models.SavedQueryRestApi.Get.User>("created_by", CreatedBy);
        writer.WriteObjectValue<KClient.Models.SavedQueryRestApi.Get.Database>("database", Database);
        writer.WriteStringValue("description", Description);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("label", Label);
        writer.WriteStringValue("schema", Schema);
        writer.WriteStringValue("sql", Sql);
        writer.WriteStringValue("template_parameters", TemplateParameters);
        writer.WriteAdditionalData(AdditionalData);
    }
}
