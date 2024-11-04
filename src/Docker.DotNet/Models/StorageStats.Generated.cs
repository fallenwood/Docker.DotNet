namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class StorageStats // (container.StorageStats)
{
    [DataMember(Name = "read_count_normalized", EmitDefaultValue = false)]
    [JsonPropertyName("read_count_normalized")]
    public ulong ReadCountNormalized { get; set; }

    [DataMember(Name = "read_size_bytes", EmitDefaultValue = false)]
    [JsonPropertyName("read_size_bytes")]
    public ulong ReadSizeBytes { get; set; }

    [DataMember(Name = "write_count_normalized", EmitDefaultValue = false)]
    [JsonPropertyName("write_count_normalized")]
    public ulong WriteCountNormalized { get; set; }

    [DataMember(Name = "write_size_bytes", EmitDefaultValue = false)]
    [JsonPropertyName("write_size_bytes")]
    public ulong WriteSizeBytes { get; set; }
}
