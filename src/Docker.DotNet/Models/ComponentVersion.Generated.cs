namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ComponentVersion // (types.ComponentVersion)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "Version", EmitDefaultValue = false)]
    [JsonPropertyName("Version")]
    public string Version { get; set; }

    [DataMember(Name = "Details", EmitDefaultValue = false)]
    [JsonPropertyName("Details")]
    public IDictionary<string, string> Details { get; set; }
}
