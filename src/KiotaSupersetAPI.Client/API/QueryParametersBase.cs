using Newtonsoft.Json;
using System.Collections.Generic;

namespace KiotaSupersetAPI.Client.API;

public class QueryParametersBase
{
    protected QueryParametersBase() {  }


    [JsonProperty("columns")]
    public List<string> Columns { get; set; }

    [JsonProperty("filters")]
    public List<Filter> Filters { get; set; }

    [JsonProperty("keys")]
    public List<string> Keys { get; set; }

    [JsonProperty("order_column")]
    public string OrderColumn { get; set; }

    [JsonProperty("order_direction")]
    public string OrderDirection { get; set; }

    [JsonProperty("page")]
    public int Page { get; set; }

    [JsonProperty("page_size")]
    public int PageSize { get; set; }
}

public class Filter
{
    [JsonProperty("col")]
    public string Col { get; set; }

    [JsonProperty("opr")]
    public string Opr { get; set; }

    [JsonProperty("value")]
    public object Value { get; set; }
}
