
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Dataset.Item.Column.Item;

[Obsolete("This class is obsolete. Use WithColumn_DeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class WithColumn_Response : KApi.Dataset.Item.Column.Item.WithColumn_DeleteResponse, IParsable
#pragma warning restore CS1591
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Item.Column.Item.WithColumn_Response"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new KApi.Dataset.Item.Column.Item.WithColumn_Response CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Dataset.Item.Column.Item.WithColumn_Response();
    }
}
