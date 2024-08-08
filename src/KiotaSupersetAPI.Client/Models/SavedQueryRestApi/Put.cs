
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.SavedQueryRestApi;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Put : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The db_id property</summary>
    public int? DbId { get; set; }
    /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Description { get; set; }
#nullable restore
#else
    public string Description { get; set; }
#endif
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
    /// <summary>The template_parameters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? TemplateParameters { get; set; }
#nullable restore
#else
    public string TemplateParameters { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.SavedQueryRestApi.Put"/> and sets the default values.
    /// </summary>
    public Put()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.SavedQueryRestApi.Put"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.SavedQueryRestApi.Put CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.SavedQueryRestApi.Put();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "db_id", n => { DbId = n.GetIntValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "label", n => { Label = n.GetStringValue(); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
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
        writer.WriteIntValue("db_id", DbId);
        writer.WriteStringValue("description", Description);
        writer.WriteStringValue("label", Label);
        writer.WriteStringValue("schema", Schema);
        writer.WriteStringValue("sql", Sql);
        writer.WriteStringValue("template_parameters", TemplateParameters);
        writer.WriteAdditionalData(AdditionalData);
    }
}
