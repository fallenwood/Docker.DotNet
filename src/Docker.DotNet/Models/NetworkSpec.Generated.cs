namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworkSpec // (swarm.NetworkSpec)
{
    public NetworkSpec()
    {
    }

    public NetworkSpec(Annotations Annotations)
    {
        if (Annotations != null)
        {
            this.Name = Annotations.Name;
            this.Labels = Annotations.Labels;
        }
    }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "Labels", EmitDefaultValue = false)]
    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; }

    [DataMember(Name = "DriverConfiguration", EmitDefaultValue = false)]
    [JsonPropertyName("DriverConfiguration")]
    public SwarmDriver DriverConfiguration { get; set; }

    [DataMember(Name = "IPv6Enabled", EmitDefaultValue = false)]
    [JsonPropertyName("IPv6Enabled")]
    public bool IPv6Enabled { get; set; }

    [DataMember(Name = "Internal", EmitDefaultValue = false)]
    [JsonPropertyName("Internal")]
    public bool Internal { get; set; }

    [DataMember(Name = "Attachable", EmitDefaultValue = false)]
    [JsonPropertyName("Attachable")]
    public bool Attachable { get; set; }

    [DataMember(Name = "Ingress", EmitDefaultValue = false)]
    [JsonPropertyName("Ingress")]
    public bool Ingress { get; set; }

    [DataMember(Name = "IPAMOptions", EmitDefaultValue = false)]
    [JsonPropertyName("IPAMOptions")]
    public IPAMOptions IPAMOptions { get; set; }

    [DataMember(Name = "ConfigFrom", EmitDefaultValue = false)]
    [JsonPropertyName("ConfigFrom")]
    public ConfigReference ConfigFrom { get; set; }

    [DataMember(Name = "Scope", EmitDefaultValue = false)]
    [JsonPropertyName("Scope")]
    public string Scope { get; set; }
}
