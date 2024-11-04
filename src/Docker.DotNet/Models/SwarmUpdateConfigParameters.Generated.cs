namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SwarmUpdateConfigParameters // (main.SwarmUpdateConfigParameters)
{
    [DataMember(Name = "Config", EmitDefaultValue = false)]
    [JsonPropertyName("Config")]
    public SwarmConfigSpec Config { get; set; }

    [QueryStringParameter("version", true)]
    public long Version { get; set; }
}
