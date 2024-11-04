namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Port // (types.Port)
{
    [DataMember(Name = "IP", EmitDefaultValue = false)]
    [JsonPropertyName("IP")]
    public string IP { get; set; }

    [DataMember(Name = "PrivatePort", EmitDefaultValue = false)]
    [JsonPropertyName("PrivatePort")]
    public ushort PrivatePort { get; set; }

    [DataMember(Name = "PublicPort", EmitDefaultValue = false)]
    [JsonPropertyName("PublicPort")]
    public ushort PublicPort { get; set; }

    [DataMember(Name = "Type", EmitDefaultValue = false)]
    [JsonPropertyName("Type")]
    public string Type { get; set; }
}
