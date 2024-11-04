namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class VolumesPruneResponse // (volume.PruneReport)
{
    [DataMember(Name = "VolumesDeleted", EmitDefaultValue = false)]
    [JsonPropertyName("VolumesDeleted")]
    public IList<string> VolumesDeleted { get; set; }

    [DataMember(Name = "SpaceReclaimed", EmitDefaultValue = false)]
    [JsonPropertyName("SpaceReclaimed")]
    public ulong SpaceReclaimed { get; set; }
}
