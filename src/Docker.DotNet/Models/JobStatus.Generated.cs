namespace Docker.DotNet.Models;

using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class JobStatus // (swarm.JobStatus)
{
    [DataMember(Name = "JobIteration", EmitDefaultValue = false)]
    [JsonPropertyName("JobIteration")]
    public Version JobIteration { get; set; }

    [DataMember(Name = "LastExecution", EmitDefaultValue = false)]
    [JsonPropertyName("LastExecution")]
    public DateTime LastExecution { get; set; }
}
