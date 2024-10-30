namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ServiceStatus // (swarm.ServiceStatus)
{
    [DataMember(Name = "RunningTasks", EmitDefaultValue = false)]
    public ulong RunningTasks { get; set; }

    [DataMember(Name = "DesiredTasks", EmitDefaultValue = false)]
    public ulong DesiredTasks { get; set; }

    [DataMember(Name = "CompletedTasks", EmitDefaultValue = false)]
    public ulong CompletedTasks { get; set; }
}
