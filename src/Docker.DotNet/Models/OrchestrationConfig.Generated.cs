namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class OrchestrationConfig // (swarm.OrchestrationConfig)
{
    [DataMember(Name = "TaskHistoryRetentionLimit", EmitDefaultValue = false)]
    public long? TaskHistoryRetentionLimit { get; set; }
}
