namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerRestartParameters // (main.ContainerRestartParameters)
{
    [DataMember(Name = "Signal", EmitDefaultValue = false)]
    [JsonPropertyName("Signal")]
    public string Signal { get; set; }

    [QueryStringParameter("t", false)]
    public uint? WaitBeforeKillSeconds { get; set; }
}
