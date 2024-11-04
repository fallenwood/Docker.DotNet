namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class VolumesListResponse // (main.VolumesListResponse)
{
    [DataMember(Name = "Volumes", EmitDefaultValue = false)]
    [JsonPropertyName("Volumes")]
    public IList<VolumeResponse> Volumes { get; set; }

    [DataMember(Name = "Warnings", EmitDefaultValue = false)]
    [JsonPropertyName("Warnings")]
    public IList<string> Warnings { get; set; }
}
