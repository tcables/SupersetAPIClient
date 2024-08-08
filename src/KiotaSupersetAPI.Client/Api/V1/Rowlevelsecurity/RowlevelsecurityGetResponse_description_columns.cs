
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Rowlevelsecurity;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class RowlevelsecurityGetResponse_description_columns : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The description for the column name. Will be translated by babel</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ColumnName { get; set; }
#nullable restore
#else
    public string ColumnName { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KApi.Rowlevelsecurity.RowlevelsecurityGetResponse_description_columns"/> and sets the default values.
    /// </summary>
    public RowlevelsecurityGetResponse_description_columns()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Rowlevelsecurity.RowlevelsecurityGetResponse_description_columns"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.Rowlevelsecurity.RowlevelsecurityGetResponse_description_columns CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Rowlevelsecurity.RowlevelsecurityGetResponse_description_columns();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "column_name", n => { ColumnName = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("column_name", ColumnName);
        writer.WriteAdditionalData(AdditionalData);
    }
}
