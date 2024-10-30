namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class PluginConfigArgs // (types.PluginConfigArgs)
{
    [DataMember(Name = "Description", EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "Settable", EmitDefaultValue = false)]
    public IList<string> Settable { get; set; }

    [DataMember(Name = "Value", EmitDefaultValue = false)]
    public IList<string> Value { get; set; }
}
