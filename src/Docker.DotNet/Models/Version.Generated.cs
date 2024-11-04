namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Version // (swarm.Version)
{
    [DataMember(Name = "Index", EmitDefaultValue = false)]
    [JsonPropertyName("Index")]
    public ulong Index { get; set; }
}
