namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworkAttachmentConfig // (swarm.NetworkAttachmentConfig)
{
    [DataMember(Name = "Target", EmitDefaultValue = false)]
    [JsonPropertyName("Target")]
    public string Target { get; set; }

    [DataMember(Name = "Aliases", EmitDefaultValue = false)]
    [JsonPropertyName("Aliases")]
    public IList<string> Aliases { get; set; }

    [DataMember(Name = "DriverOpts", EmitDefaultValue = false)]
    [JsonPropertyName("DriverOpts")]
    public IDictionary<string, string> DriverOpts { get; set; }
}
