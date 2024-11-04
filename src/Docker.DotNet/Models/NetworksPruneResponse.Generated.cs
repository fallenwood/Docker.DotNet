namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworksPruneResponse // (network.PruneReport)
{
    [DataMember(Name = "NetworksDeleted", EmitDefaultValue = false)]
    [JsonPropertyName("NetworksDeleted")]
    public IList<string> NetworksDeleted { get; set; }
}
