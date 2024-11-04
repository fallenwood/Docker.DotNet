namespace Docker.DotNet.Models;

using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Metadata // (image.Metadata)
{
    [DataMember(Name = "LastTagTime", EmitDefaultValue = false)]
    [JsonPropertyName("LastTagTime")]
    public DateTime LastTagTime { get; set; }
}
