namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworkStats // (container.NetworkStats)
{
    [DataMember(Name = "rx_bytes", EmitDefaultValue = false)]
    [JsonPropertyName("rx_bytes")]
    public ulong RxBytes { get; set; }

    [DataMember(Name = "rx_packets", EmitDefaultValue = false)]
    [JsonPropertyName("rx_packets")]
    public ulong RxPackets { get; set; }

    [DataMember(Name = "rx_errors", EmitDefaultValue = false)]
    [JsonPropertyName("rx_errors")]
    public ulong RxErrors { get; set; }

    [DataMember(Name = "rx_dropped", EmitDefaultValue = false)]
    [JsonPropertyName("rx_dropped")]
    public ulong RxDropped { get; set; }

    [DataMember(Name = "tx_bytes", EmitDefaultValue = false)]
    [JsonPropertyName("tx_bytes")]
    public ulong TxBytes { get; set; }

    [DataMember(Name = "tx_packets", EmitDefaultValue = false)]
    [JsonPropertyName("tx_packets")]
    public ulong TxPackets { get; set; }

    [DataMember(Name = "tx_errors", EmitDefaultValue = false)]
    [JsonPropertyName("tx_errors")]
    public ulong TxErrors { get; set; }

    [DataMember(Name = "tx_dropped", EmitDefaultValue = false)]
    [JsonPropertyName("tx_dropped")]
    public ulong TxDropped { get; set; }

    [DataMember(Name = "endpoint_id", EmitDefaultValue = false)]
    [JsonPropertyName("endpoint_id")]
    public string EndpointID { get; set; }

    [DataMember(Name = "instance_id", EmitDefaultValue = false)]
    [JsonPropertyName("instance_id")]
    public string InstanceID { get; set; }
}
