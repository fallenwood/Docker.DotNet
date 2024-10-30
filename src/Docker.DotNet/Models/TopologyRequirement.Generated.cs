namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class TopologyRequirement // (volume.TopologyRequirement)
{
    [DataMember(Name = "Requisite", EmitDefaultValue = false)]
    public IList<VolumeTopology> Requisite { get; set; }

    [DataMember(Name = "Preferred", EmitDefaultValue = false)]
    public IList<VolumeTopology> Preferred { get; set; }
}
