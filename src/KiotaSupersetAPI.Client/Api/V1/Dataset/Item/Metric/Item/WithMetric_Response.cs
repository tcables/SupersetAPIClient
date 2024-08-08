
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Dataset.Item.Metric.Item
{
    [Obsolete("This class is obsolete. Use WithMetric_DeleteResponse instead.")]
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class WithMetric_Response : KApi.Dataset.Item.Metric.Item.WithMetric_DeleteResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KApi.Dataset.Item.Metric.Item.WithMetric_Response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KApi.Dataset.Item.Metric.Item.WithMetric_Response CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KApi.Dataset.Item.Metric.Item.WithMetric_Response();
        }
    }
}
