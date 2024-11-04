namespace Docker.DotNet.Models;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ImageInspectResponse // (types.ImageInspect)
{
    [DataMember(Name = "Id", EmitDefaultValue = false)]
    [JsonPropertyName("Id")]
    public string ID { get; set; }

    [DataMember(Name = "RepoTags", EmitDefaultValue = false)]
    [JsonPropertyName("RepoTags")]
    public IList<string> RepoTags { get; set; }

    [DataMember(Name = "RepoDigests", EmitDefaultValue = false)]
    [JsonPropertyName("RepoDigests")]
    public IList<string> RepoDigests { get; set; }

    [DataMember(Name = "Parent", EmitDefaultValue = false)]
    [JsonPropertyName("Parent")]
    public string Parent { get; set; }

    [DataMember(Name = "Comment", EmitDefaultValue = false)]
    [JsonPropertyName("Comment")]
    public string Comment { get; set; }

    [DataMember(Name = "Created", EmitDefaultValue = false)]
    [JsonPropertyName("Created")]
    public DateTime Created { get; set; }

    [DataMember(Name = "Container", EmitDefaultValue = false)]
    [JsonPropertyName("Container")]
    public string Container { get; set; }

    [DataMember(Name = "ContainerConfig", EmitDefaultValue = false)]
    [JsonPropertyName("ContainerConfig")]
    public Config ContainerConfig { get; set; }

    [DataMember(Name = "DockerVersion", EmitDefaultValue = false)]
    [JsonPropertyName("DockerVersion")]
    public string DockerVersion { get; set; }

    [DataMember(Name = "Author", EmitDefaultValue = false)]
    [JsonPropertyName("Author")]
    public string Author { get; set; }

    [DataMember(Name = "Config", EmitDefaultValue = false)]
    [JsonPropertyName("Config")]
    public Config Config { get; set; }

    [DataMember(Name = "Architecture", EmitDefaultValue = false)]
    [JsonPropertyName("Architecture")]
    public string Architecture { get; set; }

    [DataMember(Name = "Variant", EmitDefaultValue = false)]
    [JsonPropertyName("Variant")]
    public string Variant { get; set; }

    [DataMember(Name = "Os", EmitDefaultValue = false)]
    [JsonPropertyName("Os")]
    public string Os { get; set; }

    [DataMember(Name = "OsVersion", EmitDefaultValue = false)]
    [JsonPropertyName("OsVersion")]
    public string OsVersion { get; set; }

    [DataMember(Name = "Size", EmitDefaultValue = false)]
    [JsonPropertyName("Size")]
    public long Size { get; set; }

    [DataMember(Name = "VirtualSize", EmitDefaultValue = false)]
    [JsonPropertyName("VirtualSize")]
    public long VirtualSize { get; set; }

    [DataMember(Name = "GraphDriver", EmitDefaultValue = false)]
    [JsonPropertyName("GraphDriver")]
    public GraphDriverData GraphDriver { get; set; }

    [DataMember(Name = "RootFS", EmitDefaultValue = false)]
    [JsonPropertyName("RootFS")]
    public RootFS RootFS { get; set; }

    [DataMember(Name = "Metadata", EmitDefaultValue = false)]
    [JsonPropertyName("Metadata")]
    public Metadata Metadata { get; set; }
}
