namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerRestartParameters // (main.ContainerRestartParameters)
{
    [DataMember(Name = "Signal", EmitDefaultValue = false)]
    public string Signal { get; set; }

    [QueryStringParameter("t", false)]
    public uint? WaitBeforeKillSeconds { get; set; }
}
