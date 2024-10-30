namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class ComponentVersion // (types.ComponentVersion)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "Version", EmitDefaultValue = false)]
    public string Version { get; set; }

    [DataMember(Name = "Details", EmitDefaultValue = false)]
    public IDictionary<string, string> Details { get; set; }
}
