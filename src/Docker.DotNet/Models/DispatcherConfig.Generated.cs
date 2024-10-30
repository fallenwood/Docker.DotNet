namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class DispatcherConfig // (swarm.DispatcherConfig)
{
    [DataMember(Name = "HeartbeatPeriod", EmitDefaultValue = false)]
    public long HeartbeatPeriod { get; set; }
}
