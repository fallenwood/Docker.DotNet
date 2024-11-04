namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SecretSpec // (swarm.SecretSpec)
{
    public SecretSpec()
    {
    }

    public SecretSpec(Annotations Annotations)
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

    [DataMember(Name = "Data", EmitDefaultValue = false)]
    [JsonPropertyName("Data")]
    public IList<byte> Data { get; set; }

    [DataMember(Name = "Driver", EmitDefaultValue = false)]
    [JsonPropertyName("Driver")]
    public SwarmDriver Driver { get; set; }

    [DataMember(Name = "Templating", EmitDefaultValue = false)]
    [JsonPropertyName("Templating")]
    public SwarmDriver Templating { get; set; }
}
