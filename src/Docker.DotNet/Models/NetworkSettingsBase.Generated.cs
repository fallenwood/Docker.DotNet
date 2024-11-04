namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworkSettingsBase // (types.NetworkSettingsBase)
{
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
}
