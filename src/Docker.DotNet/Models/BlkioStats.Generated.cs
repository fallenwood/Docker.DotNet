namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class BlkioStats // (container.BlkioStats)
{
    [DataMember(Name = "io_service_bytes_recursive", EmitDefaultValue = false)]
    [JsonPropertyName("io_service_bytes_recursive")]
    public IList<BlkioStatEntry> IoServiceBytesRecursive { get; set; }

    [DataMember(Name = "io_serviced_recursive", EmitDefaultValue = false)]
    [JsonPropertyName("io_serviced_recursive")]
    public IList<BlkioStatEntry> IoServicedRecursive { get; set; }

    [DataMember(Name = "io_queue_recursive", EmitDefaultValue = false)]
    [JsonPropertyName("io_queue_recursive")]
    public IList<BlkioStatEntry> IoQueuedRecursive { get; set; }

    [DataMember(Name = "io_service_time_recursive", EmitDefaultValue = false)]
    [JsonPropertyName("io_service_time_recursive")]
    public IList<BlkioStatEntry> IoServiceTimeRecursive { get; set; }

    [DataMember(Name = "io_wait_time_recursive", EmitDefaultValue = false)]
    [JsonPropertyName("io_wait_time_recursive")]
    public IList<BlkioStatEntry> IoWaitTimeRecursive { get; set; }

    [DataMember(Name = "io_merged_recursive", EmitDefaultValue = false)]
    [JsonPropertyName("io_merged_recursive")]
    public IList<BlkioStatEntry> IoMergedRecursive { get; set; }

    [DataMember(Name = "io_time_recursive", EmitDefaultValue = false)]
    [JsonPropertyName("io_time_recursive")]
    public IList<BlkioStatEntry> IoTimeRecursive { get; set; }

    [DataMember(Name = "sectors_recursive", EmitDefaultValue = false)]
    [JsonPropertyName("sectors_recursive")]
    public IList<BlkioStatEntry> SectorsRecursive { get; set; }
}
