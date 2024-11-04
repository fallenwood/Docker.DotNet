namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginDevice // (types.PluginDevice)
{
    [DataMember(Name = "Description", EmitDefaultValue = false)]
    [JsonPropertyName("Description")]
    public string Description { get; set; }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "Path", EmitDefaultValue = false)]
    [JsonPropertyName("Path")]
    public string Path { get; set; }

    [DataMember(Name = "Settable", EmitDefaultValue = false)]
    [JsonPropertyName("Settable")]
    public IList<string> Settable { get; set; }
}
