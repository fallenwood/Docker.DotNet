namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class PortBinding // (nat.PortBinding)
{
    [DataMember(Name = "HostIp", EmitDefaultValue = false)]
    public string HostIP { get; set; }

    [DataMember(Name = "HostPort", EmitDefaultValue = false)]
    public string HostPort { get; set; }
}
