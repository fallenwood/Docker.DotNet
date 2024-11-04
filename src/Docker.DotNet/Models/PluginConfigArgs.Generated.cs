namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginConfigArgs // (types.PluginConfigArgs)
{
    [DataMember(Name = "Description", EmitDefaultValue = false)]
    [JsonPropertyName("Description")]
    public string Description { get; set; }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "Settable", EmitDefaultValue = false)]
    [JsonPropertyName("Settable")]
    public IList<string> Settable { get; set; }

    [DataMember(Name = "Value", EmitDefaultValue = false)]
    [JsonPropertyName("Value")]
    public IList<string> Value { get; set; }
}
