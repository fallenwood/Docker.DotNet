namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class EndpointSettings // (network.EndpointSettings)
{
    [DataMember(Name = "IPAMConfig", EmitDefaultValue = false)]
    [JsonPropertyName("IPAMConfig")]
    public EndpointIPAMConfig IPAMConfig { get; set; }

    [DataMember(Name = "Links", EmitDefaultValue = false)]
    [JsonPropertyName("Links")]
    public IList<string> Links { get; set; }

    [DataMember(Name = "Aliases", EmitDefaultValue = false)]
    [JsonPropertyName("Aliases")]
    public IList<string> Aliases { get; set; }

    [DataMember(Name = "MacAddress", EmitDefaultValue = false)]
    [JsonPropertyName("MacAddress")]
    public string MacAddress { get; set; }

    [DataMember(Name = "DriverOpts", EmitDefaultValue = false)]
    [JsonPropertyName("DriverOpts")]
    public IDictionary<string, string> DriverOpts { get; set; }

    [DataMember(Name = "NetworkID", EmitDefaultValue = false)]
    [JsonPropertyName("NetworkID")]
    public string NetworkID { get; set; }

    [DataMember(Name = "EndpointID", EmitDefaultValue = false)]
    [JsonPropertyName("EndpointID")]
    public string EndpointID { get; set; }

    [DataMember(Name = "Gateway", EmitDefaultValue = false)]
    [JsonPropertyName("Gateway")]
    public string Gateway { get; set; }

    [DataMember(Name = "IPAddress", EmitDefaultValue = false)]
    [JsonPropertyName("IPAddress")]
    public string IPAddress { get; set; }

    [DataMember(Name = "IPPrefixLen", EmitDefaultValue = false)]
    [JsonPropertyName("IPPrefixLen")]
    public long IPPrefixLen { get; set; }

    [DataMember(Name = "IPv6Gateway", EmitDefaultValue = false)]
    [JsonPropertyName("IPv6Gateway")]
    public string IPv6Gateway { get; set; }

    [DataMember(Name = "GlobalIPv6Address", EmitDefaultValue = false)]
    [JsonPropertyName("GlobalIPv6Address")]
    public string GlobalIPv6Address { get; set; }

    [DataMember(Name = "GlobalIPv6PrefixLen", EmitDefaultValue = false)]
    [JsonPropertyName("GlobalIPv6PrefixLen")]
    public long GlobalIPv6PrefixLen { get; set; }

    [DataMember(Name = "DNSNames", EmitDefaultValue = false)]
    [JsonPropertyName("DNSNames")]
    public IList<string> DNSNames { get; set; }
}
