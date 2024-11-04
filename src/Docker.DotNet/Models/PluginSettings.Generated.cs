namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginSettings // (types.PluginSettings)
{
    [DataMember(Name = "Args", EmitDefaultValue = false)]
    [JsonPropertyName("Args")]
    public IList<string> Args { get; set; }

    [DataMember(Name = "Devices", EmitDefaultValue = false)]
    [JsonPropertyName("Devices")]
    public IList<PluginDevice> Devices { get; set; }

    [DataMember(Name = "Env", EmitDefaultValue = false)]
    [JsonPropertyName("Env")]
    public IList<string> Env { get; set; }

    [DataMember(Name = "Mounts", EmitDefaultValue = false)]
    [JsonPropertyName("Mounts")]
    public IList<PluginMount> Mounts { get; set; }
}
