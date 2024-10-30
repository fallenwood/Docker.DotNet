namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class GenericResource // (swarm.GenericResource)
{
    [DataMember(Name = "NamedResourceSpec", EmitDefaultValue = false)]
    public NamedGenericResource NamedResourceSpec { get; set; }

    [DataMember(Name = "DiscreteResourceSpec", EmitDefaultValue = false)]
    public DiscreteGenericResource DiscreteResourceSpec { get; set; }
}
