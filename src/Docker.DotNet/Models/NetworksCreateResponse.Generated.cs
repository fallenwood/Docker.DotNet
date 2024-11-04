namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworksCreateResponse // (network.CreateResponse)
{
    [DataMember(Name = "Id", EmitDefaultValue = false)]
    [JsonPropertyName("Id")]
    public string ID { get; set; }

    [DataMember(Name = "Warning", EmitDefaultValue = false)]
    [JsonPropertyName("Warning")]
    public string Warning { get; set; }
}
