namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SummaryNetworkSettings // (types.SummaryNetworkSettings)
{
    [DataMember(Name = "Networks", EmitDefaultValue = false)]
    [JsonPropertyName("Networks")]
    public IDictionary<string, EndpointSettings> Networks { get; set; }
}
