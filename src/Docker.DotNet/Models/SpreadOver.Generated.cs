namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class SpreadOver // (swarm.SpreadOver)
{
    [DataMember(Name = "SpreadDescriptor", EmitDefaultValue = false)]
    public string SpreadDescriptor { get; set; }
}
