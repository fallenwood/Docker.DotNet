namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class AppArmorOpts // (swarm.AppArmorOpts)
{
    [DataMember(Name = "Mode", EmitDefaultValue = false)]
    [JsonPropertyName("Mode")]
    public string Mode { get; set; }
}
