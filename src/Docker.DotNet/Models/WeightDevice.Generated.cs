namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class WeightDevice // (blkiodev.WeightDevice)
{
    [DataMember(Name = "Path", EmitDefaultValue = false)]
    [JsonPropertyName("Path")]
    public string Path { get; set; }

    [DataMember(Name = "Weight", EmitDefaultValue = false)]
    [JsonPropertyName("Weight")]
    public ushort Weight { get; set; }
}
