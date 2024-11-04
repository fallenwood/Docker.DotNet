namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class Spec // (swarm.Spec)
{
    public Spec()
    {
    }

    public Spec(Annotations Annotations)
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

    [DataMember(Name = "Orchestration", EmitDefaultValue = false)]
    [JsonPropertyName("Orchestration")]
    public OrchestrationConfig Orchestration { get; set; }

    [DataMember(Name = "Raft", EmitDefaultValue = false)]
    [JsonPropertyName("Raft")]
    public RaftConfig Raft { get; set; }

    [DataMember(Name = "Dispatcher", EmitDefaultValue = false)]
    [JsonPropertyName("Dispatcher")]
    public DispatcherConfig Dispatcher { get; set; }

    [DataMember(Name = "CAConfig", EmitDefaultValue = false)]
    [JsonPropertyName("CAConfig")]
    public CAConfig CAConfig { get; set; }

    [DataMember(Name = "TaskDefaults", EmitDefaultValue = false)]
    [JsonPropertyName("TaskDefaults")]
    public TaskDefaults TaskDefaults { get; set; }

    [DataMember(Name = "EncryptionConfig", EmitDefaultValue = false)]
    [JsonPropertyName("EncryptionConfig")]
    public EncryptionConfig EncryptionConfig { get; set; }
}
