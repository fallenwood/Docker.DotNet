namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ReplicatedJob // (swarm.ReplicatedJob)
{
    [DataMember(Name = "MaxConcurrent", EmitDefaultValue = false)]
    public ulong? MaxConcurrent { get; set; }

    [DataMember(Name = "TotalCompletions", EmitDefaultValue = false)]
    public ulong? TotalCompletions { get; set; }
}
