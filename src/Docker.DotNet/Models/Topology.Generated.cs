namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class Topology // (swarm.Topology)
{
    [DataMember(Name = "Segments", EmitDefaultValue = false)]
    public IDictionary<string, string> Segments { get; set; }
}
