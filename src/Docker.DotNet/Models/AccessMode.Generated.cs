namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class AccessMode // (volume.AccessMode)
{
    [DataMember(Name = "Scope", EmitDefaultValue = false)]
    [JsonPropertyName("Scope")]
    public string Scope { get; set; }

    [DataMember(Name = "Sharing", EmitDefaultValue = false)]
    [JsonPropertyName("Sharing")]
    public string Sharing { get; set; }

    [DataMember(Name = "MountVolume", EmitDefaultValue = false)]
    [JsonPropertyName("MountVolume")]
    public TypeMount MountVolume { get; set; }

    [DataMember(Name = "BlockVolume", EmitDefaultValue = false)]
    [JsonPropertyName("BlockVolume")]
    public TypeBlock BlockVolume { get; set; }
}
