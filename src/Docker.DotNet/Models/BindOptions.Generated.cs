namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class BindOptions // (mount.BindOptions)
{
    [DataMember(Name = "Propagation", EmitDefaultValue = false)]
    [JsonPropertyName("Propagation")]
    public string Propagation { get; set; }

    [DataMember(Name = "NonRecursive", EmitDefaultValue = false)]
    [JsonPropertyName("NonRecursive")]
    public bool NonRecursive { get; set; }

    [DataMember(Name = "CreateMountpoint", EmitDefaultValue = false)]
    [JsonPropertyName("CreateMountpoint")]
    public bool CreateMountpoint { get; set; }

    [DataMember(Name = "ReadOnlyNonRecursive", EmitDefaultValue = false)]
    [JsonPropertyName("ReadOnlyNonRecursive")]
    public bool ReadOnlyNonRecursive { get; set; }

    [DataMember(Name = "ReadOnlyForceRecursive", EmitDefaultValue = false)]
    [JsonPropertyName("ReadOnlyForceRecursive")]
    public bool ReadOnlyForceRecursive { get; set; }
}
