namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class DispatcherConfig // (swarm.DispatcherConfig)
{
    [DataMember(Name = "HeartbeatPeriod", EmitDefaultValue = false)]
    [JsonPropertyName("HeartbeatPeriod")]
    public long HeartbeatPeriod { get; set; }
}
