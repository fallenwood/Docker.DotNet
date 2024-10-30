namespace Docker.DotNet.Models;

using System;
using System.Runtime.Serialization;

[DataContract]
public sealed class Meta // (swarm.Meta)
{
    [DataMember(Name = "Version", EmitDefaultValue = false)]
    public Version Version { get; set; }

    [DataMember(Name = "CreatedAt", EmitDefaultValue = false)]
    public DateTime CreatedAt { get; set; }

    [DataMember(Name = "UpdatedAt", EmitDefaultValue = false)]
    public DateTime UpdatedAt { get; set; }
}
