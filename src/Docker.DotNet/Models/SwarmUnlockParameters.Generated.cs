namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SwarmUnlockParameters // (main.SwarmUnlockParameters)
{
    [DataMember(Name = "UnlockKey", EmitDefaultValue = false)]
    [JsonPropertyName("UnlockKey")]
    public string UnlockKey { get; set; }
}
