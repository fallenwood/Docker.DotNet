namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class MemoryStats // (container.MemoryStats)
{
    [DataMember(Name = "usage", EmitDefaultValue = false)]
    public ulong Usage { get; set; }

    [DataMember(Name = "max_usage", EmitDefaultValue = false)]
    public ulong MaxUsage { get; set; }

    [DataMember(Name = "stats", EmitDefaultValue = false)]
    public IDictionary<string, ulong> Stats { get; set; }

    [DataMember(Name = "failcnt", EmitDefaultValue = false)]
    public ulong Failcnt { get; set; }

    [DataMember(Name = "limit", EmitDefaultValue = false)]
    public ulong Limit { get; set; }

    [DataMember(Name = "commitbytes", EmitDefaultValue = false)]
    public ulong Commit { get; set; }

    [DataMember(Name = "commitpeakbytes", EmitDefaultValue = false)]
    public ulong CommitPeak { get; set; }

    [DataMember(Name = "privateworkingset", EmitDefaultValue = false)]
    public ulong PrivateWorkingSet { get; set; }
}
