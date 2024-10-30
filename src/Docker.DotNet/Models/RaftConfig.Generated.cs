namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class RaftConfig // (swarm.RaftConfig)
{
    [DataMember(Name = "SnapshotInterval", EmitDefaultValue = false)]
    public ulong SnapshotInterval { get; set; }

    [DataMember(Name = "KeepOldSnapshots", EmitDefaultValue = false)]
    public ulong? KeepOldSnapshots { get; set; }

    [DataMember(Name = "LogEntriesForSlowFollowers", EmitDefaultValue = false)]
    public ulong LogEntriesForSlowFollowers { get; set; }

    [DataMember(Name = "ElectionTick", EmitDefaultValue = false)]
    public long ElectionTick { get; set; }

    [DataMember(Name = "HeartbeatTick", EmitDefaultValue = false)]
    public long HeartbeatTick { get; set; }
}
