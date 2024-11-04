namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ServiceMode // (swarm.ServiceMode)
{
    [DataMember(Name = "Replicated", EmitDefaultValue = false)]
    [JsonPropertyName("Replicated")]
    public ReplicatedService Replicated { get; set; }

    [DataMember(Name = "Global", EmitDefaultValue = false)]
    [JsonPropertyName("Global")]
    public GlobalService Global { get; set; }

    [DataMember(Name = "ReplicatedJob", EmitDefaultValue = false)]
    [JsonPropertyName("ReplicatedJob")]
    public ReplicatedJob ReplicatedJob { get; set; }

    [DataMember(Name = "GlobalJob", EmitDefaultValue = false)]
    [JsonPropertyName("GlobalJob")]
    public GlobalJob GlobalJob { get; set; }
}
