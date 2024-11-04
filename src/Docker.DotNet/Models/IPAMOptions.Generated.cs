namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class IPAMOptions // (swarm.IPAMOptions)
{
    [DataMember(Name = "Driver", EmitDefaultValue = false)]
    [JsonPropertyName("Driver")]
    public SwarmDriver Driver { get; set; }

    [DataMember(Name = "Configs", EmitDefaultValue = false)]
    [JsonPropertyName("Configs")]
    public IList<SwarmIPAMConfig> Configs { get; set; }
}
