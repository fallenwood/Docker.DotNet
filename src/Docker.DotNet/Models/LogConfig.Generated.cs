namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class LogConfig // (container.LogConfig)
{
    [DataMember(Name = "Type", EmitDefaultValue = false)]
    [JsonPropertyName("Type")]
    public string Type { get; set; }

    [DataMember(Name = "Config", EmitDefaultValue = false)]
    [JsonPropertyName("Config")]
    public IDictionary<string, string> Config { get; set; }
}
