namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SwarmLimit // (swarm.Limit)
{
    [DataMember(Name = "NanoCPUs", EmitDefaultValue = false)]
    [JsonPropertyName("NanoCPUs")]
    public long NanoCPUs { get; set; }

    [DataMember(Name = "MemoryBytes", EmitDefaultValue = false)]
    [JsonPropertyName("MemoryBytes")]
    public long MemoryBytes { get; set; }

    [DataMember(Name = "Pids", EmitDefaultValue = false)]
    [JsonPropertyName("Pids")]
    public long Pids { get; set; }
}
