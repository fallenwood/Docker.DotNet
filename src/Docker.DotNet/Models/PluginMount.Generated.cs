namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginMount // (types.PluginMount)
{
    [DataMember(Name = "Description", EmitDefaultValue = false)]
    [JsonPropertyName("Description")]
    public string Description { get; set; }

    [DataMember(Name = "Destination", EmitDefaultValue = false)]
    [JsonPropertyName("Destination")]
    public string Destination { get; set; }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "Options", EmitDefaultValue = false)]
    [JsonPropertyName("Options")]
    public IList<string> Options { get; set; }

    [DataMember(Name = "Settable", EmitDefaultValue = false)]
    [JsonPropertyName("Settable")]
    public IList<string> Settable { get; set; }

    [DataMember(Name = "Source", EmitDefaultValue = false)]
    [JsonPropertyName("Source")]
    public string Source { get; set; }

    [DataMember(Name = "Type", EmitDefaultValue = false)]
    [JsonPropertyName("Type")]
    public string Type { get; set; }
}
