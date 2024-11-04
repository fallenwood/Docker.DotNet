namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerNode // (types.ContainerNode)
{
    [DataMember(Name = "ID", EmitDefaultValue = false)]
    [JsonPropertyName("ID")]
    public string ID { get; set; }

    [DataMember(Name = "IP", EmitDefaultValue = false)]
    [JsonPropertyName("IP")]
    public string IPAddress { get; set; }

    [DataMember(Name = "Addr", EmitDefaultValue = false)]
    [JsonPropertyName("Addr")]
    public string Addr { get; set; }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "Cpus", EmitDefaultValue = false)]
    [JsonPropertyName("Cpus")]
    public long Cpus { get; set; }

    [DataMember(Name = "Memory", EmitDefaultValue = false)]
    [JsonPropertyName("Memory")]
    public long Memory { get; set; }

    [DataMember(Name = "Labels", EmitDefaultValue = false)]
    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; }
}
