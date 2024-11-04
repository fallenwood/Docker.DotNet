namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class AuthResponse // (registry.AuthenticateOKBody)
{
    [DataMember(Name = "IdentityToken", EmitDefaultValue = false)]
    [JsonPropertyName("IdentityToken")]
    public string IdentityToken { get; set; }

    [DataMember(Name = "Status", EmitDefaultValue = false)]
    [JsonPropertyName("Status")]
    public string Status { get; set; }
}
