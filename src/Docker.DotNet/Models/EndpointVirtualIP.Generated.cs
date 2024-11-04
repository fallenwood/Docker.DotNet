namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class EndpointVirtualIP // (swarm.EndpointVirtualIP)
{
    [DataMember(Name = "NetworkID", EmitDefaultValue = false)]
    [JsonPropertyName("NetworkID")]
    public string NetworkID { get; set; }

    [DataMember(Name = "Addr", EmitDefaultValue = false)]
    [JsonPropertyName("Addr")]
    public string Addr { get; set; }
}
