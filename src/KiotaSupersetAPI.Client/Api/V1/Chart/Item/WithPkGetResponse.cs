
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Chart.Item;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class WithPkGetResponse : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The description_columns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KApi.Chart.Item.WithPkGetResponse_description_columns? DescriptionColumns { get; set; }
#nullable restore
#else
    public KApi.Chart.Item.WithPkGetResponse_description_columns DescriptionColumns { get; set; }
#endif
    /// <summary>The item id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Id { get; set; }
#nullable restore
#else
    public string Id { get; set; }
#endif
    /// <summary>The label_columns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KApi.Chart.Item.WithPkGetResponse_label_columns? LabelColumns { get; set; }
#nullable restore
#else
    public KApi.Chart.Item.WithPkGetResponse_label_columns LabelColumns { get; set; }
#endif
    /// <summary>The result property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.ChartRestApi.Get.Get? Result { get; set; }
#nullable restore
#else
    public KClient.Models.ChartRestApi.Get.Get Result { get; set; }
#endif
    /// <summary>A list of columns</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<string>? ShowColumns { get; set; }
#nullable restore
#else
    public List<string> ShowColumns { get; set; }
#endif
    /// <summary>A title to render. Will be translated by babel</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ShowTitle { get; set; }
#nullable restore
#else
    public string ShowTitle { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KApi.Chart.Item.WithPkGetResponse"/> and sets the default values.
    /// </summary>
    public WithPkGetResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.Item.WithPkGetResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.Chart.Item.WithPkGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Chart.Item.WithPkGetResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "description_columns", n => { DescriptionColumns = n.GetObjectValue<KApi.Chart.Item.WithPkGetResponse_description_columns>(KApi.Chart.Item.WithPkGetResponse_description_columns.CreateFromDiscriminatorValue); } },
            { "id", n => { Id = n.GetStringValue(); } },
            { "label_columns", n => { LabelColumns = n.GetObjectValue<KApi.Chart.Item.WithPkGetResponse_label_columns>(KApi.Chart.Item.WithPkGetResponse_label_columns.CreateFromDiscriminatorValue); } },
            { "result", n => { Result = n.GetObjectValue<KClient.Models.ChartRestApi.Get.Get>(KClient.Models.ChartRestApi.Get.Get.CreateFromDiscriminatorValue); } },
            { "show_columns", n => { ShowColumns = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "show_title", n => { ShowTitle = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KApi.Chart.Item.WithPkGetResponse_description_columns>("description_columns", DescriptionColumns);
        writer.WriteStringValue("id", Id);
        writer.WriteObjectValue<KApi.Chart.Item.WithPkGetResponse_label_columns>("label_columns", LabelColumns);
        writer.WriteObjectValue<KClient.Models.ChartRestApi.Get.Get>("result", Result);
        writer.WriteCollectionOfPrimitiveValues<string>("show_columns", ShowColumns);
        writer.WriteStringValue("show_title", ShowTitle);
        writer.WriteAdditionalData(AdditionalData);
    }
}
