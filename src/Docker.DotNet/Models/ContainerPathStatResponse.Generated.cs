namespace Docker.DotNet.Models;

using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerPathStatResponse // (container.PathStat)
{
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [DataMember(Name = "size", EmitDefaultValue = false)]
    [JsonPropertyName("size")]
    public long Size { get; set; }

    [DataMember(Name = "mode", EmitDefaultValue = false)]
    [JsonPropertyName("mode")]
    public uint Mode { get; set; }

    [DataMember(Name = "mtime", EmitDefaultValue = false)]
    [JsonPropertyName("mtime")]
    public DateTime Mtime { get; set; }

    [DataMember(Name = "linkTarget", EmitDefaultValue = false)]
    [JsonPropertyName("linkTarget")]
    public string LinkTarget { get; set; }
}
