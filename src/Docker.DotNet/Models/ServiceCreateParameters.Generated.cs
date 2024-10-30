namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ServiceCreateParameters // (main.ServiceCreateParameters)
{
    [DataMember(Name = "Service", EmitDefaultValue = false)]
    public ServiceSpec Service { get; set; }

    [DataMember(Name = "RegistryAuth", EmitDefaultValue = false)]
    public AuthConfig RegistryAuth { get; set; }
}
