namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class RestartPolicy // (container.RestartPolicy)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    [JsonPropertyName("Name")]
    public RestartPolicyKind Name { get; set; }

    [DataMember(Name = "MaximumRetryCount", EmitDefaultValue = false)]
    [JsonPropertyName("MaximumRetryCount")]
    public long MaximumRetryCount { get; set; }
}
