namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class NetworkDisconnectParameters // (network.DisconnectOptions)
{
    [DataMember(Name = "Container", EmitDefaultValue = false)]
    public string Container { get; set; }

    [DataMember(Name = "Force", EmitDefaultValue = false)]
    public bool Force { get; set; }
}
