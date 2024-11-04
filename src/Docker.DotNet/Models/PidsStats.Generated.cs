namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PidsStats // (container.PidsStats)
{
    [DataMember(Name = "current", EmitDefaultValue = false)]
    [JsonPropertyName("current")]
    public ulong Current { get; set; }

    [DataMember(Name = "limit", EmitDefaultValue = false)]
    [JsonPropertyName("limit")]
    public ulong Limit { get; set; }
}
