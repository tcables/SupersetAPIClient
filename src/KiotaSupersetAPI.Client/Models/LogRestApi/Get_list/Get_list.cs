
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.LogRestApi.Get_list
{
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Get_list : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Action { get; set; }
#nullable restore
#else
        public string Action { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The dashboard_id property</summary>
        public int? DashboardId { get; set; }
        /// <summary>The dttm property</summary>
        public DateTimeOffset? Dttm { get; set; }
        /// <summary>The duration_ms property</summary>
        public int? DurationMs { get; set; }
        /// <summary>The json property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Json { get; set; }
#nullable restore
#else
        public string Json { get; set; }
#endif
        /// <summary>The referrer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Referrer { get; set; }
#nullable restore
#else
        public string Referrer { get; set; }
#endif
        /// <summary>The slice_id property</summary>
        public int? SliceId { get; set; }
        /// <summary>The user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.LogRestApi.Get_list.User? User { get; set; }
#nullable restore
#else
        public KClient.Models.LogRestApi.Get_list.User User { get; set; }
#endif
        /// <summary>The user_id property</summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="KClient.Models.LogRestApi.Get_list.Get_list"/> and sets the default values.
        /// </summary>
        public Get_list()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KClient.Models.LogRestApi.Get_list.Get_list"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KClient.Models.LogRestApi.Get_list.Get_list CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KClient.Models.LogRestApi.Get_list.Get_list();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetStringValue(); } },
                { "dashboard_id", n => { DashboardId = n.GetIntValue(); } },
                { "dttm", n => { Dttm = n.GetDateTimeOffsetValue(); } },
                { "duration_ms", n => { DurationMs = n.GetIntValue(); } },
                { "json", n => { Json = n.GetStringValue(); } },
                { "referrer", n => { Referrer = n.GetStringValue(); } },
                { "slice_id", n => { SliceId = n.GetIntValue(); } },
                { "user", n => { User = n.GetObjectValue<KClient.Models.LogRestApi.Get_list.User>(KClient.Models.LogRestApi.Get_list.User.CreateFromDiscriminatorValue); } },
                { "user_id", n => { UserId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("action", Action);
            writer.WriteIntValue("dashboard_id", DashboardId);
            writer.WriteDateTimeOffsetValue("dttm", Dttm);
            writer.WriteIntValue("duration_ms", DurationMs);
            writer.WriteStringValue("json", Json);
            writer.WriteStringValue("referrer", Referrer);
            writer.WriteIntValue("slice_id", SliceId);
            writer.WriteObjectValue<KClient.Models.LogRestApi.Get_list.User>("user", User);
            writer.WriteIntValue("user_id", UserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
