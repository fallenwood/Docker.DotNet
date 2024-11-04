namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SELinuxContext // (swarm.SELinuxContext)
{
    [DataMember(Name = "Disable", EmitDefaultValue = false)]
    [JsonPropertyName("Disable")]
    public bool Disable { get; set; }

    [DataMember(Name = "User", EmitDefaultValue = false)]
    [JsonPropertyName("User")]
    public string User { get; set; }

    [DataMember(Name = "Role", EmitDefaultValue = false)]
    [JsonPropertyName("Role")]
    public string Role { get; set; }

    [DataMember(Name = "Type", EmitDefaultValue = false)]
    [JsonPropertyName("Type")]
    public string Type { get; set; }

    [DataMember(Name = "Level", EmitDefaultValue = false)]
    [JsonPropertyName("Level")]
    public string Level { get; set; }
}
