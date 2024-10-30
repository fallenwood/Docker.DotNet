namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class NodeCSIInfo // (swarm.NodeCSIInfo)
{
    [DataMember(Name = "PluginName", EmitDefaultValue = false)]
    public string PluginName { get; set; }

    [DataMember(Name = "NodeID", EmitDefaultValue = false)]
    public string NodeID { get; set; }

    [DataMember(Name = "MaxVolumesPerNode", EmitDefaultValue = false)]
    public long MaxVolumesPerNode { get; set; }

    [DataMember(Name = "AccessibleTopology", EmitDefaultValue = false)]
    public Topology AccessibleTopology { get; set; }
}
