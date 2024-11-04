namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class EngineDescription // (swarm.EngineDescription)
{
    [DataMember(Name = "EngineVersion", EmitDefaultValue = false)]
    [JsonPropertyName("EngineVersion")]
    public string EngineVersion { get; set; }

    [DataMember(Name = "Labels", EmitDefaultValue = false)]
    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; }

    [DataMember(Name = "Plugins", EmitDefaultValue = false)]
    [JsonPropertyName("Plugins")]
    public IList<PluginDescription> Plugins { get; set; }
}
