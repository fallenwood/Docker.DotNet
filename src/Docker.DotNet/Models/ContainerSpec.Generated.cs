namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerSpec // (swarm.ContainerSpec)
{
    [DataMember(Name = "Image", EmitDefaultValue = false)]
    [JsonPropertyName("Image")]
    public string Image { get; set; }

    [DataMember(Name = "Labels", EmitDefaultValue = false)]
    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; }

    [DataMember(Name = "Command", EmitDefaultValue = false)]
    [JsonPropertyName("Command")]
    public IList<string> Command { get; set; }

    [DataMember(Name = "Args", EmitDefaultValue = false)]
    [JsonPropertyName("Args")]
    public IList<string> Args { get; set; }

    [DataMember(Name = "Hostname", EmitDefaultValue = false)]
    [JsonPropertyName("Hostname")]
    public string Hostname { get; set; }

    [DataMember(Name = "Env", EmitDefaultValue = false)]
    [JsonPropertyName("Env")]
    public IList<string> Env { get; set; }

    [DataMember(Name = "Dir", EmitDefaultValue = false)]
    [JsonPropertyName("Dir")]
    public string Dir { get; set; }

    [DataMember(Name = "User", EmitDefaultValue = false)]
    [JsonPropertyName("User")]
    public string User { get; set; }

    [DataMember(Name = "Groups", EmitDefaultValue = false)]
    [JsonPropertyName("Groups")]
    public IList<string> Groups { get; set; }

    [DataMember(Name = "Privileges", EmitDefaultValue = false)]
    [JsonPropertyName("Privileges")]
    public Privileges Privileges { get; set; }

    [DataMember(Name = "Init", EmitDefaultValue = false)]
    [JsonPropertyName("Init")]
    public bool? Init { get; set; }

    [DataMember(Name = "StopSignal", EmitDefaultValue = false)]
    [JsonPropertyName("StopSignal")]
    public string StopSignal { get; set; }

    [DataMember(Name = "TTY", EmitDefaultValue = false)]
    [JsonPropertyName("TTY")]
    public bool TTY { get; set; }

    [DataMember(Name = "OpenStdin", EmitDefaultValue = false)]
    [JsonPropertyName("OpenStdin")]
    public bool OpenStdin { get; set; }

    [DataMember(Name = "ReadOnly", EmitDefaultValue = false)]
    [JsonPropertyName("ReadOnly")]
    public bool ReadOnly { get; set; }

    [DataMember(Name = "Mounts", EmitDefaultValue = false)]
    [JsonPropertyName("Mounts")]
    public IList<Mount> Mounts { get; set; }

    [DataMember(Name = "StopGracePeriod", EmitDefaultValue = false)]
    [JsonPropertyName("StopGracePeriod")]
    public long? StopGracePeriod { get; set; }

    [DataMember(Name = "Healthcheck", EmitDefaultValue = false)]
    [JsonPropertyName("Healthcheck")]
    public HealthcheckConfig Healthcheck { get; set; }

    [DataMember(Name = "Hosts", EmitDefaultValue = false)]
    [JsonPropertyName("Hosts")]
    public IList<string> Hosts { get; set; }

    [DataMember(Name = "DNSConfig", EmitDefaultValue = false)]
    [JsonPropertyName("DNSConfig")]
    public DNSConfig DNSConfig { get; set; }

    [DataMember(Name = "Secrets", EmitDefaultValue = false)]
    [JsonPropertyName("Secrets")]
    public IList<SecretReference> Secrets { get; set; }

    [DataMember(Name = "Configs", EmitDefaultValue = false)]
    [JsonPropertyName("Configs")]
    public IList<SwarmConfigReference> Configs { get; set; }

    [DataMember(Name = "Isolation", EmitDefaultValue = false)]
    [JsonPropertyName("Isolation")]
    public string Isolation { get; set; }

    [DataMember(Name = "Sysctls", EmitDefaultValue = false)]
    [JsonPropertyName("Sysctls")]
    public IDictionary<string, string> Sysctls { get; set; }

    [DataMember(Name = "CapabilityAdd", EmitDefaultValue = false)]
    [JsonPropertyName("CapabilityAdd")]
    public IList<string> CapabilityAdd { get; set; }

    [DataMember(Name = "CapabilityDrop", EmitDefaultValue = false)]
    [JsonPropertyName("CapabilityDrop")]
    public IList<string> CapabilityDrop { get; set; }

    [DataMember(Name = "Ulimits", EmitDefaultValue = false)]
    [JsonPropertyName("Ulimits")]
    public IList<Ulimit> Ulimits { get; set; }

    [DataMember(Name = "OomScoreAdj", EmitDefaultValue = false)]
    [JsonPropertyName("OomScoreAdj")]
    public long OomScoreAdj { get; set; }
}
