namespace Docker.DotNet.Models;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class HealthcheckConfig // (v1.HealthcheckConfig)
{
    [DataMember(Name = "Test", EmitDefaultValue = false)]
    [JsonPropertyName("Test")]
    public IList<string> Test { get; set; }

    [DataMember(Name = "Interval", EmitDefaultValue = false)]
    [JsonPropertyName("Interval")]
    [JsonConverter(typeof(TimeSpanNanosecondsConverter))]
    public TimeSpan Interval { get; set; }

    [DataMember(Name = "Timeout", EmitDefaultValue = false)]
    [JsonPropertyName("Timeout")]
    [JsonConverter(typeof(TimeSpanNanosecondsConverter))]
    public TimeSpan Timeout { get; set; }

    [DataMember(Name = "StartPeriod", EmitDefaultValue = false)]
    [JsonPropertyName("StartPeriod")]
    public long StartPeriod { get; set; }

    [DataMember(Name = "StartInterval", EmitDefaultValue = false)]
    [JsonPropertyName("StartInterval")]
    public long StartInterval { get; set; }

    [DataMember(Name = "Retries", EmitDefaultValue = false)]
    [JsonPropertyName("Retries")]
    public long Retries { get; set; }
}
