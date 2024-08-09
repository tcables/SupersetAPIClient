
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Dataset.Item.Refresh;

[Obsolete("This class is obsolete. Use RefreshPutResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class RefreshResponse : KApi.Dataset.Item.Refresh.RefreshPutResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Item.Refresh.RefreshResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new KApi.Dataset.Item.Refresh.RefreshResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Dataset.Item.Refresh.RefreshResponse();
    }
}
