namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class WaitExitError // (container.WaitExitError)
{
    [DataMember(Name = "Message", EmitDefaultValue = false)]
    [JsonPropertyName("Message")]
    public string Message { get; set; }
}
