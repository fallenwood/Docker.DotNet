namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SecretReference // (swarm.SecretReference)
{
    [DataMember(Name = "File", EmitDefaultValue = false)]
    [JsonPropertyName("File")]
    public SecretReferenceFileTarget File { get; set; }

    [DataMember(Name = "SecretID", EmitDefaultValue = false)]
    [JsonPropertyName("SecretID")]
    public string SecretID { get; set; }

    [DataMember(Name = "SecretName", EmitDefaultValue = false)]
    [JsonPropertyName("SecretName")]
    public string SecretName { get; set; }
}
