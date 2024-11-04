namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginConfigInterface // (types.PluginConfigInterface)
{
    [DataMember(Name = "ProtocolScheme", EmitDefaultValue = false)]
    [JsonPropertyName("ProtocolScheme")]
    public string ProtocolScheme { get; set; }

    [DataMember(Name = "Socket", EmitDefaultValue = false)]
    [JsonPropertyName("Socket")]
    public string Socket { get; set; }

    [DataMember(Name = "Types", EmitDefaultValue = false)]
    [JsonPropertyName("Types")]
    public IList<string> Types { get; set; }
}
