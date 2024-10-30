namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class TypeMount // (volume.TypeMount)
{
    [DataMember(Name = "FsType", EmitDefaultValue = false)]
    public string FsType { get; set; }

    [DataMember(Name = "MountFlags", EmitDefaultValue = false)]
    public IList<string> MountFlags { get; set; }
}
