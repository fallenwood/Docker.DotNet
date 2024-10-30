namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class NamedGenericResource // (swarm.NamedGenericResource)
{
    [DataMember(Name = "Kind", EmitDefaultValue = false)]
    public string Kind { get; set; }

    [DataMember(Name = "Value", EmitDefaultValue = false)]
    public string Value { get; set; }
}
