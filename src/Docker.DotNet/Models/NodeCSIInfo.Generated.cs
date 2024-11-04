namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NodeCSIInfo // (swarm.NodeCSIInfo)
{
    [DataMember(Name = "PluginName", EmitDefaultValue = false)]
    [JsonPropertyName("PluginName")]
    public string PluginName { get; set; }

    [DataMember(Name = "NodeID", EmitDefaultValue = false)]
    [JsonPropertyName("NodeID")]
    public string NodeID { get; set; }

    [DataMember(Name = "MaxVolumesPerNode", EmitDefaultValue = false)]
    [JsonPropertyName("MaxVolumesPerNode")]
    public long MaxVolumesPerNode { get; set; }

    [DataMember(Name = "AccessibleTopology", EmitDefaultValue = false)]
    [JsonPropertyName("AccessibleTopology")]
    public Topology AccessibleTopology { get; set; }
}
