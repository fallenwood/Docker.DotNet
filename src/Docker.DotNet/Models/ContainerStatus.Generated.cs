namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerStatus // (swarm.ContainerStatus)
{
    [DataMember(Name = "ContainerID", EmitDefaultValue = false)]
    public string ContainerID { get; set; }

    [DataMember(Name = "PID", EmitDefaultValue = false)]
    public long PID { get; set; }

    [DataMember(Name = "ExitCode", EmitDefaultValue = false)]
    public long ExitCode { get; set; }
}
