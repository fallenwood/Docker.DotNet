namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerListProcessesParameters // (main.ContainerListProcessesParameters)
{
    [QueryStringParameter("ps_args", false)]
    public string PsArgs { get; set; }
}
