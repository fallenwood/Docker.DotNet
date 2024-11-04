namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NamedGenericResource // (swarm.NamedGenericResource)
{
    [DataMember(Name = "Kind", EmitDefaultValue = false)]
    [JsonPropertyName("Kind")]
    public string Kind { get; set; }

    [DataMember(Name = "Value", EmitDefaultValue = false)]
    [JsonPropertyName("Value")]
    public string Value { get; set; }
}
