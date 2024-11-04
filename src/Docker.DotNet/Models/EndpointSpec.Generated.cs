namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class EndpointSpec // (swarm.EndpointSpec)
{
    [DataMember(Name = "Mode", EmitDefaultValue = false)]
    [JsonPropertyName("Mode")]
    public string Mode { get; set; }

    [DataMember(Name = "Ports", EmitDefaultValue = false)]
    [JsonPropertyName("Ports")]
    public IList<PortConfig> Ports { get; set; }
}
