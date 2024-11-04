namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class GenericResource // (swarm.GenericResource)
{
    [DataMember(Name = "NamedResourceSpec", EmitDefaultValue = false)]
    [JsonPropertyName("NamedResourceSpec")]
    public NamedGenericResource NamedResourceSpec { get; set; }

    [DataMember(Name = "DiscreteResourceSpec", EmitDefaultValue = false)]
    [JsonPropertyName("DiscreteResourceSpec")]
    public DiscreteGenericResource DiscreteResourceSpec { get; set; }
}
