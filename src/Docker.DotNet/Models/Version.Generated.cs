namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class Version // (swarm.Version)
{
    [DataMember(Name = "Index", EmitDefaultValue = false)]
    public ulong Index { get; set; }
}
