namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworksCreateParameters // (network.CreateRequest)
{
    public NetworksCreateParameters()
    {
    }

    public NetworksCreateParameters(CreateOptions CreateOptions)
    {
        if (CreateOptions != null)
        {
            this.Driver = CreateOptions.Driver;
            this.Scope = CreateOptions.Scope;
            this.EnableIPv6 = CreateOptions.EnableIPv6;
            this.IPAM = CreateOptions.IPAM;
            this.Internal = CreateOptions.Internal;
            this.Attachable = CreateOptions.Attachable;
            this.Ingress = CreateOptions.Ingress;
            this.ConfigOnly = CreateOptions.ConfigOnly;
            this.ConfigFrom = CreateOptions.ConfigFrom;
            this.Options = CreateOptions.Options;
            this.Labels = CreateOptions.Labels;
        }
    }

    [DataMember(Name = "Driver", EmitDefaultValue = false)]
    [JsonPropertyName("Driver")]
    public string Driver { get; set; }

    [DataMember(Name = "Scope", EmitDefaultValue = false)]
    [JsonPropertyName("Scope")]
    public string Scope { get; set; }

    [DataMember(Name = "EnableIPv6", EmitDefaultValue = false)]
    [JsonPropertyName("EnableIPv6")]
    public bool? EnableIPv6 { get; set; }

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

    [DataMember(Name = "ConfigOnly", EmitDefaultValue = false)]
    [JsonPropertyName("ConfigOnly")]
    public bool ConfigOnly { get; set; }

    [DataMember(Name = "ConfigFrom", EmitDefaultValue = false)]
    [JsonPropertyName("ConfigFrom")]
    public ConfigReference ConfigFrom { get; set; }

    [DataMember(Name = "Options", EmitDefaultValue = false)]
    [JsonPropertyName("Options")]
    public IDictionary<string, string> Options { get; set; }

    [DataMember(Name = "Labels", EmitDefaultValue = false)]
    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "CheckDuplicate", EmitDefaultValue = false)]
    [JsonPropertyName("CheckDuplicate")]
    public bool? CheckDuplicate { get; set; }
}
