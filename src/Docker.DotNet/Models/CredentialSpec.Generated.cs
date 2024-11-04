namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class CredentialSpec // (swarm.CredentialSpec)
{
    [DataMember(Name = "Config", EmitDefaultValue = false)]
    [JsonPropertyName("Config")]
    public string Config { get; set; }

    [DataMember(Name = "File", EmitDefaultValue = false)]
    [JsonPropertyName("File")]
    public string File { get; set; }

    [DataMember(Name = "Registry", EmitDefaultValue = false)]
    [JsonPropertyName("Registry")]
    public string Registry { get; set; }
}
