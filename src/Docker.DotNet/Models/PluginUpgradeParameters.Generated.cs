namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginUpgradeParameters // (main.PluginUpgradeParameters)
{
    [QueryStringParameter("remote", true)]
    public string Remote { get; set; }

    [DataMember(Name = "RegistryAuth", EmitDefaultValue = false)]
    [JsonPropertyName("RegistryAuth")]
    public AuthConfig RegistryAuth { get; set; }

    [DataMember(Name = "Privileges", EmitDefaultValue = false)]
    [JsonPropertyName("Privileges")]
    public IList<PluginPrivilege> Privileges { get; set; }
}
