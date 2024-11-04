namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Endpoint // (swarm.Endpoint)
{
    [DataMember(Name = "Spec", EmitDefaultValue = false)]
    [JsonPropertyName("Spec")]
    public EndpointSpec Spec { get; set; }

    [DataMember(Name = "Ports", EmitDefaultValue = false)]
    [JsonPropertyName("Ports")]
    public IList<PortConfig> Ports { get; set; }

    [DataMember(Name = "VirtualIPs", EmitDefaultValue = false)]
    [JsonPropertyName("VirtualIPs")]
    public IList<EndpointVirtualIP> VirtualIPs { get; set; }
}
