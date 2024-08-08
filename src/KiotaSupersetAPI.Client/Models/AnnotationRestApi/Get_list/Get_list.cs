
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.AnnotationRestApi.Get_list
{
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Get_list : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The changed_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.AnnotationRestApi.Get_list.User1? ChangedBy { get; set; }
#nullable restore
#else
        public KClient.Models.AnnotationRestApi.Get_list.User1 ChangedBy { get; set; }
#endif
        /// <summary>The changed_on_delta_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? ChangedOnDeltaHumanized { get; private set; }
#nullable restore
#else
        public UntypedNode ChangedOnDeltaHumanized { get; private set; }
#endif
        /// <summary>The created_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.AnnotationRestApi.Get_list.User? CreatedBy { get; set; }
#nullable restore
#else
        public KClient.Models.AnnotationRestApi.Get_list.User CreatedBy { get; set; }
#endif
        /// <summary>The end_dttm property</summary>
        public DateTimeOffset? EndDttm { get; set; }
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The long_descr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LongDescr { get; set; }
#nullable restore
#else
        public string LongDescr { get; set; }
#endif
        /// <summary>The short_descr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShortDescr { get; set; }
#nullable restore
#else
        public string ShortDescr { get; set; }
#endif
        /// <summary>The start_dttm property</summary>
        public DateTimeOffset? StartDttm { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="KClient.Models.AnnotationRestApi.Get_list.Get_list"/> and sets the default values.
        /// </summary>
        public Get_list()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KClient.Models.AnnotationRestApi.Get_list.Get_list"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KClient.Models.AnnotationRestApi.Get_list.Get_list CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KClient.Models.AnnotationRestApi.Get_list.Get_list();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.AnnotationRestApi.Get_list.User1>(KClient.Models.AnnotationRestApi.Get_list.User1.CreateFromDiscriminatorValue); } },
                { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "created_by", n => { CreatedBy = n.GetObjectValue<KClient.Models.AnnotationRestApi.Get_list.User>(KClient.Models.AnnotationRestApi.Get_list.User.CreateFromDiscriminatorValue); } },
                { "end_dttm", n => { EndDttm = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "long_descr", n => { LongDescr = n.GetStringValue(); } },
                { "short_descr", n => { ShortDescr = n.GetStringValue(); } },
                { "start_dttm", n => { StartDttm = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<KClient.Models.AnnotationRestApi.Get_list.User1>("changed_by", ChangedBy);
            writer.WriteObjectValue<KClient.Models.AnnotationRestApi.Get_list.User>("created_by", CreatedBy);
            writer.WriteDateTimeOffsetValue("end_dttm", EndDttm);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("long_descr", LongDescr);
            writer.WriteStringValue("short_descr", ShortDescr);
            writer.WriteDateTimeOffsetValue("start_dttm", StartDttm);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
