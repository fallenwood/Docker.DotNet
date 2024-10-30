namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ThrottleDevice // (blkiodev.ThrottleDevice)
{
    [DataMember(Name = "Path", EmitDefaultValue = false)]
    public string Path { get; set; }

    [DataMember(Name = "Rate", EmitDefaultValue = false)]
    public ulong Rate { get; set; }
}
