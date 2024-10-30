namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class PluginConfigNetwork // (types.PluginConfigNetwork)
{
    [DataMember(Name = "Type", EmitDefaultValue = false)]
    public string Type { get; set; }
}
