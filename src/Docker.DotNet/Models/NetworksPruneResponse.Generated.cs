namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class NetworksPruneResponse // (network.PruneReport)
{
    [DataMember(Name = "NetworksDeleted", EmitDefaultValue = false)]
    public IList<string> NetworksDeleted { get; set; }
}
