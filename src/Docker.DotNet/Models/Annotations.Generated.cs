namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class Annotations // (swarm.Annotations)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "Labels", EmitDefaultValue = false)]
    public IDictionary<string, string> Labels { get; set; }
}
