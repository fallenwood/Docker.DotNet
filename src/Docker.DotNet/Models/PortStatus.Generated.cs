namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PortStatus // (swarm.PortStatus)
{
    [DataMember(Name = "Ports", EmitDefaultValue = false)]
    [JsonPropertyName("Ports")]
    public IList<PortConfig> Ports { get; set; }
}
