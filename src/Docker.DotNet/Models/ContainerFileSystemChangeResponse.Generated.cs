namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerFileSystemChangeResponse // (container.FilesystemChange)
{
    [DataMember(Name = "Kind", EmitDefaultValue = false)]
    [JsonPropertyName("Kind")]
    public FileSystemChangeKind Kind { get; set; }

    [DataMember(Name = "Path", EmitDefaultValue = false)]
    [JsonPropertyName("Path")]
    public string Path { get; set; }
}
