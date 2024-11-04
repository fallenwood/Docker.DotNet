namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Topology // (swarm.Topology)
{
    [DataMember(Name = "Segments", EmitDefaultValue = false)]
    [JsonPropertyName("Segments")]
    public IDictionary<string, string> Segments { get; set; }
}
