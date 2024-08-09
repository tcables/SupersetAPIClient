
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Database.Item.Tables;

[Obsolete("This class is obsolete. Use TablesGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class TablesResponse : Database.Item.Tables.TablesGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Database.Item.Tables.TablesResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Database.Item.Tables.TablesResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Database.Item.Tables.TablesResponse();
    }
}
