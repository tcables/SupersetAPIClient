
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class ChartDataResponseResult : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>All requested annotation data</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<KClient.Models.ChartDataResponseResult_annotation_data>? AnnotationData { get; set; }
#nullable restore
#else
    public List<KClient.Models.ChartDataResponseResult_annotation_data> AnnotationData { get; set; }
#endif
    /// <summary>A list with applied filters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<KClient.Models.ChartDataResponseResult_applied_filters>? AppliedFilters { get; set; }
#nullable restore
#else
    public List<KClient.Models.ChartDataResponseResult_applied_filters> AppliedFilters { get; set; }
#endif
    /// <summary>Cache timestamp</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? CachedDttm { get; set; }
#nullable restore
#else
    public string CachedDttm { get; set; }
#endif
    /// <summary>Unique cache key for query object</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? CacheKey { get; set; }
#nullable restore
#else
    public string CacheKey { get; set; }
#endif
    /// <summary>Cache timeout in following order: custom timeout, datasource timeout, cache default timeout, config default cache timeout.</summary>
    public int? CacheTimeout { get; set; }
    /// <summary>A list of column names</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<string>? Colnames { get; set; }
#nullable restore
#else
    public List<string> Colnames { get; set; }
#endif
    /// <summary>A list of generic data types of each column</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<int?>? Coltypes { get; set; }
#nullable restore
#else
    public List<int?> Coltypes { get; set; }
#endif
    /// <summary>A list with results</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<KClient.Models.ChartDataResponseResult_data>? Data { get; set; }
#nullable restore
#else
    public List<KClient.Models.ChartDataResponseResult_data> Data { get; set; }
#endif
    /// <summary>Error</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Error { get; set; }
#nullable restore
#else
    public string Error { get; set; }
#endif
    /// <summary>Start timestamp of time range</summary>
    public int? FromDttm { get; set; }
    /// <summary>Is the result cached</summary>
    public bool? IsCached { get; set; }
    /// <summary>The executed query statement</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Query { get; set; }
#nullable restore
#else
    public string Query { get; set; }
#endif
    /// <summary>A list with rejected filters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<KClient.Models.ChartDataResponseResult_rejected_filters>? RejectedFilters { get; set; }
#nullable restore
#else
    public List<KClient.Models.ChartDataResponseResult_rejected_filters> RejectedFilters { get; set; }
#endif
    /// <summary>Amount of rows in result set</summary>
    public int? Rowcount { get; set; }
    /// <summary>Stacktrace if there was an error</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Stacktrace { get; set; }
#nullable restore
#else
    public string Stacktrace { get; set; }
#endif
    /// <summary>Status of the query</summary>
    public KClient.Models.ChartDataResponseResult_status? Status { get; set; }
    /// <summary>End timestamp of time range</summary>
    public int? ToDttm { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.ChartDataResponseResult"/> and sets the default values.
    /// </summary>
    public ChartDataResponseResult()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ChartDataResponseResult"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.ChartDataResponseResult CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.ChartDataResponseResult();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "annotation_data", n => { AnnotationData = n.GetCollectionOfObjectValues<KClient.Models.ChartDataResponseResult_annotation_data>(KClient.Models.ChartDataResponseResult_annotation_data.CreateFromDiscriminatorValue)?.ToList(); } },
            { "applied_filters", n => { AppliedFilters = n.GetCollectionOfObjectValues<KClient.Models.ChartDataResponseResult_applied_filters>(KClient.Models.ChartDataResponseResult_applied_filters.CreateFromDiscriminatorValue)?.ToList(); } },
            { "cache_key", n => { CacheKey = n.GetStringValue(); } },
            { "cache_timeout", n => { CacheTimeout = n.GetIntValue(); } },
            { "cached_dttm", n => { CachedDttm = n.GetStringValue(); } },
            { "colnames", n => { Colnames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "coltypes", n => { Coltypes = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            { "data", n => { Data = n.GetCollectionOfObjectValues<KClient.Models.ChartDataResponseResult_data>(KClient.Models.ChartDataResponseResult_data.CreateFromDiscriminatorValue)?.ToList(); } },
            { "error", n => { Error = n.GetStringValue(); } },
            { "from_dttm", n => { FromDttm = n.GetIntValue(); } },
            { "is_cached", n => { IsCached = n.GetBoolValue(); } },
            { "query", n => { Query = n.GetStringValue(); } },
            { "rejected_filters", n => { RejectedFilters = n.GetCollectionOfObjectValues<KClient.Models.ChartDataResponseResult_rejected_filters>(KClient.Models.ChartDataResponseResult_rejected_filters.CreateFromDiscriminatorValue)?.ToList(); } },
            { "rowcount", n => { Rowcount = n.GetIntValue(); } },
            { "stacktrace", n => { Stacktrace = n.GetStringValue(); } },
            { "status", n => { Status = n.GetEnumValue<KClient.Models.ChartDataResponseResult_status>(); } },
            { "to_dttm", n => { ToDttm = n.GetIntValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteCollectionOfObjectValues<KClient.Models.ChartDataResponseResult_annotation_data>("annotation_data", AnnotationData);
        writer.WriteCollectionOfObjectValues<KClient.Models.ChartDataResponseResult_applied_filters>("applied_filters", AppliedFilters);
        writer.WriteStringValue("cached_dttm", CachedDttm);
        writer.WriteStringValue("cache_key", CacheKey);
        writer.WriteIntValue("cache_timeout", CacheTimeout);
        writer.WriteCollectionOfPrimitiveValues<string>("colnames", Colnames);
        writer.WriteCollectionOfPrimitiveValues<int?>("coltypes", Coltypes);
        writer.WriteCollectionOfObjectValues<KClient.Models.ChartDataResponseResult_data>("data", Data);
        writer.WriteStringValue("error", Error);
        writer.WriteIntValue("from_dttm", FromDttm);
        writer.WriteBoolValue("is_cached", IsCached);
        writer.WriteStringValue("query", Query);
        writer.WriteCollectionOfObjectValues<KClient.Models.ChartDataResponseResult_rejected_filters>("rejected_filters", RejectedFilters);
        writer.WriteIntValue("rowcount", Rowcount);
        writer.WriteStringValue("stacktrace", Stacktrace);
        writer.WriteEnumValue<KClient.Models.ChartDataResponseResult_status>("status", Status);
        writer.WriteIntValue("to_dttm", ToDttm);
        writer.WriteAdditionalData(AdditionalData);
    }
}
