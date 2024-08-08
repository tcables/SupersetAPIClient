
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
public partial class ChartDataFilter : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The column to filter by. Can be either a string (physical or saved expression) or an object (adhoc column)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? Col { get; set; }
#nullable restore
#else
    public UntypedNode Col { get; set; }
#endif
    /// <summary>Optional time grain for temporal filters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Grain { get; set; }
#nullable restore
#else
    public string Grain { get; set; }
#endif
    /// <summary>Indicates if the filter has been added by a filter component as opposed to being a part of the original query.</summary>
    public bool? IsExtra { get; set; }
    /// <summary>The comparison operator.</summary>
    public KClient.Models.ChartDataFilter_op? Op { get; set; }
    /// <summary>The value or values to compare against. Can be a string, integer, decimal, None or list, depending on the operator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? Val { get; set; }
#nullable restore
#else
    public UntypedNode Val { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.ChartDataFilter"/> and sets the default values.
    /// </summary>
    public ChartDataFilter()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ChartDataFilter"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.ChartDataFilter CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.ChartDataFilter();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "col", n => { Col = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "grain", n => { Grain = n.GetStringValue(); } },
            { "isExtra", n => { IsExtra = n.GetBoolValue(); } },
            { "op", n => { Op = n.GetEnumValue<KClient.Models.ChartDataFilter_op>(); } },
            { "val", n => { Val = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<UntypedNode>("col", Col);
        writer.WriteStringValue("grain", Grain);
        writer.WriteBoolValue("isExtra", IsExtra);
        writer.WriteEnumValue<KClient.Models.ChartDataFilter_op>("op", Op);
        writer.WriteObjectValue<UntypedNode>("val", Val);
        writer.WriteAdditionalData(AdditionalData);
    }
}
