namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class VolumeInfo // (volume.Info)
{
    [DataMember(Name = "CapacityBytes", EmitDefaultValue = false)]
    public long CapacityBytes { get; set; }

    [DataMember(Name = "VolumeContext", EmitDefaultValue = false)]
    public IDictionary<string, string> VolumeContext { get; set; }

    [DataMember(Name = "VolumeID", EmitDefaultValue = false)]
    public string VolumeID { get; set; }

    [DataMember(Name = "AccessibleTopology", EmitDefaultValue = false)]
    public IList<VolumeTopology> AccessibleTopology { get; set; }
}
