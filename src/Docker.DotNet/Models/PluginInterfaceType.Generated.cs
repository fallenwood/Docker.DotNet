namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginInterfaceType // (types.PluginInterfaceType)
{
    [DataMember(Name = "Capability", EmitDefaultValue = false)]
    [JsonPropertyName("Capability")]
    public string Capability { get; set; }

    [DataMember(Name = "Prefix", EmitDefaultValue = false)]
    [JsonPropertyName("Prefix")]
    public string Prefix { get; set; }

    [DataMember(Name = "Version", EmitDefaultValue = false)]
    [JsonPropertyName("Version")]
    public string Version { get; set; }
}
