namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class JoinTokens // (swarm.JoinTokens)
{
    [DataMember(Name = "Worker", EmitDefaultValue = false)]
    [JsonPropertyName("Worker")]
    public string Worker { get; set; }

    [DataMember(Name = "Manager", EmitDefaultValue = false)]
    [JsonPropertyName("Manager")]
    public string Manager { get; set; }
}
