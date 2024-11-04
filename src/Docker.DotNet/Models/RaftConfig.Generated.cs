namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class RaftConfig // (swarm.RaftConfig)
{
    [DataMember(Name = "SnapshotInterval", EmitDefaultValue = false)]
    [JsonPropertyName("SnapshotInterval")]
    public ulong SnapshotInterval { get; set; }

    [DataMember(Name = "KeepOldSnapshots", EmitDefaultValue = false)]
    [JsonPropertyName("KeepOldSnapshots")]
    public ulong? KeepOldSnapshots { get; set; }

    [DataMember(Name = "LogEntriesForSlowFollowers", EmitDefaultValue = false)]
    [JsonPropertyName("LogEntriesForSlowFollowers")]
    public ulong LogEntriesForSlowFollowers { get; set; }

    [DataMember(Name = "ElectionTick", EmitDefaultValue = false)]
    [JsonPropertyName("ElectionTick")]
    public long ElectionTick { get; set; }

    [DataMember(Name = "HeartbeatTick", EmitDefaultValue = false)]
    [JsonPropertyName("HeartbeatTick")]
    public long HeartbeatTick { get; set; }
}
