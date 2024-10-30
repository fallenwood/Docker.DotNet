namespace Docker.DotNet.Models;

using System;
using System.Runtime.Serialization;

[DataContract]
public sealed class Metadata // (image.Metadata)
{
    [DataMember(Name = "LastTagTime", EmitDefaultValue = false)]
    public DateTime LastTagTime { get; set; }
}
