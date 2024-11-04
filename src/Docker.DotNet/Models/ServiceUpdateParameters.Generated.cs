namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ServiceUpdateParameters // (main.ServiceUpdateParameters)
{
    [DataMember(Name = "Service", EmitDefaultValue = false)]
    [JsonPropertyName("Service")]
    public ServiceSpec Service { get; set; }

    [QueryStringParameter("version", true)]
    public long Version { get; set; }

    [QueryStringParameter("registryauthfrom", false)]
    public string RegistryAuthFrom { get; set; }

    [QueryStringParameter("rollback", false)]
    public string Rollback { get; set; }

    [DataMember(Name = "RegistryAuth", EmitDefaultValue = false)]
    [JsonPropertyName("RegistryAuth")]
    public AuthConfig RegistryAuth { get; set; }
}
