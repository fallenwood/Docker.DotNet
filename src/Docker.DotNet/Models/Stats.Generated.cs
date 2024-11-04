namespace Docker.DotNet.Models;

using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Stats // (container.Stats)
{
    [DataMember(Name = "read", EmitDefaultValue = false)]
    [JsonPropertyName("read")]
    public DateTime Read { get; set; }

    [DataMember(Name = "preread", EmitDefaultValue = false)]
    [JsonPropertyName("preread")]
    public DateTime PreRead { get; set; }

    [DataMember(Name = "pids_stats", EmitDefaultValue = false)]
    [JsonPropertyName("pids_stats")]
    public PidsStats PidsStats { get; set; }

    [DataMember(Name = "blkio_stats", EmitDefaultValue = false)]
    [JsonPropertyName("blkio_stats")]
    public BlkioStats BlkioStats { get; set; }

    [DataMember(Name = "num_procs", EmitDefaultValue = false)]
    [JsonPropertyName("num_procs")]
    public uint NumProcs { get; set; }

    [DataMember(Name = "storage_stats", EmitDefaultValue = false)]
    [JsonPropertyName("storage_stats")]
    public StorageStats StorageStats { get; set; }

    [DataMember(Name = "cpu_stats", EmitDefaultValue = false)]
    [JsonPropertyName("cpu_stats")]
    public CPUStats CPUStats { get; set; }

    [DataMember(Name = "precpu_stats", EmitDefaultValue = false)]
    [JsonPropertyName("precpu_stats")]
    public CPUStats PreCPUStats { get; set; }

    [DataMember(Name = "memory_stats", EmitDefaultValue = false)]
    [JsonPropertyName("memory_stats")]
    public MemoryStats MemoryStats { get; set; }
}
