namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class TopologyRequirement // (volume.TopologyRequirement)
{
    [DataMember(Name = "Requisite", EmitDefaultValue = false)]
    [JsonPropertyName("Requisite")]
    public IList<VolumeTopology> Requisite { get; set; }

    [DataMember(Name = "Preferred", EmitDefaultValue = false)]
    [JsonPropertyName("Preferred")]
    public IList<VolumeTopology> Preferred { get; set; }
}
