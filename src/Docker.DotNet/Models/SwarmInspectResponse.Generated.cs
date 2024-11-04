namespace Docker.DotNet.Models;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SwarmInspectResponse // (swarm.Swarm)
{
    public SwarmInspectResponse()
    {
    }

    public SwarmInspectResponse(ClusterInfo ClusterInfo)
    {
        if (ClusterInfo != null)
        {
            this.ID = ClusterInfo.ID;
            this.Version = ClusterInfo.Version;
            this.CreatedAt = ClusterInfo.CreatedAt;
            this.UpdatedAt = ClusterInfo.UpdatedAt;
            this.Spec = ClusterInfo.Spec;
            this.TLSInfo = ClusterInfo.TLSInfo;
            this.RootRotationInProgress = ClusterInfo.RootRotationInProgress;
            this.DefaultAddrPool = ClusterInfo.DefaultAddrPool;
            this.SubnetSize = ClusterInfo.SubnetSize;
            this.DataPathPort = ClusterInfo.DataPathPort;
        }
    }

    [DataMember(Name = "ID", EmitDefaultValue = false)]
    [JsonPropertyName("ID")]
    public string ID { get; set; }

    [DataMember(Name = "Version", EmitDefaultValue = false)]
    [JsonPropertyName("Version")]
    public Version Version { get; set; }

    [DataMember(Name = "CreatedAt", EmitDefaultValue = false)]
    [JsonPropertyName("CreatedAt")]
    public DateTime CreatedAt { get; set; }

    [DataMember(Name = "UpdatedAt", EmitDefaultValue = false)]
    [JsonPropertyName("UpdatedAt")]
    public DateTime UpdatedAt { get; set; }

    [DataMember(Name = "Spec", EmitDefaultValue = false)]
    [JsonPropertyName("Spec")]
    public Spec Spec { get; set; }

    [DataMember(Name = "TLSInfo", EmitDefaultValue = false)]
    [JsonPropertyName("TLSInfo")]
    public TLSInfo TLSInfo { get; set; }

    [DataMember(Name = "RootRotationInProgress", EmitDefaultValue = false)]
    [JsonPropertyName("RootRotationInProgress")]
    public bool RootRotationInProgress { get; set; }

    [DataMember(Name = "DefaultAddrPool", EmitDefaultValue = false)]
    [JsonPropertyName("DefaultAddrPool")]
    public IList<string> DefaultAddrPool { get; set; }

    [DataMember(Name = "SubnetSize", EmitDefaultValue = false)]
    [JsonPropertyName("SubnetSize")]
    public uint SubnetSize { get; set; }

    [DataMember(Name = "DataPathPort", EmitDefaultValue = false)]
    [JsonPropertyName("DataPathPort")]
    public uint DataPathPort { get; set; }

    [DataMember(Name = "JoinTokens", EmitDefaultValue = false)]
    [JsonPropertyName("JoinTokens")]
    public JoinTokens JoinTokens { get; set; }
}
