namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SwarmCreateConfigParameters // (main.SwarmCreateConfigParameters)
{
    [DataMember(Name = "Config", EmitDefaultValue = false)]
    [JsonPropertyName("Config")]
    public SwarmConfigSpec Config { get; set; }
}
