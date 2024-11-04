namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Message // (events.Message)
{
    [DataMember(Name = "status", EmitDefaultValue = false)]
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [DataMember(Name = "id", EmitDefaultValue = false)]
    [JsonPropertyName("id")]
    public string ID { get; set; }

    [DataMember(Name = "from", EmitDefaultValue = false)]
    [JsonPropertyName("from")]
    public string From { get; set; }

    [DataMember(Name = "Type", EmitDefaultValue = false)]
    [JsonPropertyName("Type")]
    public string Type { get; set; }

    [DataMember(Name = "Action", EmitDefaultValue = false)]
    [JsonPropertyName("Action")]
    public string Action { get; set; }

    [DataMember(Name = "Actor", EmitDefaultValue = false)]
    [JsonPropertyName("Actor")]
    public Actor Actor { get; set; }

    [DataMember(Name = "scope", EmitDefaultValue = false)]
    [JsonPropertyName("scope")]
    public string Scope { get; set; }

    [DataMember(Name = "time", EmitDefaultValue = false)]
    [JsonPropertyName("time")]
    public long Time { get; set; }

    [DataMember(Name = "timeNano", EmitDefaultValue = false)]
    [JsonPropertyName("timeNano")]
    public long TimeNano { get; set; }
}
