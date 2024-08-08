
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.AnnotationLayer;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Annotation_layerGetResponse : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The total record count on the backend</summary>
    public double? Count { get; set; }
    /// <summary>The description_columns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KApi.AnnotationLayer.Annotation_layerGetResponse_description_columns? DescriptionColumns { get; set; }
#nullable restore
#else
    public KApi.AnnotationLayer.Annotation_layerGetResponse_description_columns DescriptionColumns { get; set; }
#endif
    /// <summary>A list of item ids, useful when you don&apos;t know the column id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<string>? Ids { get; set; }
#nullable restore
#else
    public List<string> Ids { get; set; }
#endif
    /// <summary>The label_columns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KApi.AnnotationLayer.Annotation_layerGetResponse_label_columns? LabelColumns { get; set; }
#nullable restore
#else
    public KApi.AnnotationLayer.Annotation_layerGetResponse_label_columns LabelColumns { get; set; }
#endif
    /// <summary>A list of columns</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<string>? ListColumns { get; set; }
#nullable restore
#else
    public List<string> ListColumns { get; set; }
#endif
    /// <summary>A title to render. Will be translated by babel</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ListTitle { get; set; }
#nullable restore
#else
    public string ListTitle { get; set; }
#endif
    /// <summary>A list of allowed columns to sort</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<string>? OrderColumns { get; set; }
#nullable restore
#else
    public List<string> OrderColumns { get; set; }
#endif
    /// <summary>The result from the get list query</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<KClient.Models.AnnotationLayerRestApi.Get_list.Get_list>? Result { get; set; }
#nullable restore
#else
    public List<KClient.Models.AnnotationLayerRestApi.Get_list.Get_list> Result { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KApi.AnnotationLayer.Annotation_layerGetResponse"/> and sets the default values.
    /// </summary>
    public Annotation_layerGetResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.AnnotationLayer.Annotation_layerGetResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.AnnotationLayer.Annotation_layerGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.AnnotationLayer.Annotation_layerGetResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "count", n => { Count = n.GetDoubleValue(); } },
            { "description_columns", n => { DescriptionColumns = n.GetObjectValue<KApi.AnnotationLayer.Annotation_layerGetResponse_description_columns>(KApi.AnnotationLayer.Annotation_layerGetResponse_description_columns.CreateFromDiscriminatorValue); } },
            { "ids", n => { Ids = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "label_columns", n => { LabelColumns = n.GetObjectValue<KApi.AnnotationLayer.Annotation_layerGetResponse_label_columns>(KApi.AnnotationLayer.Annotation_layerGetResponse_label_columns.CreateFromDiscriminatorValue); } },
            { "list_columns", n => { ListColumns = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "list_title", n => { ListTitle = n.GetStringValue(); } },
            { "order_columns", n => { OrderColumns = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "result", n => { Result = n.GetCollectionOfObjectValues<KClient.Models.AnnotationLayerRestApi.Get_list.Get_list>(KClient.Models.AnnotationLayerRestApi.Get_list.Get_list.CreateFromDiscriminatorValue)?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteDoubleValue("count", Count);
        writer.WriteObjectValue<KApi.AnnotationLayer.Annotation_layerGetResponse_description_columns>("description_columns", DescriptionColumns);
        writer.WriteCollectionOfPrimitiveValues<string>("ids", Ids);
        writer.WriteObjectValue<KApi.AnnotationLayer.Annotation_layerGetResponse_label_columns>("label_columns", LabelColumns);
        writer.WriteCollectionOfPrimitiveValues<string>("list_columns", ListColumns);
        writer.WriteStringValue("list_title", ListTitle);
        writer.WriteCollectionOfPrimitiveValues<string>("order_columns", OrderColumns);
        writer.WriteCollectionOfObjectValues<KClient.Models.AnnotationLayerRestApi.Get_list.Get_list>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
