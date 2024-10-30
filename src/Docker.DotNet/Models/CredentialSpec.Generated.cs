namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class CredentialSpec // (swarm.CredentialSpec)
{
    [DataMember(Name = "Config", EmitDefaultValue = false)]
    public string Config { get; set; }

    [DataMember(Name = "File", EmitDefaultValue = false)]
    public string File { get; set; }

    [DataMember(Name = "Registry", EmitDefaultValue = false)]
    public string Registry { get; set; }
}
