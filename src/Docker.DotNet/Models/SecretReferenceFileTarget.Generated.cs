namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SecretReferenceFileTarget // (swarm.SecretReferenceFileTarget)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "UID", EmitDefaultValue = false)]
    [JsonPropertyName("UID")]
    public string UID { get; set; }

    [DataMember(Name = "GID", EmitDefaultValue = false)]
    [JsonPropertyName("GID")]
    public string GID { get; set; }

    [DataMember(Name = "Mode", EmitDefaultValue = false)]
    [JsonPropertyName("Mode")]
    public uint Mode { get; set; }
}
