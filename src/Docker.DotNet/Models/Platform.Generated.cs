namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class Platform // (swarm.Platform)
{
    [DataMember(Name = "Architecture", EmitDefaultValue = false)]
    public string Architecture { get; set; }

    [DataMember(Name = "OS", EmitDefaultValue = false)]
    public string OS { get; set; }
}
