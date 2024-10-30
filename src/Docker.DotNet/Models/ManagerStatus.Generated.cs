namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ManagerStatus // (swarm.ManagerStatus)
{
    [DataMember(Name = "Leader", EmitDefaultValue = false)]
    public bool Leader { get; set; }

    [DataMember(Name = "Reachability", EmitDefaultValue = false)]
    public string Reachability { get; set; }

    [DataMember(Name = "Addr", EmitDefaultValue = false)]
    public string Addr { get; set; }
}
