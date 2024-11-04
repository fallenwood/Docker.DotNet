namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class VersionResponse // (types.Version)
{
    [DataMember(Name = "Components", EmitDefaultValue = false)]
    [JsonPropertyName("Components")]
    public IList<ComponentVersion> Components { get; set; }

    [DataMember(Name = "Version", EmitDefaultValue = false)]
    [JsonPropertyName("Version")]
    public string Version { get; set; }

    [DataMember(Name = "ApiVersion", EmitDefaultValue = false)]
    [JsonPropertyName("ApiVersion")]
    public string APIVersion { get; set; }

    [DataMember(Name = "MinAPIVersion", EmitDefaultValue = false)]
    [JsonPropertyName("MinAPIVersion")]
    public string MinAPIVersion { get; set; }

    [DataMember(Name = "GitCommit", EmitDefaultValue = false)]
    [JsonPropertyName("GitCommit")]
    public string GitCommit { get; set; }

    [DataMember(Name = "GoVersion", EmitDefaultValue = false)]
    [JsonPropertyName("GoVersion")]
    public string GoVersion { get; set; }

    [DataMember(Name = "Os", EmitDefaultValue = false)]
    [JsonPropertyName("Os")]
    public string Os { get; set; }

    [DataMember(Name = "Arch", EmitDefaultValue = false)]
    [JsonPropertyName("Arch")]
    public string Arch { get; set; }

    [DataMember(Name = "KernelVersion", EmitDefaultValue = false)]
    [JsonPropertyName("KernelVersion")]
    public string KernelVersion { get; set; }

    [DataMember(Name = "Experimental", EmitDefaultValue = false)]
    [JsonPropertyName("Experimental")]
    public bool Experimental { get; set; }

    [DataMember(Name = "BuildTime", EmitDefaultValue = false)]
    [JsonPropertyName("BuildTime")]
    public string BuildTime { get; set; }
}
