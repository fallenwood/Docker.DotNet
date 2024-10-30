namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class PluginPrivilege // (types.PluginPrivilege)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "Description", EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(Name = "Value", EmitDefaultValue = false)]
    public IList<string> Value { get; set; }
}
