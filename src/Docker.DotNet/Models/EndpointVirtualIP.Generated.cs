namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class EndpointVirtualIP // (swarm.EndpointVirtualIP)
{
    [DataMember(Name = "NetworkID", EmitDefaultValue = false)]
    public string NetworkID { get; set; }

    [DataMember(Name = "Addr", EmitDefaultValue = false)]
    public string Addr { get; set; }
}
