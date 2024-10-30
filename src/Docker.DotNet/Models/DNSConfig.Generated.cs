namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class DNSConfig // (swarm.DNSConfig)
{
    [DataMember(Name = "Nameservers", EmitDefaultValue = false)]
    public IList<string> Nameservers { get; set; }

    [DataMember(Name = "Search", EmitDefaultValue = false)]
    public IList<string> Search { get; set; }

    [DataMember(Name = "Options", EmitDefaultValue = false)]
    public IList<string> Options { get; set; }
}
