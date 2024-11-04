namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SwarmIPAMConfig // (swarm.IPAMConfig)
{
    [DataMember(Name = "Subnet", EmitDefaultValue = false)]
    [JsonPropertyName("Subnet")]
    public string Subnet { get; set; }

    [DataMember(Name = "Range", EmitDefaultValue = false)]
    [JsonPropertyName("Range")]
    public string Range { get; set; }

    [DataMember(Name = "Gateway", EmitDefaultValue = false)]
    [JsonPropertyName("Gateway")]
    public string Gateway { get; set; }
}
