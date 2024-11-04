namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SwarmInitParameters // (swarm.InitRequest)
{
    [DataMember(Name = "ListenAddr", EmitDefaultValue = false)]
    [JsonPropertyName("ListenAddr")]
    public string ListenAddr { get; set; }

    [DataMember(Name = "AdvertiseAddr", EmitDefaultValue = false)]
    [JsonPropertyName("AdvertiseAddr")]
    public string AdvertiseAddr { get; set; }

    [DataMember(Name = "DataPathAddr", EmitDefaultValue = false)]
    [JsonPropertyName("DataPathAddr")]
    public string DataPathAddr { get; set; }

    [DataMember(Name = "DataPathPort", EmitDefaultValue = false)]
    [JsonPropertyName("DataPathPort")]
    public uint DataPathPort { get; set; }

    [DataMember(Name = "ForceNewCluster", EmitDefaultValue = false)]
    [JsonPropertyName("ForceNewCluster")]
    public bool ForceNewCluster { get; set; }

    [DataMember(Name = "Spec", EmitDefaultValue = false)]
    [JsonPropertyName("Spec")]
    public Spec Spec { get; set; }

    [DataMember(Name = "AutoLockManagers", EmitDefaultValue = false)]
    [JsonPropertyName("AutoLockManagers")]
    public bool AutoLockManagers { get; set; }

    [DataMember(Name = "Availability", EmitDefaultValue = false)]
    [JsonPropertyName("Availability")]
    public string Availability { get; set; }

    [DataMember(Name = "DefaultAddrPool", EmitDefaultValue = false)]
    [JsonPropertyName("DefaultAddrPool")]
    public IList<string> DefaultAddrPool { get; set; }

    [DataMember(Name = "SubnetSize", EmitDefaultValue = false)]
    [JsonPropertyName("SubnetSize")]
    public uint SubnetSize { get; set; }
}
