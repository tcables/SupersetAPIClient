// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using Api = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Models
{
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class CacheInvalidationRequestSchema : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A list of the data source and database names</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::KiotaSupersetAPI.Client.Models.Datasource>? Datasources { get; set; }
#nullable restore
#else
        public List<global::KiotaSupersetAPI.Client.Models.Datasource> Datasources { get; set; }
#endif
        /// <summary>The uid of the dataset/datasource this new chart will use. A complete datasource identification needs `datasource_uid` </summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DatasourceUids { get; set; }
#nullable restore
#else
        public List<string> DatasourceUids { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Models.CacheInvalidationRequestSchema"/> and sets the default values.
        /// </summary>
        public CacheInvalidationRequestSchema()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Models.CacheInvalidationRequestSchema"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::KiotaSupersetAPI.Client.Models.CacheInvalidationRequestSchema CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KiotaSupersetAPI.Client.Models.CacheInvalidationRequestSchema();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "datasource_uids", n => { DatasourceUids = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "datasources", n => { Datasources = n.GetCollectionOfObjectValues<global::KiotaSupersetAPI.Client.Models.Datasource>(global::KiotaSupersetAPI.Client.Models.Datasource.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::KiotaSupersetAPI.Client.Models.Datasource>("datasources", Datasources);
            writer.WriteCollectionOfPrimitiveValues<string>("datasource_uids", DatasourceUids);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
