namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class PluginConfigureParameters // (main.PluginConfigureParameters)
{
    [DataMember(Name = "Args", EmitDefaultValue = false)]
    public IList<string> Args { get; set; }
}
