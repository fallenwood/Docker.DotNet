namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class IPAMOptions // (swarm.IPAMOptions)
{
    [DataMember(Name = "Driver", EmitDefaultValue = false)]
    public SwarmDriver Driver { get; set; }

    [DataMember(Name = "Configs", EmitDefaultValue = false)]
    public IList<SwarmIPAMConfig> Configs { get; set; }
}
