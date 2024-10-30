namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class UsageData // (volume.UsageData)
{
    [DataMember(Name = "RefCount", EmitDefaultValue = false)]
    public long RefCount { get; set; }

    [DataMember(Name = "Size", EmitDefaultValue = false)]
    public long Size { get; set; }
}
