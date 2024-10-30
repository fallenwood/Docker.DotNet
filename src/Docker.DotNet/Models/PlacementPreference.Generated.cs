namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class PlacementPreference // (swarm.PlacementPreference)
{
    [DataMember(Name = "Spread", EmitDefaultValue = false)]
    public SpreadOver Spread { get; set; }
}
