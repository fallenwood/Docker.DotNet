namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Address // (network.Address)
{
    [DataMember(Name = "Addr", EmitDefaultValue = false)]
    [JsonPropertyName("Addr")]
    public string Addr { get; set; }

    [DataMember(Name = "PrefixLen", EmitDefaultValue = false)]
    [JsonPropertyName("PrefixLen")]
    public long PrefixLen { get; set; }
}
