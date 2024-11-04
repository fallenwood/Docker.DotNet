namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ResourceRequirements // (swarm.ResourceRequirements)
{
    [DataMember(Name = "Limits", EmitDefaultValue = false)]
    [JsonPropertyName("Limits")]
    public SwarmLimit Limits { get; set; }

    [DataMember(Name = "Reservations", EmitDefaultValue = false)]
    [JsonPropertyName("Reservations")]
    public SwarmResources Reservations { get; set; }
}
