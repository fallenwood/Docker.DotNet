namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerExecInspectResponse // (container.ExecInspect)
{
    [DataMember(Name = "ID", EmitDefaultValue = false)]
    [JsonPropertyName("ID")]
    public string ExecID { get; set; }

    [DataMember(Name = "ContainerID", EmitDefaultValue = false)]
    [JsonPropertyName("ContainerID")]
    public string ContainerID { get; set; }

    [DataMember(Name = "Running", EmitDefaultValue = false)]
    [JsonPropertyName("Running")]
    public bool Running { get; set; }

    [DataMember(Name = "ExitCode", EmitDefaultValue = false)]
    [JsonPropertyName("ExitCode")]
    public long ExitCode { get; set; }

    [DataMember(Name = "Pid", EmitDefaultValue = false)]
    [JsonPropertyName("Pid")]
    public long Pid { get; set; }
}
