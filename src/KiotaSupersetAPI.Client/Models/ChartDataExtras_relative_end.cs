using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>End time for relative time deltas. Default: `config[&quot;DEFAULT_RELATIVE_START_TIME&quot;]`</summary>
public enum ChartDataExtras_relative_end
{
    [EnumMember(Value = "today")]
#pragma warning disable CS1591
    Today,
#pragma warning restore CS1591
    [EnumMember(Value = "now")]
#pragma warning disable CS1591
    Now,
#pragma warning restore CS1591
}
