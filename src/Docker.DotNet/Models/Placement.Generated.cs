namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Placement // (swarm.Placement)
{
    [DataMember(Name = "Constraints", EmitDefaultValue = false)]
    [JsonPropertyName("Constraints")]
    public IList<string> Constraints { get; set; }

    [DataMember(Name = "Preferences", EmitDefaultValue = false)]
    [JsonPropertyName("Preferences")]
    public IList<PlacementPreference> Preferences { get; set; }

    [DataMember(Name = "MaxReplicas", EmitDefaultValue = false)]
    [JsonPropertyName("MaxReplicas")]
    public ulong MaxReplicas { get; set; }

    [DataMember(Name = "Platforms", EmitDefaultValue = false)]
    [JsonPropertyName("Platforms")]
    public IList<Platform> Platforms { get; set; }
}
