namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class BlkioStatEntry // (container.BlkioStatEntry)
{
    [DataMember(Name = "major", EmitDefaultValue = false)]
    [JsonPropertyName("major")]
    public ulong Major { get; set; }

    [DataMember(Name = "minor", EmitDefaultValue = false)]
    [JsonPropertyName("minor")]
    public ulong Minor { get; set; }

    [DataMember(Name = "op", EmitDefaultValue = false)]
    [JsonPropertyName("op")]
    public string Op { get; set; }

    [DataMember(Name = "value", EmitDefaultValue = false)]
    [JsonPropertyName("value")]
    public ulong Value { get; set; }
}
