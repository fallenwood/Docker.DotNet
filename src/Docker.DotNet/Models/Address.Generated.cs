namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class Address // (network.Address)
{
    [DataMember(Name = "Addr", EmitDefaultValue = false)]
    public string Addr { get; set; }

    [DataMember(Name = "PrefixLen", EmitDefaultValue = false)]
    public long PrefixLen { get; set; }
}
