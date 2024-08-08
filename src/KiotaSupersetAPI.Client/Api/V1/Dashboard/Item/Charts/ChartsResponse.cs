
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Charts
{
    [Obsolete("This class is obsolete. Use ChartsGetResponse instead.")]
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class ChartsResponse : KApi.Dashboard.Item.Charts.ChartsGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KApi.Dashboard.Item.Charts.ChartsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KApi.Dashboard.Item.Charts.ChartsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KApi.Dashboard.Item.Charts.ChartsResponse();
        }
    }
}
