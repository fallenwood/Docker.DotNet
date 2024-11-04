namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class AuthConfig // (registry.AuthConfig)
{
    [DataMember(Name = "username", EmitDefaultValue = false)]
    [JsonPropertyName("username")]
    public string Username { get; set; }

    [DataMember(Name = "password", EmitDefaultValue = false)]
    [JsonPropertyName("password")]
    public string Password { get; set; }

    [DataMember(Name = "auth", EmitDefaultValue = false)]
    [JsonPropertyName("auth")]
    public string Auth { get; set; }

    [DataMember(Name = "email", EmitDefaultValue = false)]
    [JsonPropertyName("email")]
    public string Email { get; set; }

    [DataMember(Name = "serveraddress", EmitDefaultValue = false)]
    [JsonPropertyName("serveraddress")]
    public string ServerAddress { get; set; }

    [DataMember(Name = "identitytoken", EmitDefaultValue = false)]
    [JsonPropertyName("identitytoken")]
    public string IdentityToken { get; set; }

    [DataMember(Name = "registrytoken", EmitDefaultValue = false)]
    [JsonPropertyName("registrytoken")]
    public string RegistryToken { get; set; }
}
