namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class DNSConfig // (swarm.DNSConfig)
{
    [DataMember(Name = "Nameservers", EmitDefaultValue = false)]
    [JsonPropertyName("Nameservers")]
    public IList<string> Nameservers { get; set; }

    [DataMember(Name = "Search", EmitDefaultValue = false)]
    [JsonPropertyName("Search")]
    public IList<string> Search { get; set; }

    [DataMember(Name = "Options", EmitDefaultValue = false)]
    [JsonPropertyName("Options")]
    public IList<string> Options { get; set; }
}
