namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerStatus // (swarm.ContainerStatus)
{
    [DataMember(Name = "ContainerID", EmitDefaultValue = false)]
    [JsonPropertyName("ContainerID")]
    public string ContainerID { get; set; }

    [DataMember(Name = "PID", EmitDefaultValue = false)]
    [JsonPropertyName("PID")]
    public long PID { get; set; }

    [DataMember(Name = "ExitCode", EmitDefaultValue = false)]
    [JsonPropertyName("ExitCode")]
    public long ExitCode { get; set; }
}
