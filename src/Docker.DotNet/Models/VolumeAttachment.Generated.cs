namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class VolumeAttachment // (swarm.VolumeAttachment)
{
    [DataMember(Name = "ID", EmitDefaultValue = false)]
    public string ID { get; set; }

    [DataMember(Name = "Source", EmitDefaultValue = false)]
    public string Source { get; set; }

    [DataMember(Name = "Target", EmitDefaultValue = false)]
    public string Target { get; set; }
}
