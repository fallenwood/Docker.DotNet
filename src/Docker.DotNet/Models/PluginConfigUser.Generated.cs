namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class PluginConfigUser // (types.PluginConfigUser)
{
    [DataMember(Name = "GID", EmitDefaultValue = false)]
    public uint GID { get; set; }

    [DataMember(Name = "UID", EmitDefaultValue = false)]
    public uint UID { get; set; }
}
