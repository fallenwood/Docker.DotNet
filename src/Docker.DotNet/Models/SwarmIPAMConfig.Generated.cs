namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class SwarmIPAMConfig // (swarm.IPAMConfig)
{
    [DataMember(Name = "Subnet", EmitDefaultValue = false)]
    public string Subnet { get; set; }

    [DataMember(Name = "Range", EmitDefaultValue = false)]
    public string Range { get; set; }

    [DataMember(Name = "Gateway", EmitDefaultValue = false)]
    public string Gateway { get; set; }
}
