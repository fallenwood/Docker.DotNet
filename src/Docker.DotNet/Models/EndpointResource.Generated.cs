namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class EndpointResource // (network.EndpointResource)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "EndpointID", EmitDefaultValue = false)]
    [JsonPropertyName("EndpointID")]
    public string EndpointID { get; set; }

    [DataMember(Name = "MacAddress", EmitDefaultValue = false)]
    [JsonPropertyName("MacAddress")]
    public string MacAddress { get; set; }

    [DataMember(Name = "IPv4Address", EmitDefaultValue = false)]
    [JsonPropertyName("IPv4Address")]
    public string IPv4Address { get; set; }

    [DataMember(Name = "IPv6Address", EmitDefaultValue = false)]
    [JsonPropertyName("IPv6Address")]
    public string IPv6Address { get; set; }
}
