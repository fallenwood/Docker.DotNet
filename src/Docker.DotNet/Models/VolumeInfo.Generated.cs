namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class VolumeInfo // (volume.Info)
{
    [DataMember(Name = "CapacityBytes", EmitDefaultValue = false)]
    [JsonPropertyName("CapacityBytes")]
    public long CapacityBytes { get; set; }

    [DataMember(Name = "VolumeContext", EmitDefaultValue = false)]
    [JsonPropertyName("VolumeContext")]
    public IDictionary<string, string> VolumeContext { get; set; }

    [DataMember(Name = "VolumeID", EmitDefaultValue = false)]
    [JsonPropertyName("VolumeID")]
    public string VolumeID { get; set; }

    [DataMember(Name = "AccessibleTopology", EmitDefaultValue = false)]
    [JsonPropertyName("AccessibleTopology")]
    public IList<VolumeTopology> AccessibleTopology { get; set; }
}
