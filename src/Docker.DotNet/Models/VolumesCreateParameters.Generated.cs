namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class VolumesCreateParameters // (main.VolumesCreateParameters)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "Driver", EmitDefaultValue = false)]
    [JsonPropertyName("Driver")]
    public string Driver { get; set; }

    [DataMember(Name = "DriverOpts", EmitDefaultValue = false)]
    [JsonPropertyName("DriverOpts")]
    public IDictionary<string, string> DriverOpts { get; set; }

    [DataMember(Name = "Labels", EmitDefaultValue = false)]
    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; }
}
