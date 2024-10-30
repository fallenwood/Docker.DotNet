namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class SwarmUpdateConfigParameters // (main.SwarmUpdateConfigParameters)
{
    [DataMember(Name = "Config", EmitDefaultValue = false)]
    public SwarmConfigSpec Config { get; set; }

    [QueryStringParameter("version", true)]
    public long Version { get; set; }
}
