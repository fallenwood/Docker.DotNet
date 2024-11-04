namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PortConfig // (swarm.PortConfig)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "Protocol", EmitDefaultValue = false)]
    [JsonPropertyName("Protocol")]
    public string Protocol { get; set; }

    [DataMember(Name = "TargetPort", EmitDefaultValue = false)]
    [JsonPropertyName("TargetPort")]
    public uint TargetPort { get; set; }

    [DataMember(Name = "PublishedPort", EmitDefaultValue = false)]
    [JsonPropertyName("PublishedPort")]
    public uint PublishedPort { get; set; }

    [DataMember(Name = "PublishMode", EmitDefaultValue = false)]
    [JsonPropertyName("PublishMode")]
    public string PublishMode { get; set; }
}
