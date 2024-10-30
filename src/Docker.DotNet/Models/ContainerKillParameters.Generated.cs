namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerKillParameters // (main.ContainerKillParameters)
{
    [QueryStringParameter("signal", false)]
    public string Signal { get; set; }
}
