namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class Port // (types.Port)
{
    [DataMember(Name = "IP", EmitDefaultValue = false)]
    public string IP { get; set; }

    [DataMember(Name = "PrivatePort", EmitDefaultValue = false)]
    public ushort PrivatePort { get; set; }

    [DataMember(Name = "PublicPort", EmitDefaultValue = false)]
    public ushort PublicPort { get; set; }

    [DataMember(Name = "Type", EmitDefaultValue = false)]
    public string Type { get; set; }
}
