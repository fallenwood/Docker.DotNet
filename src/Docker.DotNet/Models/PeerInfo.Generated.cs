namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PeerInfo // (network.PeerInfo)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "IP", EmitDefaultValue = false)]
    [JsonPropertyName("IP")]
    public string IP { get; set; }
}
