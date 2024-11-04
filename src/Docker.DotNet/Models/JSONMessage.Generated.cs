namespace Docker.DotNet.Models;

using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class JSONMessage // (jsonmessage.JSONMessage)
{
    [DataMember(Name = "stream", EmitDefaultValue = false)]
    [JsonPropertyName("stream")]
    public string Stream { get; set; }

    [DataMember(Name = "status", EmitDefaultValue = false)]
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [DataMember(Name = "progressDetail", EmitDefaultValue = false)]
    [JsonPropertyName("progressDetail")]
    public JSONProgress Progress { get; set; }

    [DataMember(Name = "progress", EmitDefaultValue = false)]
    [JsonPropertyName("progress")]
    public string ProgressMessage { get; set; }

    [DataMember(Name = "id", EmitDefaultValue = false)]
    [JsonPropertyName("id")]
    public string ID { get; set; }

    [DataMember(Name = "from", EmitDefaultValue = false)]
    [JsonPropertyName("from")]
    public string From { get; set; }

    [DataMember(Name = "time", EmitDefaultValue = false)]
    [JsonPropertyName("time")]
    public DateTime Time { get; set; }

    [DataMember(Name = "timeNano", EmitDefaultValue = false)]
    [JsonPropertyName("timeNano")]
    public long TimeNano { get; set; }

    [DataMember(Name = "errorDetail", EmitDefaultValue = false)]
    [JsonPropertyName("errorDetail")]
    public JSONError Error { get; set; }

    [DataMember(Name = "error", EmitDefaultValue = false)]
    [JsonPropertyName("error")]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "aux", EmitDefaultValue = false)]
    [JsonPropertyName("aux")]
    public ObjectExtensionData Aux { get; set; }
}
