namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class Actor // (events.Actor)
{
    [DataMember(Name = "ID", EmitDefaultValue = false)]
    public string ID { get; set; }

    [DataMember(Name = "Attributes", EmitDefaultValue = false)]
    public IDictionary<string, string> Attributes { get; set; }
}
