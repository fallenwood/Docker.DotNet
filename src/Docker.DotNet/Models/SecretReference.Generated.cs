namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class SecretReference // (swarm.SecretReference)
{
    [DataMember(Name = "File", EmitDefaultValue = false)]
    public SecretReferenceFileTarget File { get; set; }

    [DataMember(Name = "SecretID", EmitDefaultValue = false)]
    public string SecretID { get; set; }

    [DataMember(Name = "SecretName", EmitDefaultValue = false)]
    public string SecretName { get; set; }
}
