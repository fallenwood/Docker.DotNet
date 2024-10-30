namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ReplicatedService // (swarm.ReplicatedService)
{
    [DataMember(Name = "Replicas", EmitDefaultValue = false)]
    public ulong? Replicas { get; set; }
}
