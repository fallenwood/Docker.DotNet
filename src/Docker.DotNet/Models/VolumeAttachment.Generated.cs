namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class VolumeAttachment // (swarm.VolumeAttachment)
{
    [DataMember(Name = "ID", EmitDefaultValue = false)]
    [JsonPropertyName("ID")]
    public string ID { get; set; }

    [DataMember(Name = "Source", EmitDefaultValue = false)]
    [JsonPropertyName("Source")]
    public string Source { get; set; }

    [DataMember(Name = "Target", EmitDefaultValue = false)]
    [JsonPropertyName("Target")]
    public string Target { get; set; }
}
