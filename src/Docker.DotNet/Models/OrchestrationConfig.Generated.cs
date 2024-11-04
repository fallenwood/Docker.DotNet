namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class OrchestrationConfig // (swarm.OrchestrationConfig)
{
    [DataMember(Name = "TaskHistoryRetentionLimit", EmitDefaultValue = false)]
    [JsonPropertyName("TaskHistoryRetentionLimit")]
    public long? TaskHistoryRetentionLimit { get; set; }
}
