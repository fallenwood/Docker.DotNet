namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainersPruneResponse // (container.PruneReport)
{
    [DataMember(Name = "ContainersDeleted", EmitDefaultValue = false)]
    [JsonPropertyName("ContainersDeleted")]
    public IList<string> ContainersDeleted { get; set; }

    [DataMember(Name = "SpaceReclaimed", EmitDefaultValue = false)]
    [JsonPropertyName("SpaceReclaimed")]
    public ulong SpaceReclaimed { get; set; }
}
