namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class VolumesListResponse // (main.VolumesListResponse)
{
    [DataMember(Name = "Volumes", EmitDefaultValue = false)]
    public IList<VolumeResponse> Volumes { get; set; }

    [DataMember(Name = "Warnings", EmitDefaultValue = false)]
    public IList<string> Warnings { get; set; }
}
