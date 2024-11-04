namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginConfigRootfs // (types.PluginConfigRootfs)
{
    [DataMember(Name = "diff_ids", EmitDefaultValue = false)]
    [JsonPropertyName("diff_ids")]
    public IList<string> DiffIds { get; set; }

    [DataMember(Name = "type", EmitDefaultValue = false)]
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
