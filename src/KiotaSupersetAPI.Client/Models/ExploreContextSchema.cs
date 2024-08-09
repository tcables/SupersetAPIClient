
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class ExploreContextSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The dataset property</summary>
    public Models.Dataset Dataset { get; set; }

    /// <summary>Form data from the Explore controls used to form the chart&apos;s data query.</summary>
    public Models.ExploreContextSchema_form_data FormData { get; set; }

    /// <summary>Any message related to the processed request.</summary>
    public string Message { get; set; }

    /// <summary>The slice property</summary>
    public Models.Slice Slice { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.ExploreContextSchema"/> and sets the default values.
    /// </summary>
    public ExploreContextSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.ExploreContextSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.ExploreContextSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.ExploreContextSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "dataset", n => { Dataset = n.GetObjectValue<Models.Dataset>(Models.Dataset.CreateFromDiscriminatorValue); } },
            { "form_data", n => { FormData = n.GetObjectValue<Models.ExploreContextSchema_form_data>(Models.ExploreContextSchema_form_data.CreateFromDiscriminatorValue); } },
            { "message", n => { Message = n.GetStringValue(); } },
            { "slice", n => { Slice = n.GetObjectValue<Models.Slice>(Models.Slice.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<Models.Dataset>("dataset", Dataset);
        writer.WriteObjectValue<Models.ExploreContextSchema_form_data>("form_data", FormData);
        writer.WriteStringValue("message", Message);
        writer.WriteObjectValue<Models.Slice>("slice", Slice);
        writer.WriteAdditionalData(AdditionalData);
    }
}
