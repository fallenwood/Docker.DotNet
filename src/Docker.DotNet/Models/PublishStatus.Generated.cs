namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class PublishStatus // (volume.PublishStatus)
{
    [DataMember(Name = "NodeID", EmitDefaultValue = false)]
    public string NodeID { get; set; }

    [DataMember(Name = "State", EmitDefaultValue = false)]
    public string State { get; set; }

    [DataMember(Name = "PublishContext", EmitDefaultValue = false)]
    public IDictionary<string, string> PublishContext { get; set; }
}
