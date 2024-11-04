namespace Docker.DotNet.Models;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ClusterVolume // (volume.ClusterVolume)
{
    public ClusterVolume()
    {
    }

    public ClusterVolume(Meta Meta)
    {
        if (Meta != null)
        {
            this.Version = Meta.Version;
            this.CreatedAt = Meta.CreatedAt;
            this.UpdatedAt = Meta.UpdatedAt;
        }
    }

    [DataMember(Name = "ID", EmitDefaultValue = false)]
    [JsonPropertyName("ID")]
    public string ID { get; set; }

    [DataMember(Name = "Version", EmitDefaultValue = false)]
    [JsonPropertyName("Version")]
    public Version Version { get; set; }

    [DataMember(Name = "CreatedAt", EmitDefaultValue = false)]
    [JsonPropertyName("CreatedAt")]
    public DateTime CreatedAt { get; set; }

    [DataMember(Name = "UpdatedAt", EmitDefaultValue = false)]
    [JsonPropertyName("UpdatedAt")]
    public DateTime UpdatedAt { get; set; }

    [DataMember(Name = "Spec", EmitDefaultValue = false)]
    [JsonPropertyName("Spec")]
    public ClusterVolumeSpec Spec { get; set; }

    [DataMember(Name = "PublishStatus", EmitDefaultValue = false)]
    [JsonPropertyName("PublishStatus")]
    public IList<PublishStatus> PublishStatus { get; set; }

    [DataMember(Name = "Info", EmitDefaultValue = false)]
    [JsonPropertyName("Info")]
    public VolumeInfo Info { get; set; }
}
