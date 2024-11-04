namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworkSettings // (types.NetworkSettings)
{
    public NetworkSettings()
    {
    }

    public NetworkSettings(NetworkSettingsBase NetworkSettingsBase, DefaultNetworkSettings DefaultNetworkSettings)
    {
        if (NetworkSettingsBase != null)
        {
            this.Bridge = NetworkSettingsBase.Bridge;
            this.SandboxID = NetworkSettingsBase.SandboxID;
            this.SandboxKey = NetworkSettingsBase.SandboxKey;
            this.Ports = NetworkSettingsBase.Ports;
            this.HairpinMode = NetworkSettingsBase.HairpinMode;
            this.LinkLocalIPv6Address = NetworkSettingsBase.LinkLocalIPv6Address;
            this.LinkLocalIPv6PrefixLen = NetworkSettingsBase.LinkLocalIPv6PrefixLen;
            this.SecondaryIPAddresses = NetworkSettingsBase.SecondaryIPAddresses;
            this.SecondaryIPv6Addresses = NetworkSettingsBase.SecondaryIPv6Addresses;
        }

        if (DefaultNetworkSettings != null)
        {
            this.EndpointID = DefaultNetworkSettings.EndpointID;
            this.Gateway = DefaultNetworkSettings.Gateway;
            this.GlobalIPv6Address = DefaultNetworkSettings.GlobalIPv6Address;
            this.GlobalIPv6PrefixLen = DefaultNetworkSettings.GlobalIPv6PrefixLen;
            this.IPAddress = DefaultNetworkSettings.IPAddress;
            this.IPPrefixLen = DefaultNetworkSettings.IPPrefixLen;
            this.IPv6Gateway = DefaultNetworkSettings.IPv6Gateway;
            this.MacAddress = DefaultNetworkSettings.MacAddress;
        }
    }

    [DataMember(Name = "Bridge", EmitDefaultValue = false)]
    [JsonPropertyName("Bridge")]
    public string Bridge { get; set; }

    [DataMember(Name = "SandboxID", EmitDefaultValue = false)]
    [JsonPropertyName("SandboxID")]
    public string SandboxID { get; set; }

    [DataMember(Name = "SandboxKey", EmitDefaultValue = false)]
    [JsonPropertyName("SandboxKey")]
    public string SandboxKey { get; set; }

    [DataMember(Name = "Ports", EmitDefaultValue = false)]
    [JsonPropertyName("Ports")]
    public IDictionary<string, IList<PortBinding>> Ports { get; set; }

    [DataMember(Name = "HairpinMode", EmitDefaultValue = false)]
    [JsonPropertyName("HairpinMode")]
    public bool HairpinMode { get; set; }

    [DataMember(Name = "LinkLocalIPv6Address", EmitDefaultValue = false)]
    [JsonPropertyName("LinkLocalIPv6Address")]
    public string LinkLocalIPv6Address { get; set; }

    [DataMember(Name = "LinkLocalIPv6PrefixLen", EmitDefaultValue = false)]
    [JsonPropertyName("LinkLocalIPv6PrefixLen")]
    public long LinkLocalIPv6PrefixLen { get; set; }

    [DataMember(Name = "SecondaryIPAddresses", EmitDefaultValue = false)]
    [JsonPropertyName("SecondaryIPAddresses")]
    public IList<Address> SecondaryIPAddresses { get; set; }

    [DataMember(Name = "SecondaryIPv6Addresses", EmitDefaultValue = false)]
    [JsonPropertyName("SecondaryIPv6Addresses")]
    public IList<Address> SecondaryIPv6Addresses { get; set; }

    [DataMember(Name = "EndpointID", EmitDefaultValue = false)]
    [JsonPropertyName("EndpointID")]
    public string EndpointID { get; set; }

    [DataMember(Name = "Gateway", EmitDefaultValue = false)]
    [JsonPropertyName("Gateway")]
    public string Gateway { get; set; }

    [DataMember(Name = "GlobalIPv6Address", EmitDefaultValue = false)]
    [JsonPropertyName("GlobalIPv6Address")]
    public string GlobalIPv6Address { get; set; }

    [DataMember(Name = "GlobalIPv6PrefixLen", EmitDefaultValue = false)]
    [JsonPropertyName("GlobalIPv6PrefixLen")]
    public long GlobalIPv6PrefixLen { get; set; }

    [DataMember(Name = "IPAddress", EmitDefaultValue = false)]
    [JsonPropertyName("IPAddress")]
    public string IPAddress { get; set; }

    [DataMember(Name = "IPPrefixLen", EmitDefaultValue = false)]
    [JsonPropertyName("IPPrefixLen")]
    public long IPPrefixLen { get; set; }

    [DataMember(Name = "IPv6Gateway", EmitDefaultValue = false)]
    [JsonPropertyName("IPv6Gateway")]
    public string IPv6Gateway { get; set; }

    [DataMember(Name = "MacAddress", EmitDefaultValue = false)]
    [JsonPropertyName("MacAddress")]
    public string MacAddress { get; set; }

    [DataMember(Name = "Networks", EmitDefaultValue = false)]
    [JsonPropertyName("Networks")]
    public IDictionary<string, EndpointSettings> Networks { get; set; }
}
