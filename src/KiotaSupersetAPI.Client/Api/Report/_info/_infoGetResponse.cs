
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Report._info;

[GeneratedCode("Kiota", "1.16.0")]
public partial class _infoGetResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>The add_columns property</summary>
    public _info._infoGetResponse_add_columns AddColumns { get; set; }

    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The edit_columns property</summary>
    public _info._infoGetResponse_edit_columns EditColumns { get; set; }

    /// <summary>The filters property</summary>
    public _info._infoGetResponse_filters Filters { get; set; }

    /// <summary>The user permissions for this API resource</summary>
    public List<string> Permissions { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Report._info._infoGetResponse"/> and sets the default values.
    /// </summary>
    public _infoGetResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Report._info._infoGetResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Report._info._infoGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new _info._infoGetResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "add_columns", n => { AddColumns = n.GetObjectValue<Report._info._infoGetResponse_add_columns>(Report._info._infoGetResponse_add_columns.CreateFromDiscriminatorValue); } },
            { "edit_columns", n => { EditColumns = n.GetObjectValue<Report._info._infoGetResponse_edit_columns>(Report._info._infoGetResponse_edit_columns.CreateFromDiscriminatorValue); } },
            { "filters", n => { Filters = n.GetObjectValue<Report._info._infoGetResponse_filters>(Report._info._infoGetResponse_filters.CreateFromDiscriminatorValue); } },
            { "permissions", n => { Permissions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<Report._info._infoGetResponse_add_columns>("add_columns", AddColumns);
        writer.WriteObjectValue<Report._info._infoGetResponse_edit_columns>("edit_columns", EditColumns);
        writer.WriteObjectValue<Report._info._infoGetResponse_filters>("filters", Filters);
        writer.WriteCollectionOfPrimitiveValues<string>("permissions", Permissions);
        writer.WriteAdditionalData(AdditionalData);
    }
}
