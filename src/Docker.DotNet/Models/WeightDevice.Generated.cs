namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class WeightDevice // (blkiodev.WeightDevice)
{
    [DataMember(Name = "Path", EmitDefaultValue = false)]
    public string Path { get; set; }

    [DataMember(Name = "Weight", EmitDefaultValue = false)]
    public ushort Weight { get; set; }
}
