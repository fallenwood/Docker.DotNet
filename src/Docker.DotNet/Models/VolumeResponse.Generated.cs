namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class VolumeResponse // (main.VolumeResponse)
{
    [DataMember(Name = "ClusterVolume", EmitDefaultValue = false)]
    [JsonPropertyName("ClusterVolume")]
    public ClusterVolume ClusterVolume { get; set; }

    [DataMember(Name = "CreatedAt", EmitDefaultValue = false)]
    [JsonPropertyName("CreatedAt")]
    public string CreatedAt { get; set; }

    [DataMember(Name = "Driver", EmitDefaultValue = false)]
    [JsonPropertyName("Driver")]
    public string Driver { get; set; }

    [DataMember(Name = "Labels", EmitDefaultValue = false)]
    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; }

    [DataMember(Name = "Mountpoint", EmitDefaultValue = false)]
    [JsonPropertyName("Mountpoint")]
    public string Mountpoint { get; set; }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "Options", EmitDefaultValue = false)]
    [JsonPropertyName("Options")]
    public IDictionary<string, string> Options { get; set; }

    [DataMember(Name = "Scope", EmitDefaultValue = false)]
    [JsonPropertyName("Scope")]
    public string Scope { get; set; }

    [DataMember(Name = "Status", EmitDefaultValue = false)]
    [JsonPropertyName("Status")]
    public IDictionary<string, object> Status { get; set; }

    [DataMember(Name = "UsageData", EmitDefaultValue = false)]
    [JsonPropertyName("UsageData")]
    public UsageData UsageData { get; set; }
}
