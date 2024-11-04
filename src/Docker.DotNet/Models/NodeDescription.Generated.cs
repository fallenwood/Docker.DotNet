namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NodeDescription // (swarm.NodeDescription)
{
    [DataMember(Name = "Hostname", EmitDefaultValue = false)]
    [JsonPropertyName("Hostname")]
    public string Hostname { get; set; }

    [DataMember(Name = "Platform", EmitDefaultValue = false)]
    [JsonPropertyName("Platform")]
    public Platform Platform { get; set; }

    [DataMember(Name = "Resources", EmitDefaultValue = false)]
    [JsonPropertyName("Resources")]
    public SwarmResources Resources { get; set; }

    [DataMember(Name = "Engine", EmitDefaultValue = false)]
    [JsonPropertyName("Engine")]
    public EngineDescription Engine { get; set; }

    [DataMember(Name = "TLSInfo", EmitDefaultValue = false)]
    [JsonPropertyName("TLSInfo")]
    public TLSInfo TLSInfo { get; set; }

    [DataMember(Name = "CSIInfo", EmitDefaultValue = false)]
    [JsonPropertyName("CSIInfo")]
    public IList<NodeCSIInfo> CSIInfo { get; set; }
}
