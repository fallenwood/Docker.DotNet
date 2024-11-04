namespace Docker.DotNet.Models;

using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NodeListResponse // (swarm.Node)
{
    public NodeListResponse()
    {
    }

    public NodeListResponse(Meta Meta)
    {
        if (Meta != null)
        {
            this.Version = Meta.Version;
            this.CreatedAt = Meta.CreatedAt;
            this.UpdatedAt = Meta.UpdatedAt;
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

    [DataMember(Name = "Spec", EmitDefaultValue = false)]
    [JsonPropertyName("Spec")]
    public NodeUpdateParameters Spec { get; set; }

    [DataMember(Name = "Description", EmitDefaultValue = false)]
    [JsonPropertyName("Description")]
    public NodeDescription Description { get; set; }

    [DataMember(Name = "Status", EmitDefaultValue = false)]
    [JsonPropertyName("Status")]
    public NodeStatus Status { get; set; }

    [DataMember(Name = "ManagerStatus", EmitDefaultValue = false)]
    [JsonPropertyName("ManagerStatus")]
    public ManagerStatus ManagerStatus { get; set; }
}
