namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ConfigReference // (network.ConfigReference)
{
    [DataMember(Name = "Network", EmitDefaultValue = false)]
    [JsonPropertyName("Network")]
    public string Network { get; set; }
}
