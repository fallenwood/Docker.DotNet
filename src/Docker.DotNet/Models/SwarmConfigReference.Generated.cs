namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SwarmConfigReference // (swarm.ConfigReference)
{
    [DataMember(Name = "File", EmitDefaultValue = false)]
    [JsonPropertyName("File")]
    public ConfigReferenceFileTarget File { get; set; }

    [DataMember(Name = "Runtime", EmitDefaultValue = false)]
    [JsonPropertyName("Runtime")]
    public ConfigReferenceRuntimeTarget Runtime { get; set; }

    [DataMember(Name = "ConfigID", EmitDefaultValue = false)]
    [JsonPropertyName("ConfigID")]
    public string ConfigID { get; set; }

    [DataMember(Name = "ConfigName", EmitDefaultValue = false)]
    [JsonPropertyName("ConfigName")]
    public string ConfigName { get; set; }
}
