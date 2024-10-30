namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class NetworkingConfig // (network.NetworkingConfig)
{
    [DataMember(Name = "EndpointsConfig", EmitDefaultValue = false)]
    public IDictionary<string, EndpointSettings> EndpointsConfig { get; set; }
}
