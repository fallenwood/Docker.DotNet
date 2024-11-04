namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ServiceSpec // (swarm.ServiceSpec)
{
    public ServiceSpec()
    {
    }

    public ServiceSpec(Annotations Annotations)
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

    [DataMember(Name = "TaskTemplate", EmitDefaultValue = false)]
    [JsonPropertyName("TaskTemplate")]
    public TaskSpec TaskTemplate { get; set; }

    [DataMember(Name = "Mode", EmitDefaultValue = false)]
    [JsonPropertyName("Mode")]
    public ServiceMode Mode { get; set; }

    [DataMember(Name = "UpdateConfig", EmitDefaultValue = false)]
    [JsonPropertyName("UpdateConfig")]
    public SwarmUpdateConfig UpdateConfig { get; set; }

    [DataMember(Name = "RollbackConfig", EmitDefaultValue = false)]
    [JsonPropertyName("RollbackConfig")]
    public SwarmUpdateConfig RollbackConfig { get; set; }

    [DataMember(Name = "Networks", EmitDefaultValue = false)]
    [JsonPropertyName("Networks")]
    public IList<NetworkAttachmentConfig> Networks { get; set; }

    [DataMember(Name = "EndpointSpec", EmitDefaultValue = false)]
    [JsonPropertyName("EndpointSpec")]
    public EndpointSpec EndpointSpec { get; set; }
}
