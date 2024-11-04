namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginSpec // (runtime.PluginSpec)
{
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [DataMember(Name = "remote", EmitDefaultValue = false)]
    [JsonPropertyName("remote")]
    public string Remote { get; set; }

    [DataMember(Name = "privileges", EmitDefaultValue = false)]
    [JsonPropertyName("privileges")]
    public IList<RuntimePluginPrivilege> Privileges { get; set; }

    [DataMember(Name = "disabled", EmitDefaultValue = false)]
    [JsonPropertyName("disabled")]
    public bool Disabled { get; set; }

    [DataMember(Name = "env", EmitDefaultValue = false)]
    [JsonPropertyName("env")]
    public IList<string> Env { get; set; }
}
