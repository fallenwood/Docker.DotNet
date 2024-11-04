namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SpreadOver // (swarm.SpreadOver)
{
    [DataMember(Name = "SpreadDescriptor", EmitDefaultValue = false)]
    [JsonPropertyName("SpreadDescriptor")]
    public string SpreadDescriptor { get; set; }
}
