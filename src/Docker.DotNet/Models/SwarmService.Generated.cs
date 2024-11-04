namespace Docker.DotNet.Models;

using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SwarmService // (swarm.Service)
{
    public SwarmService()
    {
    }

    public SwarmService(Meta Meta)
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
    public ServiceSpec Spec { get; set; }

    [DataMember(Name = "PreviousSpec", EmitDefaultValue = false)]
    [JsonPropertyName("PreviousSpec")]
    public ServiceSpec PreviousSpec { get; set; }

    [DataMember(Name = "Endpoint", EmitDefaultValue = false)]
    [JsonPropertyName("Endpoint")]
    public Endpoint Endpoint { get; set; }

    [DataMember(Name = "UpdateStatus", EmitDefaultValue = false)]
    [JsonPropertyName("UpdateStatus")]
    public UpdateStatus UpdateStatus { get; set; }

    [DataMember(Name = "ServiceStatus", EmitDefaultValue = false)]
    [JsonPropertyName("ServiceStatus")]
    public ServiceStatus ServiceStatus { get; set; }

    [DataMember(Name = "JobStatus", EmitDefaultValue = false)]
    [JsonPropertyName("JobStatus")]
    public JobStatus JobStatus { get; set; }
}
