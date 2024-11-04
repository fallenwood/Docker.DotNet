namespace Docker.DotNet.Models;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworkResponse // (network.Inspect)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "Id", EmitDefaultValue = false)]
    [JsonPropertyName("Id")]
    public string ID { get; set; }

    [DataMember(Name = "Created", EmitDefaultValue = false)]
    [JsonPropertyName("Created")]
    public DateTime Created { get; set; }

    [DataMember(Name = "Scope", EmitDefaultValue = false)]
    [JsonPropertyName("Scope")]
    public string Scope { get; set; }

    [DataMember(Name = "Driver", EmitDefaultValue = false)]
    [JsonPropertyName("Driver")]
    public string Driver { get; set; }

    [DataMember(Name = "EnableIPv6", EmitDefaultValue = false)]
    [JsonPropertyName("EnableIPv6")]
    public bool EnableIPv6 { get; set; }

    [DataMember(Name = "IPAM", EmitDefaultValue = false)]
    [JsonPropertyName("IPAM")]
    public IPAM IPAM { get; set; }

    [DataMember(Name = "Internal", EmitDefaultValue = false)]
    [JsonPropertyName("Internal")]
    public bool Internal { get; set; }

    [DataMember(Name = "Attachable", EmitDefaultValue = false)]
    [JsonPropertyName("Attachable")]
    public bool Attachable { get; set; }

    [DataMember(Name = "Ingress", EmitDefaultValue = false)]
    [JsonPropertyName("Ingress")]
    public bool Ingress { get; set; }

    [DataMember(Name = "ConfigFrom", EmitDefaultValue = false)]
    [JsonPropertyName("ConfigFrom")]
    public ConfigReference ConfigFrom { get; set; }

    [DataMember(Name = "ConfigOnly", EmitDefaultValue = false)]
    [JsonPropertyName("ConfigOnly")]
    public bool ConfigOnly { get; set; }

    [DataMember(Name = "Containers", EmitDefaultValue = false)]
    [JsonPropertyName("Containers")]
    public IDictionary<string, EndpointResource> Containers { get; set; }

    [DataMember(Name = "Options", EmitDefaultValue = false)]
    [JsonPropertyName("Options")]
    public IDictionary<string, string> Options { get; set; }

    [DataMember(Name = "Labels", EmitDefaultValue = false)]
    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; }

    [DataMember(Name = "Peers", EmitDefaultValue = false)]
    [JsonPropertyName("Peers")]
    public IList<PeerInfo> Peers { get; set; }

    [DataMember(Name = "Services", EmitDefaultValue = false)]
    [JsonPropertyName("Services")]
    public IDictionary<string, ServiceInfo> Services { get; set; }
}
