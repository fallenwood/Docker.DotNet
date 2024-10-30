namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class NetworkTask // (network.Task)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "EndpointID", EmitDefaultValue = false)]
    public string EndpointID { get; set; }

    [DataMember(Name = "EndpointIP", EmitDefaultValue = false)]
    public string EndpointIP { get; set; }

    [DataMember(Name = "Info", EmitDefaultValue = false)]
    public IDictionary<string, string> Info { get; set; }
}
