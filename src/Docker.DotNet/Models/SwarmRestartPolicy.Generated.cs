namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SwarmRestartPolicy // (swarm.RestartPolicy)
{
    [DataMember(Name = "Condition", EmitDefaultValue = false)]
    [JsonPropertyName("Condition")]
    public string Condition { get; set; }

    [DataMember(Name = "Delay", EmitDefaultValue = false)]
    [JsonPropertyName("Delay")]
    public long? Delay { get; set; }

    [DataMember(Name = "MaxAttempts", EmitDefaultValue = false)]
    [JsonPropertyName("MaxAttempts")]
    public ulong? MaxAttempts { get; set; }

    [DataMember(Name = "Window", EmitDefaultValue = false)]
    [JsonPropertyName("Window")]
    public long? Window { get; set; }
}
