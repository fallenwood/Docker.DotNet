namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class VolumeSecret // (volume.Secret)
{
    [DataMember(Name = "Key", EmitDefaultValue = false)]
    public string Key { get; set; }

    [DataMember(Name = "Secret", EmitDefaultValue = false)]
    public string Secret { get; set; }
}
