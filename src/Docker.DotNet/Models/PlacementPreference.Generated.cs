namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PlacementPreference // (swarm.PlacementPreference)
{
    [DataMember(Name = "Spread", EmitDefaultValue = false)]
    [JsonPropertyName("Spread")]
    public SpreadOver Spread { get; set; }
}
