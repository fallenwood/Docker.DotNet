namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class DiscreteGenericResource // (swarm.DiscreteGenericResource)
{
    [DataMember(Name = "Kind", EmitDefaultValue = false)]
    [JsonPropertyName("Kind")]
    public string Kind { get; set; }

    [DataMember(Name = "Value", EmitDefaultValue = false)]
    [JsonPropertyName("Value")]
    public long Value { get; set; }
}
