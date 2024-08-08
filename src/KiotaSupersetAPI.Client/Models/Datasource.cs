
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models
{
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Datasource : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Datasource name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DatabaseName { get; set; }
#nullable restore
#else
        public string DatabaseName { get; set; }
#endif
        /// <summary>The datasource name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DatasourceName { get; set; }
#nullable restore
#else
        public string DatasourceName { get; set; }
#endif
        /// <summary>The type of dataset/datasource identified on `datasource_id`.</summary>
        public KClient.Models.Datasource_datasource_type? DatasourceType { get; set; }
        /// <summary>Datasource schema</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Schema { get; set; }
#nullable restore
#else
        public string Schema { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KClient.Models.Datasource"/> and sets the default values.
        /// </summary>
        public Datasource()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KClient.Models.Datasource"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KClient.Models.Datasource CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KClient.Models.Datasource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "database_name", n => { DatabaseName = n.GetStringValue(); } },
                { "datasource_name", n => { DatasourceName = n.GetStringValue(); } },
                { "datasource_type", n => { DatasourceType = n.GetEnumValue<KClient.Models.Datasource_datasource_type>(); } },
                { "schema", n => { Schema = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("database_name", DatabaseName);
            writer.WriteStringValue("datasource_name", DatasourceName);
            writer.WriteEnumValue<KClient.Models.Datasource_datasource_type>("datasource_type", DatasourceType);
            writer.WriteStringValue("schema", Schema);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
