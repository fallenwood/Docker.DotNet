namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerExecCreateResponse // (main.ContainerExecCreateResponse)
{
    [DataMember(Name = "Id", EmitDefaultValue = false)]
    [JsonPropertyName("Id")]
    public string ID { get; set; }
}
