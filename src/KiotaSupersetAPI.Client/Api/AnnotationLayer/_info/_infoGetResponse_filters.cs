
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.AnnotationLayer._info;

[GeneratedCode("Kiota", "1.16.0")]
public partial class _infoGetResponse_filters : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The column_name property</summary>
    public List<AnnotationLayer._info._infoGetResponse_filters_column_name> ColumnName { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="AnnotationLayer._info._infoGetResponse_filters"/> and sets the default values.
    /// </summary>
    public _infoGetResponse_filters()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer._info._infoGetResponse_filters"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static AnnotationLayer._info._infoGetResponse_filters CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new _info._infoGetResponse_filters();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "column_name", n => { ColumnName = n.GetCollectionOfObjectValues<AnnotationLayer._info._infoGetResponse_filters_column_name>(AnnotationLayer._info._infoGetResponse_filters_column_name.CreateFromDiscriminatorValue)?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteCollectionOfObjectValues<AnnotationLayer._info._infoGetResponse_filters_column_name>("column_name", ColumnName);
        writer.WriteAdditionalData(AdditionalData);
    }
}
