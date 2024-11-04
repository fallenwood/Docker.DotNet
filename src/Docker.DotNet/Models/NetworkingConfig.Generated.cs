namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworkingConfig // (network.NetworkingConfig)
{
    [DataMember(Name = "EndpointsConfig", EmitDefaultValue = false)]
    [JsonPropertyName("EndpointsConfig")]
    public IDictionary<string, EndpointSettings> EndpointsConfig { get; set; }
}
