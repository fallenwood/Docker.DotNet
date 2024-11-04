namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class MemoryStats // (container.MemoryStats)
{
    [DataMember(Name = "usage", EmitDefaultValue = false)]
    [JsonPropertyName("usage")]
    public ulong Usage { get; set; }

    [DataMember(Name = "max_usage", EmitDefaultValue = false)]
    [JsonPropertyName("max_usage")]
    public ulong MaxUsage { get; set; }

    [DataMember(Name = "stats", EmitDefaultValue = false)]
    [JsonPropertyName("stats")]
    public IDictionary<string, ulong> Stats { get; set; }

    [DataMember(Name = "failcnt", EmitDefaultValue = false)]
    [JsonPropertyName("failcnt")]
    public ulong Failcnt { get; set; }

    [DataMember(Name = "limit", EmitDefaultValue = false)]
    [JsonPropertyName("limit")]
    public ulong Limit { get; set; }

    [DataMember(Name = "commitbytes", EmitDefaultValue = false)]
    [JsonPropertyName("commitbytes")]
    public ulong Commit { get; set; }

    [DataMember(Name = "commitpeakbytes", EmitDefaultValue = false)]
    [JsonPropertyName("commitpeakbytes")]
    public ulong CommitPeak { get; set; }

    [DataMember(Name = "privateworkingset", EmitDefaultValue = false)]
    [JsonPropertyName("privateworkingset")]
    public ulong PrivateWorkingSet { get; set; }
}
