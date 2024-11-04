namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class JSONError // (jsonmessage.JSONError)
{
    [DataMember(Name = "code", EmitDefaultValue = false)]
    [JsonPropertyName("code")]
    public long Code { get; set; }

    [DataMember(Name = "message", EmitDefaultValue = false)]
    [JsonPropertyName("message")]
    public string Message { get; set; }
}
