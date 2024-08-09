
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class AnnotationLayer : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Type of annotation layer</summary>
    public Models.AnnotationLayer_annotationType? AnnotationType { get; set; }
    /// <summary>Layer color</summary>
    public string Color { get; set; }

    /// <summary>Columns to use as the description. If none are provided, all will be shown.</summary>
    public List<string> DescriptionColumns { get; set; }

    /// <summary>Should line be hidden. Only applies to line annotations</summary>
    public bool? HideLine { get; set; }
    /// <summary>Column containing end of interval. Only applies to interval layers</summary>
    public string IntervalEndColumn { get; set; }

    /// <summary>Name of layer</summary>
    public string Name { get; set; }

    /// <summary>Opacity of layer</summary>
    public Models.AnnotationLayer_opacity? Opacity { get; set; }
    /// <summary>which properties should be overridable</summary>
    public Models.AnnotationLayer_overrides Overrides { get; set; }

    /// <summary>Should the layer be shown</summary>
    public bool? Show { get; set; }
    /// <summary>Should the label always be shown</summary>
    public bool? ShowLabel { get; set; }
    /// <summary>Should markers be shown. Only applies to line annotations.</summary>
    public bool? ShowMarkers { get; set; }
    /// <summary>Type of source for annotation data</summary>
    public Models.AnnotationLayer_sourceType? SourceType { get; set; }
    /// <summary>Line style. Only applies to time-series annotations</summary>
    public Models.AnnotationLayer_style? Style { get; set; }
    /// <summary>Column with event date or interval start date</summary>
    public string TimeColumn { get; set; }

    /// <summary>Column with title</summary>
    public string TitleColumn { get; set; }

    /// <summary>For formula annotations, this contains the formula. For other types, this is the primary key of the source object.</summary>
    public UntypedNode Value { get; set; }

    /// <summary>Width of annotation line</summary>
    public double? Width { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="Models.AnnotationLayer"/> and sets the default values.
    /// </summary>
    public AnnotationLayer()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.AnnotationLayer"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.AnnotationLayer CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.AnnotationLayer();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "annotationType", n => { AnnotationType = n.GetEnumValue<Models.AnnotationLayer_annotationType>(); } },
            { "color", n => { Color = n.GetStringValue(); } },
            { "descriptionColumns", n => { DescriptionColumns = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "hideLine", n => { HideLine = n.GetBoolValue(); } },
            { "intervalEndColumn", n => { IntervalEndColumn = n.GetStringValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "opacity", n => { Opacity = n.GetEnumValue<Models.AnnotationLayer_opacity>(); } },
            { "overrides", n => { Overrides = n.GetObjectValue<Models.AnnotationLayer_overrides>(Models.AnnotationLayer_overrides.CreateFromDiscriminatorValue); } },
            { "show", n => { Show = n.GetBoolValue(); } },
            { "showLabel", n => { ShowLabel = n.GetBoolValue(); } },
            { "showMarkers", n => { ShowMarkers = n.GetBoolValue(); } },
            { "sourceType", n => { SourceType = n.GetEnumValue<Models.AnnotationLayer_sourceType>(); } },
            { "style", n => { Style = n.GetEnumValue<Models.AnnotationLayer_style>(); } },
            { "timeColumn", n => { TimeColumn = n.GetStringValue(); } },
            { "titleColumn", n => { TitleColumn = n.GetStringValue(); } },
            { "value", n => { Value = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "width", n => { Width = n.GetDoubleValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteEnumValue<Models.AnnotationLayer_annotationType>("annotationType", AnnotationType);
        writer.WriteStringValue("color", Color);
        writer.WriteCollectionOfPrimitiveValues<string>("descriptionColumns", DescriptionColumns);
        writer.WriteBoolValue("hideLine", HideLine);
        writer.WriteStringValue("intervalEndColumn", IntervalEndColumn);
        writer.WriteStringValue("name", Name);
        writer.WriteEnumValue<Models.AnnotationLayer_opacity>("opacity", Opacity);
        writer.WriteObjectValue<Models.AnnotationLayer_overrides>("overrides", Overrides);
        writer.WriteBoolValue("show", Show);
        writer.WriteBoolValue("showLabel", ShowLabel);
        writer.WriteBoolValue("showMarkers", ShowMarkers);
        writer.WriteEnumValue<Models.AnnotationLayer_sourceType>("sourceType", SourceType);
        writer.WriteEnumValue<Models.AnnotationLayer_style>("style", Style);
        writer.WriteStringValue("timeColumn", TimeColumn);
        writer.WriteStringValue("titleColumn", TitleColumn);
        writer.WriteObjectValue<UntypedNode>("value", Value);
        writer.WriteDoubleValue("width", Width);
        writer.WriteAdditionalData(AdditionalData);
    }
}
