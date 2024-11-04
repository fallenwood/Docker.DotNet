namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class EncryptionConfig // (swarm.EncryptionConfig)
{
    [DataMember(Name = "AutoLockManagers", EmitDefaultValue = false)]
    [JsonPropertyName("AutoLockManagers")]
    public bool AutoLockManagers { get; set; }
}
