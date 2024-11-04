namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerState // (types.ContainerState)
{
    [DataMember(Name = "Status", EmitDefaultValue = false)]
    [JsonPropertyName("Status")]
    public string Status { get; set; }

    [DataMember(Name = "Running", EmitDefaultValue = false)]
    [JsonPropertyName("Running")]
    public bool Running { get; set; }

    [DataMember(Name = "Paused", EmitDefaultValue = false)]
    [JsonPropertyName("Paused")]
    public bool Paused { get; set; }

    [DataMember(Name = "Restarting", EmitDefaultValue = false)]
    [JsonPropertyName("Restarting")]
    public bool Restarting { get; set; }

    [DataMember(Name = "OOMKilled", EmitDefaultValue = false)]
    [JsonPropertyName("OOMKilled")]
    public bool OOMKilled { get; set; }

    [DataMember(Name = "Dead", EmitDefaultValue = false)]
    [JsonPropertyName("Dead")]
    public bool Dead { get; set; }

    [DataMember(Name = "Pid", EmitDefaultValue = false)]
    [JsonPropertyName("Pid")]
    public long Pid { get; set; }

    [DataMember(Name = "ExitCode", EmitDefaultValue = false)]
    [JsonPropertyName("ExitCode")]
    public long ExitCode { get; set; }

    [DataMember(Name = "Error", EmitDefaultValue = false)]
    [JsonPropertyName("Error")]
    public string Error { get; set; }

    [DataMember(Name = "StartedAt", EmitDefaultValue = false)]
    [JsonPropertyName("StartedAt")]
    public string StartedAt { get; set; }

    [DataMember(Name = "FinishedAt", EmitDefaultValue = false)]
    [JsonPropertyName("FinishedAt")]
    public string FinishedAt { get; set; }

    [DataMember(Name = "Health", EmitDefaultValue = false)]
    [JsonPropertyName("Health")]
    public Health Health { get; set; }
}
