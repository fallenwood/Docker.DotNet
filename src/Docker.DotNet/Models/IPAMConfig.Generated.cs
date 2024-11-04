namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class IPAMConfig // (network.IPAMConfig)
{
    [DataMember(Name = "Subnet", EmitDefaultValue = false)]
    [JsonPropertyName("Subnet")]
    public string Subnet { get; set; }

    [DataMember(Name = "IPRange", EmitDefaultValue = false)]
    [JsonPropertyName("IPRange")]
    public string IPRange { get; set; }

    [DataMember(Name = "Gateway", EmitDefaultValue = false)]
    [JsonPropertyName("Gateway")]
    public string Gateway { get; set; }

    [DataMember(Name = "AuxiliaryAddresses", EmitDefaultValue = false)]
    [JsonPropertyName("AuxiliaryAddresses")]
    public IDictionary<string, string> AuxAddress { get; set; }
}
