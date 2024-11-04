namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ImageSearchResponse // (registry.SearchResult)
{
    [DataMember(Name = "star_count", EmitDefaultValue = false)]
    [JsonPropertyName("star_count")]
    public long StarCount { get; set; }

    [DataMember(Name = "is_official", EmitDefaultValue = false)]
    [JsonPropertyName("is_official")]
    public bool IsOfficial { get; set; }

    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [DataMember(Name = "is_automated", EmitDefaultValue = false)]
    [JsonPropertyName("is_automated")]
    public bool IsAutomated { get; set; }

    [DataMember(Name = "description", EmitDefaultValue = false)]
    [JsonPropertyName("description")]
    public string Description { get; set; }
}
