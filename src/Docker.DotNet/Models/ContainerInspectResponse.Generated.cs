namespace Docker.DotNet.Models;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerInspectResponse // (types.ContainerJSON)
{
    public ContainerInspectResponse()
    {
    }

    public ContainerInspectResponse(ContainerJSONBase ContainerJSONBase)
    {
        if (ContainerJSONBase != null)
        {
            this.ID = ContainerJSONBase.ID;
            this.Created = ContainerJSONBase.Created;
            this.Path = ContainerJSONBase.Path;
            this.Args = ContainerJSONBase.Args;
            this.State = ContainerJSONBase.State;
            this.Image = ContainerJSONBase.Image;
            this.ResolvConfPath = ContainerJSONBase.ResolvConfPath;
            this.HostnamePath = ContainerJSONBase.HostnamePath;
            this.HostsPath = ContainerJSONBase.HostsPath;
            this.LogPath = ContainerJSONBase.LogPath;
            this.Node = ContainerJSONBase.Node;
            this.Name = ContainerJSONBase.Name;
            this.RestartCount = ContainerJSONBase.RestartCount;
            this.Driver = ContainerJSONBase.Driver;
            this.Platform = ContainerJSONBase.Platform;
            this.MountLabel = ContainerJSONBase.MountLabel;
            this.ProcessLabel = ContainerJSONBase.ProcessLabel;
            this.AppArmorProfile = ContainerJSONBase.AppArmorProfile;
            this.ExecIDs = ContainerJSONBase.ExecIDs;
            this.HostConfig = ContainerJSONBase.HostConfig;
            this.GraphDriver = ContainerJSONBase.GraphDriver;
            this.SizeRw = ContainerJSONBase.SizeRw;
            this.SizeRootFs = ContainerJSONBase.SizeRootFs;
        }
    }

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

    [DataMember(Name = "Mounts", EmitDefaultValue = false)]
    [JsonPropertyName("Mounts")]
    public IList<MountPoint> Mounts { get; set; }

    [DataMember(Name = "Config", EmitDefaultValue = false)]
    [JsonPropertyName("Config")]
    public Config Config { get; set; }

    [DataMember(Name = "NetworkSettings", EmitDefaultValue = false)]
    [JsonPropertyName("NetworkSettings")]
    public NetworkSettings NetworkSettings { get; set; }
}
