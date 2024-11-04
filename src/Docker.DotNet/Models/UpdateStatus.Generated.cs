namespace Docker.DotNet.Models;

using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class UpdateStatus // (swarm.UpdateStatus)
{
    [DataMember(Name = "State", EmitDefaultValue = false)]
    [JsonPropertyName("State")]
    public string State { get; set; }

    [DataMember(Name = "StartedAt", EmitDefaultValue = false)]
    [JsonPropertyName("StartedAt")]
    public DateTime? StartedAt { get; set; }

    [DataMember(Name = "CompletedAt", EmitDefaultValue = false)]
    [JsonPropertyName("CompletedAt")]
    public DateTime? CompletedAt { get; set; }

    [DataMember(Name = "Message", EmitDefaultValue = false)]
    [JsonPropertyName("Message")]
    public string Message { get; set; }
}
