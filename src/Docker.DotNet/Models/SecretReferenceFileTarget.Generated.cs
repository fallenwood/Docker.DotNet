namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class SecretReferenceFileTarget // (swarm.SecretReferenceFileTarget)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "UID", EmitDefaultValue = false)]
    public string UID { get; set; }

    [DataMember(Name = "GID", EmitDefaultValue = false)]
    public string GID { get; set; }

    [DataMember(Name = "Mode", EmitDefaultValue = false)]
    public uint Mode { get; set; }
}
