
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard;

[GeneratedCode("Kiota", "1.16.0")]
public partial class DashboardGetResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The total record count on the backend</summary>
    public double? Count { get; set; }
    /// <summary>The description_columns property</summary>
    public Dashboard.DashboardGetResponse_description_columns DescriptionColumns { get; set; }

    /// <summary>A list of item ids, useful when you don&apos;t know the column id</summary>
    public List<string> Ids { get; set; }

    /// <summary>The label_columns property</summary>
    public Dashboard.DashboardGetResponse_label_columns LabelColumns { get; set; }

    /// <summary>A list of columns</summary>
    public List<string> ListColumns { get; set; }

    /// <summary>A title to render. Will be translated by babel</summary>
    public string ListTitle { get; set; }

    /// <summary>A list of allowed columns to sort</summary>
    public List<string> OrderColumns { get; set; }

    /// <summary>The result from the get list query</summary>
    public List<Models.DashboardRestAPI.Get_list.Get_list> Result { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Dashboard.DashboardGetResponse"/> and sets the default values.
    /// </summary>
    public DashboardGetResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dashboard.DashboardGetResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Dashboard.DashboardGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Dashboard.DashboardGetResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "count", n => { Count = n.GetDoubleValue(); } },
            { "description_columns", n => { DescriptionColumns = n.GetObjectValue<Dashboard.DashboardGetResponse_description_columns>(Dashboard.DashboardGetResponse_description_columns.CreateFromDiscriminatorValue); } },
            { "ids", n => { Ids = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "label_columns", n => { LabelColumns = n.GetObjectValue<Dashboard.DashboardGetResponse_label_columns>(Dashboard.DashboardGetResponse_label_columns.CreateFromDiscriminatorValue); } },
            { "list_columns", n => { ListColumns = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "list_title", n => { ListTitle = n.GetStringValue(); } },
            { "order_columns", n => { OrderColumns = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "result", n => { Result = n.GetCollectionOfObjectValues<Models.DashboardRestAPI.Get_list.Get_list>(Models.DashboardRestAPI.Get_list.Get_list.CreateFromDiscriminatorValue)?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteDoubleValue("count", Count);
        writer.WriteObjectValue<Dashboard.DashboardGetResponse_description_columns>("description_columns", DescriptionColumns);
        writer.WriteCollectionOfPrimitiveValues<string>("ids", Ids);
        writer.WriteObjectValue<Dashboard.DashboardGetResponse_label_columns>("label_columns", LabelColumns);
        writer.WriteCollectionOfPrimitiveValues<string>("list_columns", ListColumns);
        writer.WriteStringValue("list_title", ListTitle);
        writer.WriteCollectionOfPrimitiveValues<string>("order_columns", OrderColumns);
        writer.WriteCollectionOfObjectValues<Models.DashboardRestAPI.Get_list.Get_list>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
