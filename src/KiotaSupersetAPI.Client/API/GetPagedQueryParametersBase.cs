using System;
using System.Text.Json.Serialization;
using KiotaSupersetAPI.Client.Utilities;
using Newtonsoft.Json;

namespace KiotaSupersetAPI.Client.API;

[Serializable]
[JsonSerializable(typeof(GetPagedQueryParametersBase))]
public class GetPagedQueryParametersBase
{
    protected GetPagedQueryParametersBase() { }

    public GetPagedQueryParametersBase(
        int page, int pageSize)
    {
        Page = Check.InRange(page, nameof(page), 1);
        PageSize = Check.InRange(pageSize, nameof(pageSize), 1);
    }


    [JsonProperty("page")]
    public int Page { get; protected set; }

    [JsonProperty("page_size")]
    public int PageSize { get; protected set; }


    /// <summary>
    /// returns this class as a JSON serialized and escaped string
    /// </summary>
    /// <returns></returns>
    public virtual string GetSerializedAndEscaped()
    {
        string serialized = JsonConvert.SerializeObject(this);
        string escaped = Uri.EscapeDataString(serialized);

        return escaped;
    }
}
