namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginGetPrivilegeParameters // (main.PluginGetPrivilegeParameters)
{
    [QueryStringParameter("remote", true)]
    public string Remote { get; set; }

    [DataMember(Name = "RegistryAuth", EmitDefaultValue = false)]
    [JsonPropertyName("RegistryAuth")]
    public AuthConfig RegistryAuth { get; set; }
}
