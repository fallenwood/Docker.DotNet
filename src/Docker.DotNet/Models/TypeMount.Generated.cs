namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class TypeMount // (volume.TypeMount)
{
    [DataMember(Name = "FsType", EmitDefaultValue = false)]
    [JsonPropertyName("FsType")]
    public string FsType { get; set; }

    [DataMember(Name = "MountFlags", EmitDefaultValue = false)]
    [JsonPropertyName("MountFlags")]
    public IList<string> MountFlags { get; set; }
}
