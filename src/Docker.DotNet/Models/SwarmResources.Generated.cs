namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SwarmResources // (swarm.Resources)
{
    [DataMember(Name = "NanoCPUs", EmitDefaultValue = false)]
    [JsonPropertyName("NanoCPUs")]
    public long NanoCPUs { get; set; }

    [DataMember(Name = "MemoryBytes", EmitDefaultValue = false)]
    [JsonPropertyName("MemoryBytes")]
    public long MemoryBytes { get; set; }

    [DataMember(Name = "GenericResources", EmitDefaultValue = false)]
    [JsonPropertyName("GenericResources")]
    public IList<GenericResource> GenericResources { get; set; }
}
