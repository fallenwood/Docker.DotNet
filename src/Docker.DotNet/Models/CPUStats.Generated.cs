namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class CPUStats // (container.CPUStats)
{
    [DataMember(Name = "cpu_usage", EmitDefaultValue = false)]
    [JsonPropertyName("cpu_usage")]
    public CPUUsage CPUUsage { get; set; }

    [DataMember(Name = "system_cpu_usage", EmitDefaultValue = false)]
    [JsonPropertyName("system_cpu_usage")]
    public ulong SystemUsage { get; set; }

    [DataMember(Name = "online_cpus", EmitDefaultValue = false)]
    [JsonPropertyName("online_cpus")]
    public uint OnlineCPUs { get; set; }

    [DataMember(Name = "throttling_data", EmitDefaultValue = false)]
    [JsonPropertyName("throttling_data")]
    public ThrottlingData ThrottlingData { get; set; }
}
