namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class TaskDefaults // (swarm.TaskDefaults)
{
    [DataMember(Name = "LogDriver", EmitDefaultValue = false)]
    [JsonPropertyName("LogDriver")]
    public SwarmDriver LogDriver { get; set; }
}
