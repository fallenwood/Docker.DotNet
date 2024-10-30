namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class PidsStats // (container.PidsStats)
{
    [DataMember(Name = "current", EmitDefaultValue = false)]
    public ulong Current { get; set; }

    [DataMember(Name = "limit", EmitDefaultValue = false)]
    public ulong Limit { get; set; }
}
