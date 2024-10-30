namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class SwarmCreateConfigParameters // (main.SwarmCreateConfigParameters)
{
    [DataMember(Name = "Config", EmitDefaultValue = false)]
    public SwarmConfigSpec Config { get; set; }
}
