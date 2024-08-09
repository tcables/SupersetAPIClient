
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Sqllab.Format_sql;

[Obsolete("This class is obsolete. Use Format_sqlPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Format_sqlResponse : KApi.Sqllab.Format_sql.Format_sqlPostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Sqllab.Format_sql.Format_sqlResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new KApi.Sqllab.Format_sql.Format_sqlResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Sqllab.Format_sql.Format_sqlResponse();
    }
}
