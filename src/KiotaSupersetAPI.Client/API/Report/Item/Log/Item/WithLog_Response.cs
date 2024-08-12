
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Report.Item.Log.Item;

[Obsolete("This class is obsolete. Use WithLog_GetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithLog_Response : KiotaSupersetAPI.Client.API.Report.Item.Log.Item.WithLog_GetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="API.Report.Item.Log.Item.WithLog_Response"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new WithLog_Response CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new WithLog_Response();
    }
}
