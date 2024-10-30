namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class DiscreteGenericResource // (swarm.DiscreteGenericResource)
{
    [DataMember(Name = "Kind", EmitDefaultValue = false)]
    public string Kind { get; set; }

    [DataMember(Name = "Value", EmitDefaultValue = false)]
    public long Value { get; set; }
}
