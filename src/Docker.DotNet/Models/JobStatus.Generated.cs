namespace Docker.DotNet.Models;

using System;
using System.Runtime.Serialization;

[DataContract]
public sealed class JobStatus // (swarm.JobStatus)
{
    [DataMember(Name = "JobIteration", EmitDefaultValue = false)]
    public Version JobIteration { get; set; }

    [DataMember(Name = "LastExecution", EmitDefaultValue = false)]
    public DateTime LastExecution { get; set; }
}
