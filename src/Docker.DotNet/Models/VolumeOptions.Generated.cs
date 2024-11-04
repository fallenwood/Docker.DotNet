namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class VolumeOptions // (mount.VolumeOptions)
{
    [DataMember(Name = "NoCopy", EmitDefaultValue = false)]
    [JsonPropertyName("NoCopy")]
    public bool NoCopy { get; set; }

    [DataMember(Name = "Labels", EmitDefaultValue = false)]
    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; }

    [DataMember(Name = "Subpath", EmitDefaultValue = false)]
    [JsonPropertyName("Subpath")]
    public string Subpath { get; set; }

    [DataMember(Name = "DriverConfig", EmitDefaultValue = false)]
    [JsonPropertyName("DriverConfig")]
    public Driver DriverConfig { get; set; }
}
