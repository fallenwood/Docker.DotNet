namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Privileges // (swarm.Privileges)
{
    [DataMember(Name = "CredentialSpec", EmitDefaultValue = false)]
    [JsonPropertyName("CredentialSpec")]
    public CredentialSpec CredentialSpec { get; set; }

    [DataMember(Name = "SELinuxContext", EmitDefaultValue = false)]
    [JsonPropertyName("SELinuxContext")]
    public SELinuxContext SELinuxContext { get; set; }

    [DataMember(Name = "Seccomp", EmitDefaultValue = false)]
    [JsonPropertyName("Seccomp")]
    public SeccompOpts Seccomp { get; set; }

    [DataMember(Name = "AppArmor", EmitDefaultValue = false)]
    [JsonPropertyName("AppArmor")]
    public AppArmorOpts AppArmor { get; set; }

    [DataMember(Name = "NoNewPrivileges", EmitDefaultValue = false)]
    [JsonPropertyName("NoNewPrivileges")]
    public bool NoNewPrivileges { get; set; }
}
