namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ImagesLoadResponse // (image.LoadResponse)
{
    [DataMember(Name = "Body", EmitDefaultValue = false)]
    [JsonPropertyName("Body")]
    public object Body { get; set; }

    [DataMember(Name = "JSON", EmitDefaultValue = false)]
    [JsonPropertyName("JSON")]
    public bool JSON { get; set; }
}
