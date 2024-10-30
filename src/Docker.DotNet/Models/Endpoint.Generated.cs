namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class Endpoint // (swarm.Endpoint)
{
    [DataMember(Name = "Spec", EmitDefaultValue = false)]
    public EndpointSpec Spec { get; set; }

    [DataMember(Name = "Ports", EmitDefaultValue = false)]
    public IList<PortConfig> Ports { get; set; }

    [DataMember(Name = "VirtualIPs", EmitDefaultValue = false)]
    public IList<EndpointVirtualIP> VirtualIPs { get; set; }
}
