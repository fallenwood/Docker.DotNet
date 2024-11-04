namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ImageBuildResponse // (types.ImageBuildResponse)
{
    [DataMember(Name = "Body", EmitDefaultValue = false)]
    [JsonPropertyName("Body")]
    public object Body { get; set; }

    [DataMember(Name = "OSType", EmitDefaultValue = false)]
    [JsonPropertyName("OSType")]
    public string OSType { get; set; }
}
