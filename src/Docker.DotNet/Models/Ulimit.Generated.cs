namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Ulimit // (units.Ulimit)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "Hard", EmitDefaultValue = false)]
    [JsonPropertyName("Hard")]
    public long Hard { get; set; }

    [DataMember(Name = "Soft", EmitDefaultValue = false)]
    [JsonPropertyName("Soft")]
    public long Soft { get; set; }
}
