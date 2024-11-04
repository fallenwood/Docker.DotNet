namespace Docker.DotNet.Models;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class TaskResponse // (swarm.Task)
{
    public TaskResponse()
    {
    }

    public TaskResponse(Meta Meta, Annotations Annotations)
    {
        if (Meta != null)
        {
            this.Version = Meta.Version;
            this.CreatedAt = Meta.CreatedAt;
            this.UpdatedAt = Meta.UpdatedAt;
        }

        if (Annotations != null)
        {
            this.Name = Annotations.Name;
            this.Labels = Annotations.Labels;
        }
    }

    [DataMember(Name = "ID", EmitDefaultValue = false)]
    [JsonPropertyName("ID")]
    public string ID { get; set; }

    [DataMember(Name = "Version", EmitDefaultValue = false)]
    [JsonPropertyName("Version")]
    public Version Version { get; set; }

    [DataMember(Name = "CreatedAt", EmitDefaultValue = false)]
    [JsonPropertyName("CreatedAt")]
    public DateTime CreatedAt { get; set; }

    [DataMember(Name = "UpdatedAt", EmitDefaultValue = false)]
    [JsonPropertyName("UpdatedAt")]
    public DateTime UpdatedAt { get; set; }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "Labels", EmitDefaultValue = false)]
    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; }

    [DataMember(Name = "Spec", EmitDefaultValue = false)]
    [JsonPropertyName("Spec")]
    public TaskSpec Spec { get; set; }

    [DataMember(Name = "ServiceID", EmitDefaultValue = false)]
    [JsonPropertyName("ServiceID")]
    public string ServiceID { get; set; }

    [DataMember(Name = "Slot", EmitDefaultValue = false)]
    [JsonPropertyName("Slot")]
    public long Slot { get; set; }

    [DataMember(Name = "NodeID", EmitDefaultValue = false)]
    [JsonPropertyName("NodeID")]
    public string NodeID { get; set; }

    [DataMember(Name = "Status", EmitDefaultValue = false)]
    [JsonPropertyName("Status")]
    public TaskStatus Status { get; set; }

    [DataMember(Name = "DesiredState", EmitDefaultValue = false)]
    [JsonPropertyName("DesiredState")]
    public TaskState DesiredState { get; set; }

    [DataMember(Name = "NetworksAttachments", EmitDefaultValue = false)]
    [JsonPropertyName("NetworksAttachments")]
    public IList<NetworkAttachment> NetworksAttachments { get; set; }

    [DataMember(Name = "GenericResources", EmitDefaultValue = false)]
    [JsonPropertyName("GenericResources")]
    public IList<GenericResource> GenericResources { get; set; }

    [DataMember(Name = "JobIteration", EmitDefaultValue = false)]
    [JsonPropertyName("JobIteration")]
    public Version JobIteration { get; set; }

    [DataMember(Name = "Volumes", EmitDefaultValue = false)]
    [JsonPropertyName("Volumes")]
    public IList<VolumeAttachment> Volumes { get; set; }
}
