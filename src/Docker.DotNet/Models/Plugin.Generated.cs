namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Plugin // (types.Plugin)
{
    [DataMember(Name = "Config", EmitDefaultValue = false)]
    [JsonPropertyName("Config")]
    public PluginConfig Config { get; set; }

    [DataMember(Name = "Enabled", EmitDefaultValue = false)]
    [JsonPropertyName("Enabled")]
    public bool Enabled { get; set; }

    [DataMember(Name = "Id", EmitDefaultValue = false)]
    [JsonPropertyName("Id")]
    public string ID { get; set; }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "PluginReference", EmitDefaultValue = false)]
    [JsonPropertyName("PluginReference")]
    public string PluginReference { get; set; }

    [DataMember(Name = "Settings", EmitDefaultValue = false)]
    [JsonPropertyName("Settings")]
    public PluginSettings Settings { get; set; }
}
