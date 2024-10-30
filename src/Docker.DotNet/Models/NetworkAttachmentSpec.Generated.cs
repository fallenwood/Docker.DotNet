namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class NetworkAttachmentSpec // (swarm.NetworkAttachmentSpec)
{
    [DataMember(Name = "ContainerID", EmitDefaultValue = false)]
    public string ContainerID { get; set; }
}
