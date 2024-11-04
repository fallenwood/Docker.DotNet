namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class CPUUsage // (container.CPUUsage)
{
    [DataMember(Name = "total_usage", EmitDefaultValue = false)]
    [JsonPropertyName("total_usage")]
    public ulong TotalUsage { get; set; }

    [DataMember(Name = "percpu_usage", EmitDefaultValue = false)]
    [JsonPropertyName("percpu_usage")]
    public IList<ulong> PercpuUsage { get; set; }

    [DataMember(Name = "usage_in_kernelmode", EmitDefaultValue = false)]
    [JsonPropertyName("usage_in_kernelmode")]
    public ulong UsageInKernelmode { get; set; }

    [DataMember(Name = "usage_in_usermode", EmitDefaultValue = false)]
    [JsonPropertyName("usage_in_usermode")]
    public ulong UsageInUsermode { get; set; }
}
