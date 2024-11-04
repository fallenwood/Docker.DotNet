namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class CapacityRange // (volume.CapacityRange)
{
    [DataMember(Name = "RequiredBytes", EmitDefaultValue = false)]
    [JsonPropertyName("RequiredBytes")]
    public long RequiredBytes { get; set; }

    [DataMember(Name = "LimitBytes", EmitDefaultValue = false)]
    [JsonPropertyName("LimitBytes")]
    public long LimitBytes { get; set; }
}
