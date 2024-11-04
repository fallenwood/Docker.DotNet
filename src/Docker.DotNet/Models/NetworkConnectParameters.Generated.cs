namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworkConnectParameters // (network.ConnectOptions)
{
    [DataMember(Name = "Container", EmitDefaultValue = false)]
    [JsonPropertyName("Container")]
    public string Container { get; set; }

    [DataMember(Name = "EndpointConfig", EmitDefaultValue = false)]
    [JsonPropertyName("EndpointConfig")]
    public EndpointSettings EndpointConfig { get; set; }
}
