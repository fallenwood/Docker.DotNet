namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ServiceCreateParameters // (main.ServiceCreateParameters)
{
    [DataMember(Name = "Service", EmitDefaultValue = false)]
    [JsonPropertyName("Service")]
    public ServiceSpec Service { get; set; }

    [DataMember(Name = "RegistryAuth", EmitDefaultValue = false)]
    [JsonPropertyName("RegistryAuth")]
    public AuthConfig RegistryAuth { get; set; }
}
