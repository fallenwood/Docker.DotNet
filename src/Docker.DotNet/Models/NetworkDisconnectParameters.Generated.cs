namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworkDisconnectParameters // (network.DisconnectOptions)
{
    [DataMember(Name = "Container", EmitDefaultValue = false)]
    [JsonPropertyName("Container")]
    public string Container { get; set; }

    [DataMember(Name = "Force", EmitDefaultValue = false)]
    [JsonPropertyName("Force")]
    public bool Force { get; set; }
}
