namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Health // (types.Health)
{
    [DataMember(Name = "Status", EmitDefaultValue = false)]
    [JsonPropertyName("Status")]
    public string Status { get; set; }

    [DataMember(Name = "FailingStreak", EmitDefaultValue = false)]
    [JsonPropertyName("FailingStreak")]
    public long FailingStreak { get; set; }

    [DataMember(Name = "Log", EmitDefaultValue = false)]
    [JsonPropertyName("Log")]
    public IList<HealthcheckResult> Log { get; set; }
}
