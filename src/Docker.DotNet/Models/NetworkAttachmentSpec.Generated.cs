namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworkAttachmentSpec // (swarm.NetworkAttachmentSpec)
{
    [DataMember(Name = "ContainerID", EmitDefaultValue = false)]
    [JsonPropertyName("ContainerID")]
    public string ContainerID { get; set; }
}
