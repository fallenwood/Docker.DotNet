namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerWaitResponse // (main.ContainerWaitResponse)
{
    [DataMember(Name = "Error", EmitDefaultValue = false)]
    [JsonPropertyName("Error")]
    public WaitExitError Error { get; set; }

    [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
    [JsonPropertyName("StatusCode")]
    public long StatusCode { get; set; }
}
