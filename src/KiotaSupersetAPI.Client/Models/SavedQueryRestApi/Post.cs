
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.SavedQueryRestAPI;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Post : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The db_id property</summary>
    public int? DbId { get; set; }
    /// <summary>The description property</summary>
    public string Description { get; set; }

    /// <summary>The label property</summary>
    public string Label { get; set; }

    /// <summary>The schema property</summary>
    public string Schema { get; set; }

    /// <summary>The sql property</summary>
    public string Sql { get; set; }

    /// <summary>The template_parameters property</summary>
    public string TemplateParameters { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.SavedQueryRestAPI.Post"/> and sets the default values.
    /// </summary>
    public Post()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.SavedQueryRestAPI.Post"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.SavedQueryRestAPI.Post CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.SavedQueryRestAPI.Post();
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
