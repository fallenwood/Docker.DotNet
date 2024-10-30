namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerStopParameters // (main.ContainerStopParameters)
{
    [QueryStringParameter("t", false)]
    public uint? WaitBeforeKillSeconds { get; set; }
}
