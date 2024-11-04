namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SwarmUpdateConfig // (swarm.UpdateConfig)
{
    [DataMember(Name = "Parallelism", EmitDefaultValue = false)]
    [JsonPropertyName("Parallelism")]
    public ulong Parallelism { get; set; }

    [DataMember(Name = "Delay", EmitDefaultValue = false)]
    [JsonPropertyName("Delay")]
    public long Delay { get; set; }

    [DataMember(Name = "FailureAction", EmitDefaultValue = false)]
    [JsonPropertyName("FailureAction")]
    public string FailureAction { get; set; }

    [DataMember(Name = "Monitor", EmitDefaultValue = false)]
    [JsonPropertyName("Monitor")]
    public long Monitor { get; set; }

    [DataMember(Name = "MaxFailureRatio", EmitDefaultValue = false)]
    [JsonPropertyName("MaxFailureRatio")]
    public float MaxFailureRatio { get; set; }

    [DataMember(Name = "Order", EmitDefaultValue = false)]
    [JsonPropertyName("Order")]
    public string Order { get; set; }
}
