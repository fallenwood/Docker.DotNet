namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class AuthResponse // (registry.AuthenticateOKBody)
{
    [DataMember(Name = "IdentityToken", EmitDefaultValue = false)]
    public string IdentityToken { get; set; }

    [DataMember(Name = "Status", EmitDefaultValue = false)]
    public string Status { get; set; }
}
