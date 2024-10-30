namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class LogConfig // (container.LogConfig)
{
    [DataMember(Name = "Type", EmitDefaultValue = false)]
    public string Type { get; set; }

    [DataMember(Name = "Config", EmitDefaultValue = false)]
    public IDictionary<string, string> Config { get; set; }
}
