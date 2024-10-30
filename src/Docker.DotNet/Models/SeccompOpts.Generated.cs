namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class SeccompOpts // (swarm.SeccompOpts)
{
    [DataMember(Name = "Mode", EmitDefaultValue = false)]
    public string Mode { get; set; }

    [DataMember(Name = "Profile", EmitDefaultValue = false)]
    public IList<byte> Profile { get; set; }
}
