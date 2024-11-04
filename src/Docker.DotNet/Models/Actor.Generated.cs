namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Actor // (events.Actor)
{
    [DataMember(Name = "ID", EmitDefaultValue = false)]
    [JsonPropertyName("ID")]
    public string ID { get; set; }

    [DataMember(Name = "Attributes", EmitDefaultValue = false)]
    [JsonPropertyName("Attributes")]
    public IDictionary<string, string> Attributes { get; set; }
}
