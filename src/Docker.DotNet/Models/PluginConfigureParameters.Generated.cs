namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginConfigureParameters // (main.PluginConfigureParameters)
{
    [DataMember(Name = "Args", EmitDefaultValue = false)]
    [JsonPropertyName("Args")]
    public IList<string> Args { get; set; }
}
