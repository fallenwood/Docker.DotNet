namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ServiceStatus // (swarm.ServiceStatus)
{
    [DataMember(Name = "RunningTasks", EmitDefaultValue = false)]
    [JsonPropertyName("RunningTasks")]
    public ulong RunningTasks { get; set; }

    [DataMember(Name = "DesiredTasks", EmitDefaultValue = false)]
    [JsonPropertyName("DesiredTasks")]
    public ulong DesiredTasks { get; set; }

    [DataMember(Name = "CompletedTasks", EmitDefaultValue = false)]
    [JsonPropertyName("CompletedTasks")]
    public ulong CompletedTasks { get; set; }
}
