namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class DeleteResponse // (image.DeleteResponse)
{
    [DataMember(Name = "Deleted", EmitDefaultValue = false)]
    [JsonPropertyName("Deleted")]
    public string Deleted { get; set; }

    [DataMember(Name = "Untagged", EmitDefaultValue = false)]
    [JsonPropertyName("Untagged")]
    public string Untagged { get; set; }
}
