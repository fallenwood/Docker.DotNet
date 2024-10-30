namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class SummaryNetworkSettings // (types.SummaryNetworkSettings)
{
    [DataMember(Name = "Networks", EmitDefaultValue = false)]
    public IDictionary<string, EndpointSettings> Networks { get; set; }
}
