namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NodeStatus // (swarm.NodeStatus)
{
    [DataMember(Name = "State", EmitDefaultValue = false)]
    [JsonPropertyName("State")]
    public string State { get; set; }

    [DataMember(Name = "Message", EmitDefaultValue = false)]
    [JsonPropertyName("Message")]
    public string Message { get; set; }

    [DataMember(Name = "Addr", EmitDefaultValue = false)]
    [JsonPropertyName("Addr")]
    public string Addr { get; set; }
}
