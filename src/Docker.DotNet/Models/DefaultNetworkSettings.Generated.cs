namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class DefaultNetworkSettings // (types.DefaultNetworkSettings)
{
    [DataMember(Name = "EndpointID", EmitDefaultValue = false)]
    [JsonPropertyName("EndpointID")]
    public string EndpointID { get; set; }

    [DataMember(Name = "Gateway", EmitDefaultValue = false)]
    [JsonPropertyName("Gateway")]
    public string Gateway { get; set; }

    [DataMember(Name = "GlobalIPv6Address", EmitDefaultValue = false)]
    [JsonPropertyName("GlobalIPv6Address")]
    public string GlobalIPv6Address { get; set; }

    [DataMember(Name = "GlobalIPv6PrefixLen", EmitDefaultValue = false)]
    [JsonPropertyName("GlobalIPv6PrefixLen")]
    public long GlobalIPv6PrefixLen { get; set; }

    [DataMember(Name = "IPAddress", EmitDefaultValue = false)]
    [JsonPropertyName("IPAddress")]
    public string IPAddress { get; set; }

    [DataMember(Name = "IPPrefixLen", EmitDefaultValue = false)]
    [JsonPropertyName("IPPrefixLen")]
    public long IPPrefixLen { get; set; }

    [DataMember(Name = "IPv6Gateway", EmitDefaultValue = false)]
    [JsonPropertyName("IPv6Gateway")]
    public string IPv6Gateway { get; set; }

    [DataMember(Name = "MacAddress", EmitDefaultValue = false)]
    [JsonPropertyName("MacAddress")]
    public string MacAddress { get; set; }
}
