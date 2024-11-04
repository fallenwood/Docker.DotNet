namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PortBinding // (nat.PortBinding)
{
    [DataMember(Name = "HostIp", EmitDefaultValue = false)]
    [JsonPropertyName("HostIp")]
    public string HostIP { get; set; }

    [DataMember(Name = "HostPort", EmitDefaultValue = false)]
    [JsonPropertyName("HostPort")]
    public string HostPort { get; set; }
}
