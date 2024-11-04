namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ServiceInfo // (network.ServiceInfo)
{
    [DataMember(Name = "VIP", EmitDefaultValue = false)]
    [JsonPropertyName("VIP")]
    public string VIP { get; set; }

    [DataMember(Name = "Ports", EmitDefaultValue = false)]
    [JsonPropertyName("Ports")]
    public IList<string> Ports { get; set; }

    [DataMember(Name = "LocalLBIndex", EmitDefaultValue = false)]
    [JsonPropertyName("LocalLBIndex")]
    public long LocalLBIndex { get; set; }

    [DataMember(Name = "Tasks", EmitDefaultValue = false)]
    [JsonPropertyName("Tasks")]
    public IList<NetworkTask> Tasks { get; set; }
}
