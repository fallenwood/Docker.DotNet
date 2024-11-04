namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SwarmJoinParameters // (swarm.JoinRequest)
{
    [DataMember(Name = "ListenAddr", EmitDefaultValue = false)]
    [JsonPropertyName("ListenAddr")]
    public string ListenAddr { get; set; }

    [DataMember(Name = "AdvertiseAddr", EmitDefaultValue = false)]
    [JsonPropertyName("AdvertiseAddr")]
    public string AdvertiseAddr { get; set; }

    [DataMember(Name = "DataPathAddr", EmitDefaultValue = false)]
    [JsonPropertyName("DataPathAddr")]
    public string DataPathAddr { get; set; }

    [DataMember(Name = "RemoteAddrs", EmitDefaultValue = false)]
    [JsonPropertyName("RemoteAddrs")]
    public IList<string> RemoteAddrs { get; set; }

    [DataMember(Name = "JoinToken", EmitDefaultValue = false)]
    [JsonPropertyName("JoinToken")]
    public string JoinToken { get; set; }

    [DataMember(Name = "Availability", EmitDefaultValue = false)]
    [JsonPropertyName("Availability")]
    public string Availability { get; set; }
}
