namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ImagesPruneResponse // (image.PruneReport)
{
    [DataMember(Name = "ImagesDeleted", EmitDefaultValue = false)]
    [JsonPropertyName("ImagesDeleted")]
    public IList<DeleteResponse> ImagesDeleted { get; set; }

    [DataMember(Name = "SpaceReclaimed", EmitDefaultValue = false)]
    [JsonPropertyName("SpaceReclaimed")]
    public ulong SpaceReclaimed { get; set; }
}
