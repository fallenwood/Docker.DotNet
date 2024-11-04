namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class PluginConfig // (types.PluginConfig)
{
    [DataMember(Name = "Args", EmitDefaultValue = false)]
    [JsonPropertyName("Args")]
    public PluginConfigArgs Args { get; set; }

    [DataMember(Name = "Description", EmitDefaultValue = false)]
    [JsonPropertyName("Description")]
    public string Description { get; set; }

    [DataMember(Name = "DockerVersion", EmitDefaultValue = false)]
    [JsonPropertyName("DockerVersion")]
    public string DockerVersion { get; set; }

    [DataMember(Name = "Documentation", EmitDefaultValue = false)]
    [JsonPropertyName("Documentation")]
    public string Documentation { get; set; }

    [DataMember(Name = "Entrypoint", EmitDefaultValue = false)]
    [JsonPropertyName("Entrypoint")]
    public IList<string> Entrypoint { get; set; }

    [DataMember(Name = "Env", EmitDefaultValue = false)]
    [JsonPropertyName("Env")]
    public IList<PluginEnv> Env { get; set; }

    [DataMember(Name = "Interface", EmitDefaultValue = false)]
    [JsonPropertyName("Interface")]
    public PluginConfigInterface Interface { get; set; }

    [DataMember(Name = "IpcHost", EmitDefaultValue = false)]
    [JsonPropertyName("IpcHost")]
    public bool IpcHost { get; set; }

    [DataMember(Name = "Linux", EmitDefaultValue = false)]
    [JsonPropertyName("Linux")]
    public PluginConfigLinux Linux { get; set; }

    [DataMember(Name = "Mounts", EmitDefaultValue = false)]
    [JsonPropertyName("Mounts")]
    public IList<PluginMount> Mounts { get; set; }

    [DataMember(Name = "Network", EmitDefaultValue = false)]
    [JsonPropertyName("Network")]
    public PluginConfigNetwork Network { get; set; }

    [DataMember(Name = "PidHost", EmitDefaultValue = false)]
    [JsonPropertyName("PidHost")]
    public bool PidHost { get; set; }

    [DataMember(Name = "PropagatedMount", EmitDefaultValue = false)]
    [JsonPropertyName("PropagatedMount")]
    public string PropagatedMount { get; set; }

    [DataMember(Name = "User", EmitDefaultValue = false)]
    [JsonPropertyName("User")]
    public PluginConfigUser User { get; set; }

    [DataMember(Name = "WorkDir", EmitDefaultValue = false)]
    [JsonPropertyName("WorkDir")]
    public string WorkDir { get; set; }

    [DataMember(Name = "rootfs", EmitDefaultValue = false)]
    [JsonPropertyName("rootfs")]
    public PluginConfigRootfs Rootfs { get; set; }
}
