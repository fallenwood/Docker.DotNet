namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class VolumeSecret // (volume.Secret)
{
    [DataMember(Name = "Key", EmitDefaultValue = false)]
    [JsonPropertyName("Key")]
    public string Key { get; set; }

    [DataMember(Name = "Secret", EmitDefaultValue = false)]
    [JsonPropertyName("Secret")]
    public string Secret { get; set; }
}
