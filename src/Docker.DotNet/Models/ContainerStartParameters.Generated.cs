namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerStartParameters // (main.ContainerStartParameters)
{
    [QueryStringParameter("detachKeys", false)]
    public string DetachKeys { get; set; }
}
