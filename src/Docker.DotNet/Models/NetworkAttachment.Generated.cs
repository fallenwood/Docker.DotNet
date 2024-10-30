namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class NetworkAttachment // (swarm.NetworkAttachment)
{
    [DataMember(Name = "Network", EmitDefaultValue = false)]
    public Network Network { get; set; }

    [DataMember(Name = "Addresses", EmitDefaultValue = false)]
    public IList<string> Addresses { get; set; }
}
