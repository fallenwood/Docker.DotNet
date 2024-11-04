namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class JSONProgress // (jsonmessage.JSONProgress)
{
    [DataMember(Name = "current", EmitDefaultValue = false)]
    [JsonPropertyName("current")]
    public long Current { get; set; }

    [DataMember(Name = "total", EmitDefaultValue = false)]
    [JsonPropertyName("total")]
    public long Total { get; set; }

    [DataMember(Name = "start", EmitDefaultValue = false)]
    [JsonPropertyName("start")]
    public long Start { get; set; }

    [DataMember(Name = "hidecounts", EmitDefaultValue = false)]
    [JsonPropertyName("hidecounts")]
    public bool HideCounts { get; set; }

    [DataMember(Name = "units", EmitDefaultValue = false)]
    [JsonPropertyName("units")]
    public string Units { get; set; }

    [DataMember(Name = "winSize", EmitDefaultValue = false)]
    [JsonPropertyName("winSize")]
    public long winSize { get; set; }
}
