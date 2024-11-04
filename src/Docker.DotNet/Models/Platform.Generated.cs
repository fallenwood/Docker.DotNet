namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Platform // (swarm.Platform)
{
    [DataMember(Name = "Architecture", EmitDefaultValue = false)]
    [JsonPropertyName("Architecture")]
    public string Architecture { get; set; }

    [DataMember(Name = "OS", EmitDefaultValue = false)]
    [JsonPropertyName("OS")]
    public string OS { get; set; }
}
