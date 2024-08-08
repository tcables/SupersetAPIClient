// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Models
{
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class AnnotationLayer : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Type of annotation layer</summary>
        public global::KiotaSupersetAPI.Client.Models.AnnotationLayer_annotationType? AnnotationType { get; set; }
        /// <summary>Layer color</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Color { get; set; }
#nullable restore
#else
        public string Color { get; set; }
#endif
        /// <summary>Columns to use as the description. If none are provided, all will be shown.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DescriptionColumns { get; set; }
#nullable restore
#else
        public List<string> DescriptionColumns { get; set; }
#endif
        /// <summary>Should line be hidden. Only applies to line annotations</summary>
        public bool? HideLine { get; set; }
        /// <summary>Column containing end of interval. Only applies to interval layers</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IntervalEndColumn { get; set; }
#nullable restore
#else
        public string IntervalEndColumn { get; set; }
#endif
        /// <summary>Name of layer</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Opacity of layer</summary>
        public global::KiotaSupersetAPI.Client.Models.AnnotationLayer_opacity? Opacity { get; set; }
        /// <summary>which properties should be overridable</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::KiotaSupersetAPI.Client.Models.AnnotationLayer_overrides? Overrides { get; set; }
#nullable restore
#else
        public global::KiotaSupersetAPI.Client.Models.AnnotationLayer_overrides Overrides { get; set; }
#endif
        /// <summary>Should the layer be shown</summary>
        public bool? Show { get; set; }
        /// <summary>Should the label always be shown</summary>
        public bool? ShowLabel { get; set; }
        /// <summary>Should markers be shown. Only applies to line annotations.</summary>
        public bool? ShowMarkers { get; set; }
        /// <summary>Type of source for annotation data</summary>
        public global::KiotaSupersetAPI.Client.Models.AnnotationLayer_sourceType? SourceType { get; set; }
        /// <summary>Line style. Only applies to time-series annotations</summary>
        public global::KiotaSupersetAPI.Client.Models.AnnotationLayer_style? Style { get; set; }
        /// <summary>Column with event date or interval start date</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeColumn { get; set; }
#nullable restore
#else
        public string TimeColumn { get; set; }
#endif
        /// <summary>Column with title</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TitleColumn { get; set; }
#nullable restore
#else
        public string TitleColumn { get; set; }
#endif
        /// <summary>For formula annotations, this contains the formula. For other types, this is the primary key of the source object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Value { get; set; }
#nullable restore
#else
        public UntypedNode Value { get; set; }
#endif
        /// <summary>Width of annotation line</summary>
        public double? Width { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Models.AnnotationLayer"/> and sets the default values.
        /// </summary>
        public AnnotationLayer()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Models.AnnotationLayer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::KiotaSupersetAPI.Client.Models.AnnotationLayer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KiotaSupersetAPI.Client.Models.AnnotationLayer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "annotationType", n => { AnnotationType = n.GetEnumValue<global::KiotaSupersetAPI.Client.Models.AnnotationLayer_annotationType>(); } },
                { "color", n => { Color = n.GetStringValue(); } },
                { "descriptionColumns", n => { DescriptionColumns = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "hideLine", n => { HideLine = n.GetBoolValue(); } },
                { "intervalEndColumn", n => { IntervalEndColumn = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "opacity", n => { Opacity = n.GetEnumValue<global::KiotaSupersetAPI.Client.Models.AnnotationLayer_opacity>(); } },
                { "overrides", n => { Overrides = n.GetObjectValue<global::KiotaSupersetAPI.Client.Models.AnnotationLayer_overrides>(global::KiotaSupersetAPI.Client.Models.AnnotationLayer_overrides.CreateFromDiscriminatorValue); } },
                { "show", n => { Show = n.GetBoolValue(); } },
                { "showLabel", n => { ShowLabel = n.GetBoolValue(); } },
                { "showMarkers", n => { ShowMarkers = n.GetBoolValue(); } },
                { "sourceType", n => { SourceType = n.GetEnumValue<global::KiotaSupersetAPI.Client.Models.AnnotationLayer_sourceType>(); } },
                { "style", n => { Style = n.GetEnumValue<global::KiotaSupersetAPI.Client.Models.AnnotationLayer_style>(); } },
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
            writer.WriteEnumValue<global::KiotaSupersetAPI.Client.Models.AnnotationLayer_annotationType>("annotationType", AnnotationType);
            writer.WriteStringValue("color", Color);
            writer.WriteCollectionOfPrimitiveValues<string>("descriptionColumns", DescriptionColumns);
            writer.WriteBoolValue("hideLine", HideLine);
            writer.WriteStringValue("intervalEndColumn", IntervalEndColumn);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::KiotaSupersetAPI.Client.Models.AnnotationLayer_opacity>("opacity", Opacity);
            writer.WriteObjectValue<global::KiotaSupersetAPI.Client.Models.AnnotationLayer_overrides>("overrides", Overrides);
            writer.WriteBoolValue("show", Show);
            writer.WriteBoolValue("showLabel", ShowLabel);
            writer.WriteBoolValue("showMarkers", ShowMarkers);
            writer.WriteEnumValue<global::KiotaSupersetAPI.Client.Models.AnnotationLayer_sourceType>("sourceType", SourceType);
            writer.WriteEnumValue<global::KiotaSupersetAPI.Client.Models.AnnotationLayer_style>("style", Style);
            writer.WriteStringValue("timeColumn", TimeColumn);
            writer.WriteStringValue("titleColumn", TitleColumn);
            writer.WriteObjectValue<UntypedNode>("value", Value);
            writer.WriteDoubleValue("width", Width);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
