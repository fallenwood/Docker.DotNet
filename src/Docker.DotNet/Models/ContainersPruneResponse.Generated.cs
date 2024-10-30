namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class ContainersPruneResponse // (container.PruneReport)
{
    [DataMember(Name = "ContainersDeleted", EmitDefaultValue = false)]
    public IList<string> ContainersDeleted { get; set; }

    [DataMember(Name = "SpaceReclaimed", EmitDefaultValue = false)]
    public ulong SpaceReclaimed { get; set; }
}
