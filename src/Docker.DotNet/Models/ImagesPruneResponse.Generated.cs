namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class ImagesPruneResponse // (image.PruneReport)
{
    [DataMember(Name = "ImagesDeleted", EmitDefaultValue = false)]
    public IList<DeleteResponse> ImagesDeleted { get; set; }

    [DataMember(Name = "SpaceReclaimed", EmitDefaultValue = false)]
    public ulong SpaceReclaimed { get; set; }
}
