namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class IPAMConfig // (network.IPAMConfig)
{
    [DataMember(Name = "Subnet", EmitDefaultValue = false)]
    public string Subnet { get; set; }

    [DataMember(Name = "IPRange", EmitDefaultValue = false)]
    public string IPRange { get; set; }

    [DataMember(Name = "Gateway", EmitDefaultValue = false)]
    public string Gateway { get; set; }

    [DataMember(Name = "AuxiliaryAddresses", EmitDefaultValue = false)]
    public IDictionary<string, string> AuxAddress { get; set; }
}
