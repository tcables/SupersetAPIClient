
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
    public partial class SQLLabBootstrapSchema : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The active_tab property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.TabState? ActiveTab { get; set; }
#nullable restore
#else
        public KClient.Models.TabState ActiveTab { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The databases property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.SQLLabBootstrapSchema_databases? Databases { get; set; }
#nullable restore
#else
        public KClient.Models.SQLLabBootstrapSchema_databases Databases { get; set; }
#endif
        /// <summary>The queries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.SQLLabBootstrapSchema_queries? Queries { get; set; }
#nullable restore
#else
        public KClient.Models.SQLLabBootstrapSchema_queries Queries { get; set; }
#endif
        /// <summary>The tab_state_ids property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TabStateIds { get; set; }
#nullable restore
#else
        public List<string> TabStateIds { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KClient.Models.SQLLabBootstrapSchema"/> and sets the default values.
        /// </summary>
        public SQLLabBootstrapSchema()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KClient.Models.SQLLabBootstrapSchema"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KClient.Models.SQLLabBootstrapSchema CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KClient.Models.SQLLabBootstrapSchema();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active_tab", n => { ActiveTab = n.GetObjectValue<KClient.Models.TabState>(KClient.Models.TabState.CreateFromDiscriminatorValue); } },
                { "databases", n => { Databases = n.GetObjectValue<KClient.Models.SQLLabBootstrapSchema_databases>(KClient.Models.SQLLabBootstrapSchema_databases.CreateFromDiscriminatorValue); } },
                { "queries", n => { Queries = n.GetObjectValue<KClient.Models.SQLLabBootstrapSchema_queries>(KClient.Models.SQLLabBootstrapSchema_queries.CreateFromDiscriminatorValue); } },
                { "tab_state_ids", n => { TabStateIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<KClient.Models.TabState>("active_tab", ActiveTab);
            writer.WriteObjectValue<KClient.Models.SQLLabBootstrapSchema_databases>("databases", Databases);
            writer.WriteObjectValue<KClient.Models.SQLLabBootstrapSchema_queries>("queries", Queries);
            writer.WriteCollectionOfPrimitiveValues<string>("tab_state_ids", TabStateIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
