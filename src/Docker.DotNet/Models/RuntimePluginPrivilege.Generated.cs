namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class RuntimePluginPrivilege // (runtime.PluginPrivilege)
{
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [DataMember(Name = "description", EmitDefaultValue = false)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [DataMember(Name = "value", EmitDefaultValue = false)]
    [JsonPropertyName("value")]
    public IList<string> Value { get; set; }
}
