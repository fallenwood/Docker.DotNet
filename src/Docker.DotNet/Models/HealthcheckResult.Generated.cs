namespace Docker.DotNet.Models;

using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class HealthcheckResult // (types.HealthcheckResult)
{
    [DataMember(Name = "Start", EmitDefaultValue = false)]
    [JsonPropertyName("Start")]
    public DateTime Start { get; set; }

    [DataMember(Name = "End", EmitDefaultValue = false)]
    [JsonPropertyName("End")]
    public DateTime End { get; set; }

    [DataMember(Name = "ExitCode", EmitDefaultValue = false)]
    [JsonPropertyName("ExitCode")]
    public long ExitCode { get; set; }

    [DataMember(Name = "Output", EmitDefaultValue = false)]
    [JsonPropertyName("Output")]
    public string Output { get; set; }
}
