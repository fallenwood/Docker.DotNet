namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginDescription // (swarm.PluginDescription)
{
    [DataMember(Name = "Type", EmitDefaultValue = false)]
    [JsonPropertyName("Type")]
    public string Type { get; set; }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }
}
