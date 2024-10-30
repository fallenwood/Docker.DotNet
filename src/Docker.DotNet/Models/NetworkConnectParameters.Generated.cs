namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class NetworkConnectParameters // (network.ConnectOptions)
{
    [DataMember(Name = "Container", EmitDefaultValue = false)]
    public string Container { get; set; }

    [DataMember(Name = "EndpointConfig", EmitDefaultValue = false)]
    public EndpointSettings EndpointConfig { get; set; }
}
