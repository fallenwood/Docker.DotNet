namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class PeerInfo // (network.PeerInfo)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "IP", EmitDefaultValue = false)]
    public string IP { get; set; }
}
