namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ThrottleDevice // (blkiodev.ThrottleDevice)
{
    [DataMember(Name = "Path", EmitDefaultValue = false)]
    [JsonPropertyName("Path")]
    public string Path { get; set; }

    [DataMember(Name = "Rate", EmitDefaultValue = false)]
    [JsonPropertyName("Rate")]
    public ulong Rate { get; set; }
}
