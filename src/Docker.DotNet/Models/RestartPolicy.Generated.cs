namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class RestartPolicy // (container.RestartPolicy)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    public RestartPolicyKind Name { get; set; }

    [DataMember(Name = "MaximumRetryCount", EmitDefaultValue = false)]
    public long MaximumRetryCount { get; set; }
}
