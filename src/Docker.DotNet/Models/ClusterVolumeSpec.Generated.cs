namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ClusterVolumeSpec // (volume.ClusterVolumeSpec)
{
    [DataMember(Name = "Group", EmitDefaultValue = false)]
    [JsonPropertyName("Group")]
    public string Group { get; set; }

    [DataMember(Name = "AccessMode", EmitDefaultValue = false)]
    [JsonPropertyName("AccessMode")]
    public AccessMode AccessMode { get; set; }

    [DataMember(Name = "AccessibilityRequirements", EmitDefaultValue = false)]
    [JsonPropertyName("AccessibilityRequirements")]
    public TopologyRequirement AccessibilityRequirements { get; set; }

    [DataMember(Name = "CapacityRange", EmitDefaultValue = false)]
    [JsonPropertyName("CapacityRange")]
    public CapacityRange CapacityRange { get; set; }

    [DataMember(Name = "Secrets", EmitDefaultValue = false)]
    [JsonPropertyName("Secrets")]
    public IList<VolumeSecret> Secrets { get; set; }

    [DataMember(Name = "Availability", EmitDefaultValue = false)]
    [JsonPropertyName("Availability")]
    public string Availability { get; set; }
}
