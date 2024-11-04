namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworkAttachment // (swarm.NetworkAttachment)
{
    [DataMember(Name = "Network", EmitDefaultValue = false)]
    [JsonPropertyName("Network")]
    public Network Network { get; set; }

    [DataMember(Name = "Addresses", EmitDefaultValue = false)]
    [JsonPropertyName("Addresses")]
    public IList<string> Addresses { get; set; }
}
