
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Favorites;

[Obsolete("This class is obsolete. Use FavoritesDeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class FavoritesResponse : KApi.Dashboard.Item.Favorites.FavoritesDeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Dashboard.Item.Favorites.FavoritesResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new KApi.Dashboard.Item.Favorites.FavoritesResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Dashboard.Item.Favorites.FavoritesResponse();
    }
}
