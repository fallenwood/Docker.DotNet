namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class CapacityRange // (volume.CapacityRange)
{
    [DataMember(Name = "RequiredBytes", EmitDefaultValue = false)]
    public long RequiredBytes { get; set; }

    [DataMember(Name = "LimitBytes", EmitDefaultValue = false)]
    public long LimitBytes { get; set; }
}
