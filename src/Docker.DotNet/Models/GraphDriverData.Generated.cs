namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class GraphDriverData // (types.GraphDriverData)
{
    [DataMember(Name = "Data", EmitDefaultValue = false)]
    [JsonPropertyName("Data")]
    public IDictionary<string, string> Data { get; set; }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }
}
