namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Mount // (mount.Mount)
{
    [DataMember(Name = "Type", EmitDefaultValue = false)]
    [JsonPropertyName("Type")]
    public string Type { get; set; }

    [DataMember(Name = "Source", EmitDefaultValue = false)]
    [JsonPropertyName("Source")]
    public string Source { get; set; }

    [DataMember(Name = "Target", EmitDefaultValue = false)]
    [JsonPropertyName("Target")]
    public string Target { get; set; }

    [DataMember(Name = "ReadOnly", EmitDefaultValue = false)]
    [JsonPropertyName("ReadOnly")]
    public bool ReadOnly { get; set; }

    [DataMember(Name = "Consistency", EmitDefaultValue = false)]
    [JsonPropertyName("Consistency")]
    public string Consistency { get; set; }

    [DataMember(Name = "BindOptions", EmitDefaultValue = false)]
    [JsonPropertyName("BindOptions")]
    public BindOptions BindOptions { get; set; }

    [DataMember(Name = "VolumeOptions", EmitDefaultValue = false)]
    [JsonPropertyName("VolumeOptions")]
    public VolumeOptions VolumeOptions { get; set; }

    [DataMember(Name = "TmpfsOptions", EmitDefaultValue = false)]
    [JsonPropertyName("TmpfsOptions")]
    public TmpfsOptions TmpfsOptions { get; set; }

    [DataMember(Name = "ClusterOptions", EmitDefaultValue = false)]
    [JsonPropertyName("ClusterOptions")]
    public ClusterOptions ClusterOptions { get; set; }
}
