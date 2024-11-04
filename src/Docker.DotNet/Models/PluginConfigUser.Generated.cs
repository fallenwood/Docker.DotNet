namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginConfigUser // (types.PluginConfigUser)
{
    [DataMember(Name = "GID", EmitDefaultValue = false)]
    [JsonPropertyName("GID")]
    public uint GID { get; set; }

    [DataMember(Name = "UID", EmitDefaultValue = false)]
    [JsonPropertyName("UID")]
    public uint UID { get; set; }
}
