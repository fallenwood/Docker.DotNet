namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerFileSystemChangeResponse // (container.FilesystemChange)
{
    [DataMember(Name = "Kind", EmitDefaultValue = false)]
    public FileSystemChangeKind Kind { get; set; }

    [DataMember(Name = "Path", EmitDefaultValue = false)]
    public string Path { get; set; }
}
