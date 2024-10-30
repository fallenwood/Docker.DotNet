namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class PortStatus // (swarm.PortStatus)
{
    [DataMember(Name = "Ports", EmitDefaultValue = false)]
    public IList<PortConfig> Ports { get; set; }
}
