namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class PluginDescription // (swarm.PluginDescription)
{
    [DataMember(Name = "Type", EmitDefaultValue = false)]
    public string Type { get; set; }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    public string Name { get; set; }
}
