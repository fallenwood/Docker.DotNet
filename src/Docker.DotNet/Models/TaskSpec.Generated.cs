namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class TaskSpec // (swarm.TaskSpec)
{
    [DataMember(Name = "ContainerSpec", EmitDefaultValue = false)]
    [JsonPropertyName("ContainerSpec")]
    public ContainerSpec ContainerSpec { get; set; }

    [DataMember(Name = "PluginSpec", EmitDefaultValue = false)]
    [JsonPropertyName("PluginSpec")]
    public PluginSpec PluginSpec { get; set; }

    [DataMember(Name = "NetworkAttachmentSpec", EmitDefaultValue = false)]
    [JsonPropertyName("NetworkAttachmentSpec")]
    public NetworkAttachmentSpec NetworkAttachmentSpec { get; set; }

    [DataMember(Name = "Resources", EmitDefaultValue = false)]
    [JsonPropertyName("Resources")]
    public ResourceRequirements Resources { get; set; }

    [DataMember(Name = "RestartPolicy", EmitDefaultValue = false)]
    [JsonPropertyName("RestartPolicy")]
    public SwarmRestartPolicy RestartPolicy { get; set; }

    [DataMember(Name = "Placement", EmitDefaultValue = false)]
    [JsonPropertyName("Placement")]
    public Placement Placement { get; set; }

    [DataMember(Name = "Networks", EmitDefaultValue = false)]
    [JsonPropertyName("Networks")]
    public IList<NetworkAttachmentConfig> Networks { get; set; }

    [DataMember(Name = "LogDriver", EmitDefaultValue = false)]
    [JsonPropertyName("LogDriver")]
    public SwarmDriver LogDriver { get; set; }

    [DataMember(Name = "ForceUpdate", EmitDefaultValue = false)]
    [JsonPropertyName("ForceUpdate")]
    public ulong ForceUpdate { get; set; }

    [DataMember(Name = "Runtime", EmitDefaultValue = false)]
    [JsonPropertyName("Runtime")]
    public string Runtime { get; set; }
}
