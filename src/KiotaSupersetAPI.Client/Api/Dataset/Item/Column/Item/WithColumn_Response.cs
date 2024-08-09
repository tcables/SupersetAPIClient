
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dataset.Item.Column.Item;

[Obsolete("This class is obsolete. Use WithColumn_DeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithColumn_Response : Dataset.Item.Column.Item.WithColumn_DeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dataset.Item.Column.Item.WithColumn_Response"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Dataset.Item.Column.Item.WithColumn_Response CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Dataset.Item.Column.Item.WithColumn_Response();
    }
}
