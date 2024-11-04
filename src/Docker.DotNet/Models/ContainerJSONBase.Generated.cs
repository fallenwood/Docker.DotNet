namespace Docker.DotNet.Models;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerJSONBase // (types.ContainerJSONBase)
{
    [DataMember(Name = "Id", EmitDefaultValue = false)]
    [JsonPropertyName("Id")]
    public string ID { get; set; }

    [DataMember(Name = "Created", EmitDefaultValue = false)]
    [JsonPropertyName("Created")]
    public DateTime Created { get; set; }

    [DataMember(Name = "Path", EmitDefaultValue = false)]
    [JsonPropertyName("Path")]
    public string Path { get; set; }

    [DataMember(Name = "Args", EmitDefaultValue = false)]
    [JsonPropertyName("Args")]
    public IList<string> Args { get; set; }

    [DataMember(Name = "State", EmitDefaultValue = false)]
    [JsonPropertyName("State")]
    public ContainerState State { get; set; }

    [DataMember(Name = "Image", EmitDefaultValue = false)]
    [JsonPropertyName("Image")]
    public string Image { get; set; }

    [DataMember(Name = "ResolvConfPath", EmitDefaultValue = false)]
    [JsonPropertyName("ResolvConfPath")]
    public string ResolvConfPath { get; set; }

    [DataMember(Name = "HostnamePath", EmitDefaultValue = false)]
    [JsonPropertyName("HostnamePath")]
    public string HostnamePath { get; set; }

    [DataMember(Name = "HostsPath", EmitDefaultValue = false)]
    [JsonPropertyName("HostsPath")]
    public string HostsPath { get; set; }

    [DataMember(Name = "LogPath", EmitDefaultValue = false)]
    [JsonPropertyName("LogPath")]
    public string LogPath { get; set; }

    [DataMember(Name = "Node", EmitDefaultValue = false)]
    [JsonPropertyName("Node")]
    public ContainerNode Node { get; set; }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "RestartCount", EmitDefaultValue = false)]
    [JsonPropertyName("RestartCount")]
    public long RestartCount { get; set; }

    [DataMember(Name = "Driver", EmitDefaultValue = false)]
    [JsonPropertyName("Driver")]
    public string Driver { get; set; }

    [DataMember(Name = "Platform", EmitDefaultValue = false)]
    [JsonPropertyName("Platform")]
    public string Platform { get; set; }

    [DataMember(Name = "MountLabel", EmitDefaultValue = false)]
    [JsonPropertyName("MountLabel")]
    public string MountLabel { get; set; }

    [DataMember(Name = "ProcessLabel", EmitDefaultValue = false)]
    [JsonPropertyName("ProcessLabel")]
    public string ProcessLabel { get; set; }

    [DataMember(Name = "AppArmorProfile", EmitDefaultValue = false)]
    [JsonPropertyName("AppArmorProfile")]
    public string AppArmorProfile { get; set; }

    [DataMember(Name = "ExecIDs", EmitDefaultValue = false)]
    [JsonPropertyName("ExecIDs")]
    public IList<string> ExecIDs { get; set; }

    [DataMember(Name = "HostConfig", EmitDefaultValue = false)]
    [JsonPropertyName("HostConfig")]
    public HostConfig HostConfig { get; set; }

    [DataMember(Name = "GraphDriver", EmitDefaultValue = false)]
    [JsonPropertyName("GraphDriver")]
    public GraphDriverData GraphDriver { get; set; }

    [DataMember(Name = "SizeRw", EmitDefaultValue = false)]
    [JsonPropertyName("SizeRw")]
    public long? SizeRw { get; set; }

    [DataMember(Name = "SizeRootFs", EmitDefaultValue = false)]
    [JsonPropertyName("SizeRootFs")]
    public long? SizeRootFs { get; set; }
}
