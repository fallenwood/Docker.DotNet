namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class RootFS // (types.RootFS)
{
    [DataMember(Name = "Type", EmitDefaultValue = false)]
    [JsonPropertyName("Type")]
    public string Type { get; set; }

    [DataMember(Name = "Layers", EmitDefaultValue = false)]
    [JsonPropertyName("Layers")]
    public IList<string> Layers { get; set; }
}
