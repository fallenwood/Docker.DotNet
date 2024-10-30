namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class EncryptionConfig // (swarm.EncryptionConfig)
{
    [DataMember(Name = "AutoLockManagers", EmitDefaultValue = false)]
    public bool AutoLockManagers { get; set; }
}
