namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ExternalCA // (swarm.ExternalCA)
{
    [DataMember(Name = "Protocol", EmitDefaultValue = false)]
    [JsonPropertyName("Protocol")]
    public string Protocol { get; set; }

    [DataMember(Name = "URL", EmitDefaultValue = false)]
    [JsonPropertyName("URL")]
    public string URL { get; set; }

    [DataMember(Name = "Options", EmitDefaultValue = false)]
    [JsonPropertyName("Options")]
    public IDictionary<string, string> Options { get; set; }

    [DataMember(Name = "CACert", EmitDefaultValue = false)]
    [JsonPropertyName("CACert")]
    public string CACert { get; set; }
}
