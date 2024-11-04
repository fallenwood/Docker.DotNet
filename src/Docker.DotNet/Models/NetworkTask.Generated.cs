namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NetworkTask // (network.Task)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "EndpointID", EmitDefaultValue = false)]
    [JsonPropertyName("EndpointID")]
    public string EndpointID { get; set; }

    [DataMember(Name = "EndpointIP", EmitDefaultValue = false)]
    [JsonPropertyName("EndpointIP")]
    public string EndpointIP { get; set; }

    [DataMember(Name = "Info", EmitDefaultValue = false)]
    [JsonPropertyName("Info")]
    public IDictionary<string, string> Info { get; set; }
}
