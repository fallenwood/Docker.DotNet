namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class UsageData // (volume.UsageData)
{
    [DataMember(Name = "RefCount", EmitDefaultValue = false)]
    [JsonPropertyName("RefCount")]
    public long RefCount { get; set; }

    [DataMember(Name = "Size", EmitDefaultValue = false)]
    [JsonPropertyName("Size")]
    public long Size { get; set; }
}
