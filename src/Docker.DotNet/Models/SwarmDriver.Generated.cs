namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class SwarmDriver // (swarm.Driver)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "Options", EmitDefaultValue = false)]
    public IDictionary<string, string> Options { get; set; }
}
