namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class PluginConfigRootfs // (types.PluginConfigRootfs)
{
    [DataMember(Name = "diff_ids", EmitDefaultValue = false)]
    public IList<string> DiffIds { get; set; }

    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }
}
