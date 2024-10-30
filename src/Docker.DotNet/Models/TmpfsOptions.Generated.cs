namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class TmpfsOptions // (mount.TmpfsOptions)
{
    [DataMember(Name = "SizeBytes", EmitDefaultValue = false)]
    public long SizeBytes { get; set; }

    [DataMember(Name = "Mode", EmitDefaultValue = false)]
    public uint Mode { get; set; }

    [DataMember(Name = "Options", EmitDefaultValue = false)]
    public IList<IList<string>> Options { get; set; }
}
