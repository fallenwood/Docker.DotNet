namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class NodeStatus // (swarm.NodeStatus)
{
    [DataMember(Name = "State", EmitDefaultValue = false)]
    public string State { get; set; }

    [DataMember(Name = "Message", EmitDefaultValue = false)]
    public string Message { get; set; }

    [DataMember(Name = "Addr", EmitDefaultValue = false)]
    public string Addr { get; set; }
}
