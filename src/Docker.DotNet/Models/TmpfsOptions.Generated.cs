namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class TmpfsOptions // (mount.TmpfsOptions)
{
    [DataMember(Name = "SizeBytes", EmitDefaultValue = false)]
    [JsonPropertyName("SizeBytes")]
    public long SizeBytes { get; set; }

    [DataMember(Name = "Mode", EmitDefaultValue = false)]
    [JsonPropertyName("Mode")]
    public uint Mode { get; set; }

    [DataMember(Name = "Options", EmitDefaultValue = false)]
    [JsonPropertyName("Options")]
    public IList<IList<string>> Options { get; set; }
}
