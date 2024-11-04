namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ThrottlingData // (container.ThrottlingData)
{
    [DataMember(Name = "periods", EmitDefaultValue = false)]
    [JsonPropertyName("periods")]
    public ulong Periods { get; set; }

    [DataMember(Name = "throttled_periods", EmitDefaultValue = false)]
    [JsonPropertyName("throttled_periods")]
    public ulong ThrottledPeriods { get; set; }

    [DataMember(Name = "throttled_time", EmitDefaultValue = false)]
    [JsonPropertyName("throttled_time")]
    public ulong ThrottledTime { get; set; }
}
