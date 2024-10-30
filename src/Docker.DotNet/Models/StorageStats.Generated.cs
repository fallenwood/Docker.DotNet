namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class StorageStats // (container.StorageStats)
{
    [DataMember(Name = "read_count_normalized", EmitDefaultValue = false)]
    public ulong ReadCountNormalized { get; set; }

    [DataMember(Name = "read_size_bytes", EmitDefaultValue = false)]
    public ulong ReadSizeBytes { get; set; }

    [DataMember(Name = "write_count_normalized", EmitDefaultValue = false)]
    public ulong WriteCountNormalized { get; set; }

    [DataMember(Name = "write_size_bytes", EmitDefaultValue = false)]
    public ulong WriteSizeBytes { get; set; }
}
