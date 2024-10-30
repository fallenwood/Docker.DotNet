namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ResourceRequirements // (swarm.ResourceRequirements)
{
    [DataMember(Name = "Limits", EmitDefaultValue = false)]
    public SwarmLimit Limits { get; set; }

    [DataMember(Name = "Reservations", EmitDefaultValue = false)]
    public SwarmResources Reservations { get; set; }
}
