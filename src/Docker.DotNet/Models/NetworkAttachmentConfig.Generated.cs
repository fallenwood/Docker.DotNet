namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class NetworkAttachmentConfig // (swarm.NetworkAttachmentConfig)
{
    [DataMember(Name = "Target", EmitDefaultValue = false)]
    public string Target { get; set; }

    [DataMember(Name = "Aliases", EmitDefaultValue = false)]
    public IList<string> Aliases { get; set; }

    [DataMember(Name = "DriverOpts", EmitDefaultValue = false)]
    public IDictionary<string, string> DriverOpts { get; set; }
}
