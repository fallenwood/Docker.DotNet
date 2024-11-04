namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginConfigLinux // (types.PluginConfigLinux)
{
    [DataMember(Name = "AllowAllDevices", EmitDefaultValue = false)]
    [JsonPropertyName("AllowAllDevices")]
    public bool AllowAllDevices { get; set; }

    [DataMember(Name = "Capabilities", EmitDefaultValue = false)]
    [JsonPropertyName("Capabilities")]
    public IList<string> Capabilities { get; set; }

    [DataMember(Name = "Devices", EmitDefaultValue = false)]
    [JsonPropertyName("Devices")]
    public IList<PluginDevice> Devices { get; set; }
}
