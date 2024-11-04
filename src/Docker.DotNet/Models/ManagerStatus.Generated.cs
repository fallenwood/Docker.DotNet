namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ManagerStatus // (swarm.ManagerStatus)
{
    [DataMember(Name = "Leader", EmitDefaultValue = false)]
    [JsonPropertyName("Leader")]
    public bool Leader { get; set; }

    [DataMember(Name = "Reachability", EmitDefaultValue = false)]
    [JsonPropertyName("Reachability")]
    public string Reachability { get; set; }

    [DataMember(Name = "Addr", EmitDefaultValue = false)]
    [JsonPropertyName("Addr")]
    public string Addr { get; set; }
}
