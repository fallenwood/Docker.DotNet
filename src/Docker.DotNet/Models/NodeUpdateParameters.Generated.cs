namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class NodeUpdateParameters // (swarm.NodeSpec)
{
    public NodeUpdateParameters()
    {
    }

    public NodeUpdateParameters(Annotations Annotations)
    {
        if (Annotations != null)
        {
            this.Name = Annotations.Name;
            this.Labels = Annotations.Labels;
        }
    }

    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [DataMember(Name = "Labels", EmitDefaultValue = false)]
    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; }

    [DataMember(Name = "Role", EmitDefaultValue = false)]
    [JsonPropertyName("Role")]
    public string Role { get; set; }

    [DataMember(Name = "Availability", EmitDefaultValue = false)]
    [JsonPropertyName("Availability")]
    public string Availability { get; set; }
}
