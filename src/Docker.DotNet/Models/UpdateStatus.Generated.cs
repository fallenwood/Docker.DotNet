namespace Docker.DotNet.Models;

using System;
using System.Runtime.Serialization;

[DataContract]
public sealed class UpdateStatus // (swarm.UpdateStatus)
{
    [DataMember(Name = "State", EmitDefaultValue = false)]
    public string State { get; set; }

    [DataMember(Name = "StartedAt", EmitDefaultValue = false)]
    public DateTime? StartedAt { get; set; }

    [DataMember(Name = "CompletedAt", EmitDefaultValue = false)]
    public DateTime? CompletedAt { get; set; }

    [DataMember(Name = "Message", EmitDefaultValue = false)]
    public string Message { get; set; }
}
