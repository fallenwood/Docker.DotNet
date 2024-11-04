namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PublishStatus // (volume.PublishStatus)
{
    [DataMember(Name = "NodeID", EmitDefaultValue = false)]
    [JsonPropertyName("NodeID")]
    public string NodeID { get; set; }

    [DataMember(Name = "State", EmitDefaultValue = false)]
    [JsonPropertyName("State")]
    public string State { get; set; }

    [DataMember(Name = "PublishContext", EmitDefaultValue = false)]
    [JsonPropertyName("PublishContext")]
    public IDictionary<string, string> PublishContext { get; set; }
}
