namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ReplicatedService // (swarm.ReplicatedService)
{
    [DataMember(Name = "Replicas", EmitDefaultValue = false)]
    [JsonPropertyName("Replicas")]
    public ulong? Replicas { get; set; }
}
