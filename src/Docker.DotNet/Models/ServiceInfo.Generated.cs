namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class ServiceInfo // (network.ServiceInfo)
{
    [DataMember(Name = "VIP", EmitDefaultValue = false)]
    public string VIP { get; set; }

    [DataMember(Name = "Ports", EmitDefaultValue = false)]
    public IList<string> Ports { get; set; }

    [DataMember(Name = "LocalLBIndex", EmitDefaultValue = false)]
    public long LocalLBIndex { get; set; }

    [DataMember(Name = "Tasks", EmitDefaultValue = false)]
    public IList<NetworkTask> Tasks { get; set; }
}
