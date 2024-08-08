
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
public partial class ExploreContextSchema : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The dataset property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.Dataset? Dataset { get; set; }
#nullable restore
#else
    public KClient.Models.Dataset Dataset { get; set; }
#endif
    /// <summary>Form data from the Explore controls used to form the chart&apos;s data query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.ExploreContextSchema_form_data? FormData { get; set; }
#nullable restore
#else
    public KClient.Models.ExploreContextSchema_form_data FormData { get; set; }
#endif
    /// <summary>Any message related to the processed request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Message { get; set; }
#nullable restore
#else
    public string Message { get; set; }
#endif
    /// <summary>The slice property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.Slice? Slice { get; set; }
#nullable restore
#else
    public KClient.Models.Slice Slice { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.ExploreContextSchema"/> and sets the default values.
    /// </summary>
    public ExploreContextSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ExploreContextSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.ExploreContextSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.ExploreContextSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "dataset", n => { Dataset = n.GetObjectValue<KClient.Models.Dataset>(KClient.Models.Dataset.CreateFromDiscriminatorValue); } },
            { "form_data", n => { FormData = n.GetObjectValue<KClient.Models.ExploreContextSchema_form_data>(KClient.Models.ExploreContextSchema_form_data.CreateFromDiscriminatorValue); } },
            { "message", n => { Message = n.GetStringValue(); } },
            { "slice", n => { Slice = n.GetObjectValue<KClient.Models.Slice>(KClient.Models.Slice.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KClient.Models.Dataset>("dataset", Dataset);
        writer.WriteObjectValue<KClient.Models.ExploreContextSchema_form_data>("form_data", FormData);
        writer.WriteStringValue("message", Message);
        writer.WriteObjectValue<KClient.Models.Slice>("slice", Slice);
        writer.WriteAdditionalData(AdditionalData);
    }
}
