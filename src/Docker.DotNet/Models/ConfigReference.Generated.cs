namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ConfigReference // (network.ConfigReference)
{
    [DataMember(Name = "Network", EmitDefaultValue = false)]
    public string Network { get; set; }
}
