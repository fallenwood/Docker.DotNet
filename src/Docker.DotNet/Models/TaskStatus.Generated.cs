namespace Docker.DotNet.Models;

using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class TaskStatus // (swarm.TaskStatus)
{
    [DataMember(Name = "Timestamp", EmitDefaultValue = false)]
    [JsonPropertyName("Timestamp")]
    public DateTime Timestamp { get; set; }

    [DataMember(Name = "State", EmitDefaultValue = false)]
    [JsonPropertyName("State")]
    public TaskState State { get; set; }

    [DataMember(Name = "Message", EmitDefaultValue = false)]
    [JsonPropertyName("Message")]
    public string Message { get; set; }

    [DataMember(Name = "Err", EmitDefaultValue = false)]
    [JsonPropertyName("Err")]
    public string Err { get; set; }

    [DataMember(Name = "ContainerStatus", EmitDefaultValue = false)]
    [JsonPropertyName("ContainerStatus")]
    public ContainerStatus ContainerStatus { get; set; }

    [DataMember(Name = "PortStatus", EmitDefaultValue = false)]
    [JsonPropertyName("PortStatus")]
    public PortStatus PortStatus { get; set; }
}
