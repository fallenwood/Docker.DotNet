namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class AppArmorOpts // (swarm.AppArmorOpts)
{
    [DataMember(Name = "Mode", EmitDefaultValue = false)]
    public string Mode { get; set; }
}
