namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ServiceMode // (swarm.ServiceMode)
{
    [DataMember(Name = "Replicated", EmitDefaultValue = false)]
    public ReplicatedService Replicated { get; set; }

    [DataMember(Name = "Global", EmitDefaultValue = false)]
    public GlobalService Global { get; set; }

    [DataMember(Name = "ReplicatedJob", EmitDefaultValue = false)]
    public ReplicatedJob ReplicatedJob { get; set; }

    [DataMember(Name = "GlobalJob", EmitDefaultValue = false)]
    public GlobalJob GlobalJob { get; set; }
}
