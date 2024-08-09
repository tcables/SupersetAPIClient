
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Datasource.Item.Item.Column.Item.Values;

[Obsolete("This class is obsolete. Use ValuesGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class ValuesResponse : Datasource.Item.Item.Column.Item.Values.ValuesGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Datasource.Item.Item.Column.Item.Values.ValuesResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Datasource.Item.Item.Column.Item.Values.ValuesResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Datasource.Item.Item.Column.Item.Values.ValuesResponse();
    }
}
