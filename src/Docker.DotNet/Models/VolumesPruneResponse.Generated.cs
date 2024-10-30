namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class VolumesPruneResponse // (volume.PruneReport)
{
    [DataMember(Name = "VolumesDeleted", EmitDefaultValue = false)]
    public IList<string> VolumesDeleted { get; set; }

    [DataMember(Name = "SpaceReclaimed", EmitDefaultValue = false)]
    public ulong SpaceReclaimed { get; set; }
}
