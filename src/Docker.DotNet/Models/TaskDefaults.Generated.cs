namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class TaskDefaults // (swarm.TaskDefaults)
{
    [DataMember(Name = "LogDriver", EmitDefaultValue = false)]
    public SwarmDriver LogDriver { get; set; }
}
