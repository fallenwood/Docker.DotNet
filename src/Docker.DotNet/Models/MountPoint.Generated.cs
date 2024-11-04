namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class MountPoint // (types.MountPoint)
{
    [DataMember(Name = "Type", EmitDefaultValue = false)]
    [JsonPropertyName("Type")]
    public string Type { get; set; }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "Source", EmitDefaultValue = false)]
    [JsonPropertyName("Source")]
    public string Source { get; set; }

    [DataMember(Name = "Destination", EmitDefaultValue = false)]
    [JsonPropertyName("Destination")]
    public string Destination { get; set; }

    [DataMember(Name = "Driver", EmitDefaultValue = false)]
    [JsonPropertyName("Driver")]
    public string Driver { get; set; }

    [DataMember(Name = "Mode", EmitDefaultValue = false)]
    [JsonPropertyName("Mode")]
    public string Mode { get; set; }

    [DataMember(Name = "RW", EmitDefaultValue = false)]
    [JsonPropertyName("RW")]
    public bool RW { get; set; }

    [DataMember(Name = "Propagation", EmitDefaultValue = false)]
    [JsonPropertyName("Propagation")]
    public string Propagation { get; set; }
}
