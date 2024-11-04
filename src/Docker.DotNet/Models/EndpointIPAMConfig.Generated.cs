namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class EndpointIPAMConfig // (network.EndpointIPAMConfig)
{
    [DataMember(Name = "IPv4Address", EmitDefaultValue = false)]
    [JsonPropertyName("IPv4Address")]
    public string IPv4Address { get; set; }

    [DataMember(Name = "IPv6Address", EmitDefaultValue = false)]
    [JsonPropertyName("IPv6Address")]
    public string IPv6Address { get; set; }

    [DataMember(Name = "LinkLocalIPs", EmitDefaultValue = false)]
    [JsonPropertyName("LinkLocalIPs")]
    public IList<string> LinkLocalIPs { get; set; }
}
