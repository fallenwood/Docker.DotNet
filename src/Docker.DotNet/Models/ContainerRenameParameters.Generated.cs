namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerRenameParameters // (main.ContainerRenameParameters)
{
    [QueryStringParameter("name", false)]
    public string NewName { get; set; }
}
