namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ReplicatedJob // (swarm.ReplicatedJob)
{
    [DataMember(Name = "MaxConcurrent", EmitDefaultValue = false)]
    [JsonPropertyName("MaxConcurrent")]
    public ulong? MaxConcurrent { get; set; }

    [DataMember(Name = "TotalCompletions", EmitDefaultValue = false)]
    [JsonPropertyName("TotalCompletions")]
    public ulong? TotalCompletions { get; set; }
}
